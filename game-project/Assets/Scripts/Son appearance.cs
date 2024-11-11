using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingroomInit : MonoBehaviour
{
    [Header("Son")]
    [SerializeField] private GameObject son;
    // Start is called before the first frame update
    void Start()
    {
        int day = MainManager.instance.getDay();
        switch (day)
        {
            case 1:
                son.SetActive(true);
                break;
            case 2:
                son.SetActive(false);
                break;
            case 3:
                son.SetActive(false);
                break;
            case 4:
                son.SetActive(false);
                break;
            default:
                Debug.LogError("Day is not within 1 to 4, error loading dialogue");
                break;
        }
    }
}
