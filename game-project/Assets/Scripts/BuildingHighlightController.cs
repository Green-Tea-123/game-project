using UnityEngine;

public class BuildingHighlightController : MonoBehaviour
{
    public GameObject highlightOverlay; // Assign the yellow box prefab instance here in the Inspector

    void Start()
    {
        // Ensure the overlay is hidden initially
        if (highlightOverlay != null)
        {
            highlightOverlay.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Show the yellow box overlay when the player enters the trigger
            highlightOverlay.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the yellow box overlay when the player exits the trigger
            highlightOverlay.SetActive(false);
        }
    }
}
