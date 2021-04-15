using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{
    public float speed = 10f;
    
    Vector3 tree;


    void Start()
    {
        
    }

     
    void Update()
    {
        //int rand = Random.Range(1, 11);

        tree = Vector3.back;

        transform.position += tree * speed * Time.deltaTime;

        tree.Normalize();

    }
}
