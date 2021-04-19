using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3;
    GameObject gorbg;
    public float gravity = -9.8f;
    public float yVelocity;
    public int jumppower = 15;
    Vector3 dirh;
    float h;
    CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        gorbg = GameObject.Find("GameOverBG");
        gorbg.SetActive(false);
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        h = Input.GetAxis("Horizontal");
        dirh = Vector3.right * h;
        //transform.position += dirh * speed * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            yVelocity = jumppower;

            //transform.position += dirh * speed * Time.deltaTime;


        }
        yVelocity += gravity * Time.deltaTime;
        dirh.y = yVelocity;



        cc.Move(dirh * speed * Time.deltaTime);
        //transform.position += dirh * speed * Time.deltaTime;

    }
        private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.layer == 7)
        {

        }
        else
        {
            gorbg.SetActive(true); //활성화   

        }*/
        if (collision.gameObject.name.Contains("Enermy"))
        {
            gorbg.SetActive(true); //활성화   
        }
        else
        {
           

        }
        
    }
}
