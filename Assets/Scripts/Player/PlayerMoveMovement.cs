using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMovement : MonoBehaviour
{
    private Rigidbody2D _rBody;
    private Vector2 _direction;
    public bool _isGrounded;
    [SerializeField] private float _jumpForce = 10f;
    private void Start()
    {
        _rBody = GetComponent<Rigidbody2D>();
        
    }//Start

    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
       {
            PlayerJump();
            
            _isGrounded = false;
       } 
       if(_isGrounded == true)
        {
            _direction.y = Mathf.Max(_direction.y,-1);
        }
        else
        {
            _direction += Physics2D.gravity * Time.deltaTime * 2f;
        }
        
    }//Update
    private void FixedUpdate()
    {

        PlayerMove();
   
    }//FixedUpdate
    private void PlayerJump()
    {
        _direction = Vector2.up * _jumpForce * 10;
        

    }//PlayerJump
    private void PlayerMove()
    {
        _rBody.MovePosition(_rBody.position + _direction * 2f* Time.fixedDeltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.transform.tag)
        {
            case "Ground":
            if(collision.gameObject.transform.position.y < transform.position.y)
            {
                _isGrounded = true;
            }
            break;
            
        }
    }//OnCollisionEnter2D
}//Class
