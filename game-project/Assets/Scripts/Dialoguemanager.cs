using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject Nextbutton;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI displayNameText;
    [SerializeField] private Animator portraitAnimator;
    [SerializeField] private GameObject Notes;
    [SerializeField] private Canvas canvas;
    private Animator layoutAnimator;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;


    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }

    private static DialogueManager instance;

    private const string SPEAKER_TAG = "speaker";
    private const string PORTRAIT_TAG = "portrait";
    private const string LAYOUT_TAG = "layout";
    private Externalfunction inkExternalfunction;
    

    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
            Destroy(gameObject);
            return;
        }
        instance = this;
        inkExternalfunction = new Externalfunction();
        DontDestroyOnLoad(gameObject);

    }

    public static DialogueManager GetInstance() 
    {
        return instance;
    }

    private void Start() 
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        for (int lengz = 0; lengz < choices.Length; lengz++) {
            choices[lengz].SetActive(false);
        }

        // get the layout animator
        //layoutAnimator = dialoguePanel.GetComponent<Animator>();

        // get all of the choices text 
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices) 
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update() 
    {
        // return right away if dialogue isn't playing
        if (!dialogueIsPlaying) 
        {
            return;
        }

        // handle continuing to the next line in the dialogue when submit is pressed
        // NOTE: The 'currentStory.currentChoiecs.Count == 0' part was to fix a bug after the Youtube video was made
        if (currentStory.currentChoices.Count == 0 && InputManager.GetInstance().GetSubmitPressed())
        {
            ContinueStory();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        // reset portrait, layout, and speaker
        inkExternalfunction.bind(currentStory);

        ContinueStory();
    }

    private IEnumerator ExitDialogueMode() 
    {
        yield return new WaitForSeconds(0.2f);
        inkExternalfunction.unbind(currentStory);
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    public void ContinueStory() 
    {
        Nextbutton.SetActive(true);
        if (currentStory.canContinue) 
        {
            
            // set text for the current dialogue line
            dialogueText.text = currentStory.Continue();
            // display choices, if any, for this dialogue line
            DisplayChoices();
            // handle tags
            HandleTags(currentStory.currentTags);
        }
        else 
        {
            StartCoroutine(ExitDialogueMode());
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        // loop through each tag and handle it accordingly
        foreach (string tag in currentTags) 
        {
            // parse the tag
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2) 
            {
                Debug.LogError("Tag could not be appropriately parsed: " + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();
            
            // handle the tag
            switch (tagKey) 
            {
                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    portraitAnimator.Play(tagValue);
                    break;
                case LAYOUT_TAG:
                    layoutAnimator.Play(tagValue);
                    break;
                default:
                    Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                    break;
            }
        }
    }

    private void DisplayChoices() 
    {
        List<Choice> currentChoices = currentStory.currentChoices;


        // defensive check to make sure our UI can support the number of choices coming in
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given: " 
                + currentChoices.Count);
        }

        int index = 0;
        // enable and initialize the choices up to the amount of choices for this line of dialogue
        foreach(Choice choice in currentChoices) 
        {
            Nextbutton.SetActive(false);
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // go through the remaining choices the UI supports and make sure they're hidden
        for (int i = index; i < choices.Length; i++) 
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice() 
    {
        // Event System requires we clear it first, then wait
        // for at least one frame before we set the current selected object.
        /*EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);*/
        UnityEngine.UI.Selectable firstChoice = choices[0].GetComponent<UnityEngine.UI.Selectable>();

        // Set the first choice as selected
        firstChoice.Select();

        // Wait for spacebar to be pressed
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Do something when spacebar is pressed
                Debug.Log("Spacebar was pressed!");
                break;
            }
            yield return null;
        }

        // Return a value at the end of the method
        yield return null;
    }

    public void MakeChoice(int choiceIndex)
    {
        /*currentStory.ChooseChoiceIndex(choiceIndex);
        // NOTE: The below two lines were added to fix a bug after the Youtube video was made
        InputManager.GetInstance().RegisterSubmitPressed(); // this is specific to my InputManager script*/
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

    public void showNote()
    {
        this.Notes.SetActive(true);
    }
    public void hideNote()
    {
        this.Notes.SetActive(false);
    }

    public GameObject getChildObject(string path)
    {
        Transform child = transform.Find(path);
        if (child != null)
        {
            return child.gameObject;
        }
        Debug.LogWarning("Path not found: " + path);
        return null;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
        canvas.worldCamera = Camera.main;
    }

}