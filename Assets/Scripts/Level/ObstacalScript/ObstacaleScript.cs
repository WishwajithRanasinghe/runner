using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacaleScript : MonoBehaviour
{
    [SerializeField] private float _destroyTime = 3f;
    [SerializeField] private float _moveSpeed = 4f;
    
    private void Start()
    {
        Destroy(this.gameObject,_destroyTime);
        
    }//Start

    
    private void Update()
    {
        transform.Translate(-_moveSpeed,0,0);
    }//Update
}//Class
