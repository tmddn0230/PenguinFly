using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
        
    }


    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        Material mat = mr.material;

        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
