using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanagertimelinescript : MonoBehaviour
{
    public float changetime;
    public string scenename;

    private void Update()
    {
        changetime -= Time.deltaTime;
        if(changetime <= 0)
        {
            SceneManager.LoadScene(scenename);
        }

    }
   
}
