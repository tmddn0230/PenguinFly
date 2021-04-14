using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed = 1f;
    Vector3 cloud;

    void Start()
    {
        
    }

    
    void Update()
    {
        cloud = Vector3.right;

        transform.position += cloud * speed * Time.deltaTime;

        cloud.Normalize();
    }
}
