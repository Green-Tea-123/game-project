using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Class that handles all global variables shared between scenes.
 * To use the functions here, call <code>MainManager.instance</code>,
 * followed by the function you want to call.
 */
public class MainManager : MonoBehaviour {
    public static MainManager instance;
    private int dementiaCounter;
    private int day;

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }

        instance = this;
        this.dementiaCounter = 0;
        this.day = 1;
        DontDestroyOnLoad(gameObject);
    }

    public int getDementiaCounter() {
        Debug.Log("Dementia counter retrieved." 
            + "Value of counter is: " + this.dementiaCounter);
        return this.dementiaCounter;
    }

    public void incrementDementiaCounter() {
        this.dementiaCounter++;
        Debug.Log("Dementia counter has been incremented."
            + "counter is now at: " + this.dementiaCounter);
    }

    public int getDay() {
        return this.day;
    }

    public void incrementDay() {
        this.day++;
    }
}
