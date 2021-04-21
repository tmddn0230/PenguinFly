using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMove : MonoBehaviour
{
    //현재 위치
    Vector3 Pos;
    //좌우로 이동 가능한 (X)최대값
    public float delta = 2f;
    //이동속도
    public float speed = 3f;
    
    void Start()
    {
        Pos = transform.position;
    }

    
    void Update()
    {
        Vector3 v = Pos;
        v.x += delta * Mathf.Sin(Time.time * speed);

        transform.position = v;
    }
}
