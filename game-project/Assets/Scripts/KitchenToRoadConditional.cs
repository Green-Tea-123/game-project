using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenToRoadConditional : ChangeSceneOnCollision
{
    [Header("Deny change scene message")]
    [SerializeField] private TextAsset textJson;
    [SerializeField] private string goodSceneName;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player") && BreakfastTracker.hasEatenBreakfast) {
            if (MainManager.instance.getDay() == 4){
                SceneManager.LoadScene(goodSceneName);
            }
            else{
                SceneManager.LoadScene(nextSceneName);
            }
        } else {
            DialogueManager.GetInstance().EnterDialogueMode(textJson);
        }
    }
}
            