using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomInit : MonoBehaviour
{
    [Header("Day 1 Ink")]
    [SerializeField] private TextAsset day1Json;

    [Header("Day 2 Ink")]
    [SerializeField] private TextAsset day2Json;

    [Header("Day 3 Ink")]
    [SerializeField] private TextAsset day3Json;

    [Header("Day 4 Ink")]
    [SerializeField] private TextAsset day4Json;
    // Start is called before the first frame update
    void Start()
    {
        int day = MainManager.instance.getDay();
        switch (day)
        {
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
                Debug.LogError("Day is not within 1 to 4, error loading dialogue");
                break;
        }
    }
}
