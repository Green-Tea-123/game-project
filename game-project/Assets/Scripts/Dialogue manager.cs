using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialoguemanager : MonoBehaviour
{
    public static Dialoguemanager instance;

    public Image CharacterIcon;
    public TextMeshProUGUI charactername;
    public TextMeshProUGUI dialoguearea;

    private Queue<DialogueLine> lines;
    public bool isDialogueActive = false;
    public Animator animator;

    private void Start()
    {
        if (instance == null)
            instance = this;
    }

    public void StartDialogue(Dialogue dialogue)
    {
        isDialogueActive = true;
        animator.Play("show");
        lines.Clear();
        foreach (DialogueLine line in dialogue.dialogueLines)
        {
            lines.Enqueue(line);
        }
        DisplayNextDialogueLines();
    }

    public void DisplayNextDialogueLines()
    {
        if (lines.Count == 0)
        {
            EndDialogue();
            return;
        }
        DialogueLine Currentline = lines.Dequeue();
        CharacterIcon.sprite = Currentline.character.icon;
        charactername.text = Currentline.character.name;

        StopAllCoroutines();
        StartCoroutine(TypeSentence(Currentline));
    }

    IEnumerator TypeSentence(DialogueLine dialogueLine)
    {
        dialoguearea.text = "";
        foreach (char letter in dialogueLine.line.ToCharArray())
        {
            dialoguearea.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void EndDialogue()
    {
        isDialogueActive = false;
        animator.Play("hide");
    }
}
