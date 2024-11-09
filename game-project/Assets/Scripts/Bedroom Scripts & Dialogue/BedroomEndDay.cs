using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedroomEndDay : MonoBehaviour
{
    [Header("Day 1 Ink")]
    [SerializeField] private TextAsset day1Json;

    [Header("Day 2 Ink")]
    [SerializeField] private TextAsset day2Json;

    [Header("Day 3 Ink")]
    [SerializeField] private TextAsset day3Json;

    public string nextSceneName;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            handleEndOfDayDialogue();
            handleEndOfDayLogic();
            SceneManager.LoadScene(nextSceneName);
        }
    }

    private void handleEndOfDayLogic() {
        MainManager.instance.checkTasks();
        MainManager.instance.incrementDay();
    }

    private void handleEndOfDayDialogue() {
        int day = MainManager.instance.getDay();
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
            default:
                Debug.LogError("Day is not within 1 to 3, error loading dialogue");
                break;
        }
    }
}
