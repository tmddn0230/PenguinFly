using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlianBullet : MonoBehaviour
{
    GameObject target;
    int speed;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    { 
        

        target = GameObject.Find("Player");
        
            speed = Random.Range(25, 30);

        dir = target.transform.position - transform.position;
        dir.Normalize();

        Destroy(gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
}
