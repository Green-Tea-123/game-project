using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]

    [Header("Day 1 Ink")]
    [SerializeField] private TextAsset day1Json;

    [Header("Day 2 Ink")]
    [SerializeField] private TextAsset day2Json;

    [Header("Day 3 Ink")]
    [SerializeField] private TextAsset day3Json;

    [Header("Day 4 Ink")]
    [SerializeField] private TextAsset day4Json;

    private bool playerInRange;

    private bool interacteditem = false;

    private void Awake() 
    {
        playerInRange = false;
       // visualCue.SetActive(false);
    }

    private void Update() 
    {
        int day = MainManager.instance.getDay();
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !interacteditem) 
        {
            visualCue.SetActive(true);
            if (InputManager.GetInstance().GetInteractPressed()) 
            {
                interacteditem = true;
                switch (day) {
                    case 1:
                        
                        DialogueManager.GetInstance().EnterDialogueMode(day1Json);
                        
                        break;
                    case 2:
                        
                        DialogueManager.GetInstance().EnterDialogueMode(day2Json);
                        
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
        }
        else 
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}