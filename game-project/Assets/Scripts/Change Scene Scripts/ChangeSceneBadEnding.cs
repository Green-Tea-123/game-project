using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneBadEnding : ChangeSceneOnCollision {
    public string badSceneName;
    public int threshold;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            //if (MainManager.instance.getDay() == 4) { // MainManager.instance.getDementiaCounter() >= threshold
            if (MainManager.instance.getDementiaCounter() >= threshold)
            { 
                SceneManager.LoadScene(badSceneName); 
            }

            else {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }

}
