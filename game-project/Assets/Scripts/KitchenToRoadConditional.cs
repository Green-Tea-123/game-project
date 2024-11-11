using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenToRoadConditional : ChangeSceneOnCollision
{
    [Header("Deny change scene message")]
    [SerializeField] private TextAsset textJson;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player") && BreakfastTracker.hasEatenBreakfast) {
            SceneManager.LoadScene(nextSceneName);
        } else {
            DialogueManager.GetInstance().EnterDialogueMode(textJson);
        }
    }
}
