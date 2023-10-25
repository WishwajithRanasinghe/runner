using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private float _spawnTime = 2f;
    [SerializeField] GameObject[] _obstacal;
    private float _spawnTimeStart;

    private void Start()
    {
        _spawnTimeStart = _spawnTime;
    }//Start


    private void Update()
    {
        _spawnTime -= Time.deltaTime;
        if(_spawnTime <= 0)
        {
            int randomNo = Random.Range(0,_obstacal.Length);
            _spawnTime = _spawnTimeStart;
            if(randomNo == 2)
            {
               Instantiate(_obstacal[randomNo],new Vector3(transform.position.x,transform.position.y + 2f,transform.position.z),Quaternion.identity); 
            }
            else
            {
                Instantiate(_obstacal[randomNo],transform.position,Quaternion.identity);
            }
            
        }
        
    }//Update
    
}//Class
