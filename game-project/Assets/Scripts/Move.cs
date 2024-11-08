using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{

    public float _movespeed = 5f;
    private Vector2 _movement;

    public Rigidbody2D _rb;
    public Animator _animator;

     private const string _horizontal = "Horizontal";
     private const string _vertical = "Vertical";
     private const string _lastHorizontal = "Last Horizontal";
     private const string _lastVertical = "Last Vertical";

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

        if(_movement != Vector2.zero)
        {
            _animator.SetFloat(_lastHorizontal, _movement.x);
            _animator.SetFloat(_lastVertical, _movement.y);
        }
    }


}
