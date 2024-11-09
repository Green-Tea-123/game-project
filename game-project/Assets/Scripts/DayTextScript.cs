using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DayTextScript : MonoBehaviour {
    public TextMeshProUGUI dayText;
    // Start is called before the first frame update
    private void Start() {
        dayText.text = "Day " + MainManager.instance.getDay();
    }

    private void Update() {
        dayText.text = "Day " + MainManager.instance.getDay();
    }
}
