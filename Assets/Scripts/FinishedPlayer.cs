using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedPlayer : MonoBehaviour
{
    public float speed = 3;



    void Start()
    {


    }


    void Update()
    {

        Vector3 dir = Vector3.back*80 + Vector3.right;
        dir.Normalize();
        transform.position += dir * speed * Time.deltaTime;

    }
}
