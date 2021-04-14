using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    
    public float speed = 5;
    Vector3 dir;
    GameObject gorbg;
    // Start is called before the first frame update
    void Start()
    {
        gorbg = GameObject.Find("GameOverBG");
        gorbg.SetActive(false);
       

    }

    // Update is called once per frame
    void Update()
    {
         
        dir = Vector3.back;
        dir.Normalize();
        transform.position = transform.position + dir * speed * Time.deltaTime;
        Destroy(gameObject, 3);


    }

    private void OnCollisionEnter(Collision collision)
    {
       /* if(collision.gameObject.name.Contains("Æë±Ï"))
        {

        }
        else
        {
            gorbg.SetActive(true); //È°¼ºÈ­   

        }*/
    }
}
