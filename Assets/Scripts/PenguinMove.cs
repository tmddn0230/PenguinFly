using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMove : MonoBehaviour
{
    //���� ��ġ
    Vector3 Pos;
    //�¿�� �̵� ������ (X)�ִ밪
    public float delta = 2f;
    //�̵��ӵ�
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
