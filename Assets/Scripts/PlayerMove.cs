using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float speed = 3;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 dirh = Vector3.right * h;

        dirh.Normalize();
        transform.position += dirh * speed * Time.deltaTime;

    }

    
}
