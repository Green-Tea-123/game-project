using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CCTrigger : DialogueTrigger {

    public CanvasGroup fadeCanvasGroup;
    public float fadeSpeed = 1f;
    public string taichiScene;
    public string mahjongScene;

    private void Update() {
        int day = MainManager.instance.getDay();
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying 
            && !interacteditem && !MainManager.instance.hasVisitedCC) {
            visualCue.SetActive(true);
            if (InputManager.GetInstance().GetInteractPressed()) {
                interacteditem = true;
                switch (day) {
                    case 1:
                        MainManager.instance.hasVisitedCC = true;
                        DialogueManager.GetInstance().EnterDialogueMode(day1Json);
                        StartCoroutine(startTaichi());
                        break;
                    case 2:
                        MainManager.instance.hasVisitedCC = true;
                        DialogueManager.GetInstance().EnterDialogueMode(day2Json);
                        StartCoroutine(startMahjong());
                        break;
                    case 3:

                        DialogueManager.GetInstance().EnterDialogueMode(day3Json);

                        break;
                    case 4:

                        DialogueManager.GetInstance().EnterDialogueMode(day4Json);

                        break;
                    default:
                        Debug.LogError("day " + day + " is out of bounds");
                        break;
                }
            }
        } else {
            visualCue.SetActive(false);
        }
    }

    private IEnumerator startTaichi() {
        yield return new WaitWhile(() => DialogueManager.GetInstance().dialogueIsPlaying);
        float alpha = 0f;
        while (alpha < 1f) {
            alpha += fadeSpeed * Time.deltaTime;
            fadeCanvasGroup.alpha = alpha;
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(taichiScene);
    }

    private IEnumerator startMahjong() {
        yield return new WaitWhile(() => DialogueManager.GetInstance().dialogueIsPlaying);
        float alpha = 0f;
        while (alpha < 1f) {
            alpha += fadeSpeed * Time.deltaTime;
            fadeCanvasGroup.alpha = alpha;
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(mahjongScene);
    }
}
