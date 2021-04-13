using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir = Vector3.down;
        dir.Normalize();
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)     // 충돌할 때 실행됨  Collision을 담는 Collision 변수 
    {
        
        Destroy(gameObject);
        
    }
}
