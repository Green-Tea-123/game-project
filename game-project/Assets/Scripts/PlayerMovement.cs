using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float _movespeed = 5f;
    private Vector2 _movement;

    public Rigidbody2D _rb;
    public Animator _animator;

     private const string _horizontal = "Horizontal";
     private const string _vertical = "Vertical";

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _movement.Set(InputManager.Movement.x, InputManager.Movement.y);

        _rb.velocity = _movement * _movespeed;

        _animator.SetFloat(_horizontal,_movement.x);
        _animator.SetFloat(_vertical, _movement.y);
    }


}
