using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{

    float speed;
    Vector3 dir;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(30f, 50f);
        dir = Vector3.back;
        dir.Normalize();
        transform.position = transform.position + dir * speed * Time.deltaTime;
        Destroy(gameObject, 6);


    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
       
    }

}
