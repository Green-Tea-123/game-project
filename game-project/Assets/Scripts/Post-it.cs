using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postit : MonoBehaviour
{
    [Header("postit")]
    [SerializeField] private GameObject postit;

    void Start()
    {
        int day = MainManager.instance.getDay();
        switch (day)
        {
            case 1:
                postit.SetActive(true);
                break;
            case 2:
                postit.SetActive(false);
                break;
            case 3:
                postit.SetActive(false);
                break;
            case 4:
                postit.SetActive(false);
                break;
            default:
                Debug.LogError("Day is not within 1 to 4, error loading dialogue");
                break;
        }
    }
}
