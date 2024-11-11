using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastTracker : MonoBehaviour
{
    public static bool hasEatenBreakfast;
    // Start is called before the first frame update
    void Start()
    {
        hasEatenBreakfast = false;
    }

    public static void eatBreakfast() {
        hasEatenBreakfast = true;
    }
}
