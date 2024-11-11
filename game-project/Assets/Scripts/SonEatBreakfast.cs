using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonEatBreakfast : DialogueTrigger
{
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
