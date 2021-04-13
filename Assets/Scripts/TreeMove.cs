using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{
    public float speed = 3f;
    
    Vector3 dir;


    void Start()
    {
        
    }

    // 
    void Update()
    {
        //int rand = Random.Range(1, 11);

        dir = Vector3.back;

        transform.position += dir * speed * Time.deltaTime;

        dir.Normalize();

    }
}
