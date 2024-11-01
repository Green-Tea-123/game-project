using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
   public static Vector2 Movement;

    private PlayerInput _playerinput;
    private InputAction _moveaction;

    void Start()
    {
      _playerinput = GetComponent<PlayerInput>(); 
      _moveaction = _playerinput.actions["Move"];
    }

    void Update()
    {
       Movement =  _moveaction.ReadValue<Vector2>();
    }

}