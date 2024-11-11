using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptforstart : MonoBehaviour
{
    public void GotoScene()
    {
        SceneManager.LoadScene("Bedroom");
        
    }

    public void GotoScene2()
    {
        SceneManager.LoadScene("Tutorial");

    }

    public void GotoScene3()
    {
        SceneManager.LoadScene("StartPage");

    }
}
