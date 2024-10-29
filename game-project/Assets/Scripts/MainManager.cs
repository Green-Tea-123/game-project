using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager INSTANCE;

    private void Awake()
    {
        INSTANCE = this;
        DontDestroyOnLoad(gameObject);
    }
}
