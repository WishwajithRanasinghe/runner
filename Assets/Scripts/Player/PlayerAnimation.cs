using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerMoveMovement _moveScript;
    private Animator _animator;

    private  void Start()
    {
        _moveScript = GetComponent<PlayerMoveMovement>();
        _animator = GetComponentInChildren<Animator>();
        
    }//Start


    private void Update()
    {
        if(_moveScript._isGrounded == false && Input.GetKey(KeyCode.W))
        {
            PlayerSuperJump(true);
        }
        else if(_moveScript._isGrounded == false && !Input.GetKey(KeyCode.W))
        {
            PlayerJump(true);
        }
        else
        {
            PlayerSuperJump(false);
            PlayerJump(false);
        }
        if(Input.GetKey(KeyCode.S))
        {
            PlayerCover(true);
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            PlayerCover(false);
        }
        
        
    }//Update
    private void PlayerJump(bool isJump)
    {
        if(isJump == true)
        {
            _animator.SetBool("IsJump",true);
        }
        else
        {
            _animator.SetBool("IsJump",false);
        }
        
    }//PlayerJump
    private void PlayerSuperJump(bool isSJump)
    {
        if(isSJump == true)
        {
            _animator.SetBool("IsSuperJ",true);
        }
        else
        {
            _animator.SetBool("IsSuperJ",false);
        }
        
    }//PlayerSuperJump
    private void PlayerCover(bool cover)
    {
        if(cover == true)
        {
            _animator.SetBool("IsCover",true);
        }
        else
        {
            _animator.SetBool("IsCover",false);
        }

    }//PlayerCover
}//Class
