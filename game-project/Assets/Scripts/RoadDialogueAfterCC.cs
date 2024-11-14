using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDialogueAfterCC : MonoBehaviour
{
    [Header("Day 1 Ink")]
    [SerializeField] protected TextAsset day1Json;

    [Header("Day 2 Ink")]
    [SerializeField] protected TextAsset day2Json;

    // Start is called before the first frame update
    void Start()
    {
        if (MainManager.instance.hasVisitedCC) {
            int day = MainManager.instance.getDay();
            switch (day) {
                case 1:
                    DialogueManager.GetInstance().EnterDialogueMode(day1Json);
                    break;
                case 2:
                    DialogueManager.GetInstance().EnterDialogueMode(day2Json);
                    break;
                default:
                    Debug.LogError("Day not between 1 and 2");
                    break;
            }
        }
    }
}
