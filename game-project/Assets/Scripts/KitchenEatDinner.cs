using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenEatDinner : DialogueTrigger {
    // Start is called before the first frame update
    void Start() {

    }

    private void Update() {
        int day = MainManager.instance.getDay();
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !interacteditem) {
            visualCue.SetActive(true);
            if (InputManager.GetInstance().GetInteractPressed()) {
                interacteditem = true;
                switch (day) {
                    case 1:
                        BreakfastTracker.eatBreakfast();
                        DialogueManager.GetInstance().EnterDialogueMode(day1Json);
                        break;
                    case 2:
                        BreakfastTracker.eatBreakfast();
                        DialogueManager.GetInstance().EnterDialogueMode(day2Json);

                        break;
                    case 3:
                        BreakfastTracker.eatBreakfast();
                        DialogueManager.GetInstance().EnterDialogueMode(day3Json);

                        break;
                    case 4:
                        BreakfastTracker.eatBreakfast();
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
}