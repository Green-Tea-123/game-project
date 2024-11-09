using UnityEngine;
using System.Collections;

public class CutsceneManager : MonoBehaviour
{
    public GameObject mum;
    public Transform downTarget; // Position for Mum to move down to
    public Transform leftTarget; // Position for Mum to move left to

    private bool isCutsceneActive = false;

    void Update()
    {
        // Press the "T" key to start the cutscene
        if (Input.GetKeyDown(KeyCode.T) && !isCutsceneActive)
        {
            StartCutscene();
        }
    }

    public void StartCutscene()
    {
        isCutsceneActive = true;
        StartCoroutine(MoveMumInSequence()); // Start the cutscene sequence
    }

    private IEnumerator MoveMumInSequence()
    {
        // Move Mum downwards
        yield return StartCoroutine(MoveToPosition(mum, downTarget.position, 2f, 0)); // Direction 0 for down

        // Move Mum to the left
        yield return StartCoroutine(MoveToPosition(mum, leftTarget.position, 2f, 1)); // Direction 1 for left

        // Set Mum to idle after reaching the target
        Animator animator = mum.GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetBool("isWalking", false); // Stop walking animation
        }

        // Mark cutscene as finished
        isCutsceneActive = false;
    }

    private IEnumerator MoveToPosition(GameObject character, Vector3 target, float duration, int direction)
    {
        Animator animator = character.GetComponent<Animator>();

        if (animator != null)
        {
            animator.SetBool("isWalking", true); // Start walking animation
            animator.SetInteger("direction", direction); // Set direction (0 for down, 1 for left)
        }

        Vector3 startPosition = character.transform.position;
        float elapsed = 0;

        while (elapsed < duration)
        {
            character.transform.position = Vector3.Lerp(startPosition, target, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        character.transform.position = target;

        if (animator != null)
        {
            animator.SetBool("isWalking", false); // Stop walking after reaching target
        }
    }
}
