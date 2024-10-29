using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    public string nextSceneName;

    public ChangeSceneOnCollision(string nextSceneName)
    {
        this.nextSceneName = nextSceneName;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(nextSceneName);
    }
}
