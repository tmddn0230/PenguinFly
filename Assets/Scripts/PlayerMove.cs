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
    public GameObject audio;
    GameObject BG;
    AudioSource bg;
    public GameObject enemyaudio;
    public GameObject fishaudio;


    // Start is called before the first frame update
    void Start()
    {
        gorbg = GameObject.Find("GameOverBG");
        BG = GameObject.Find("BG");
        bg = BG.GetComponent<AudioSource>();
        gorbg.SetActive(false);
        cc = GetComponent<CharacterController>();
        audio.SetActive(false);
        enemyaudio.SetActive(false);
        fishaudio.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {

        h = Input.GetAxis("Horizontal");
        dirh = Vector3.right * h;
        dirh.Normalize();
        //transform.position += dirh * speed * Time.deltaTime;

       
        if (Input.GetButtonDown("Jump"))
        {
            if(cc.isGrounded == true )yVelocity = jumppower;
            audio.SetActive(true);
            AudioSource ad = audio.GetComponent<AudioSource>();
            ad.Play();
            

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
            enemyaudio.SetActive(true);
            gorbg.SetActive(true); //활성화   
            bg.Stop();

        }
        else if(collision.gameObject.name.Contains("Item"))
        {
            fishaudio.SetActive(true);
        }
        else
        {

        }
        
       
       
    }
}
