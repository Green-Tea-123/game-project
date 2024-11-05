using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
   public static Vector2 Movement;

    private PlayerInput _playerinput;
    private InputAction _moveaction;
    private InputAction _interaction;
    private InputAction _submission;


    private bool interactPressed = false;

    private bool submitPressed = false;

    private static InputManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Input Manager in the scene.");
        }
        instance = this;
    }

    public static InputManager GetInstance() 
    {
        return instance;
    }

    public void InteractButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            interactPressed = true;
        }
        else if (context.canceled)
        {
            interactPressed = false;
        } 
    }

    public void SubmitPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            submitPressed = true;
        }
        else if (context.canceled)
        {
            submitPressed = false;
        } 
    }

    public bool GetInteractPressed() 
    {
        bool result = interactPressed;
        interactPressed = false;
        return result;
    }

    void Start()
    {
      _playerinput = GetComponent<PlayerInput>(); 
      _moveaction = _playerinput.actions["Move"];
      _interaction = _playerinput.actions["interact"];
      _submission  = _playerinput.actions["submit"];
    }

    void Update()
    {
       Movement =  _moveaction.ReadValue<Vector2>();
        interactPressed = _interaction.WasPressedThisFrame();
        submitPressed = _submission.WasPressedThisFrame();
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            
        }
    }

     public bool GetSubmitPressed() 
    {
        bool result = submitPressed;
        submitPressed = false;
        return result;
    }

    public void RegisterSubmitPressed() 
    {
        submitPressed = false;
    }

}