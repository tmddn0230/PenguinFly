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
    public GameObject it;
    int count = 0;
    
   

   
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
        it.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {



        h = Input.GetAxis("Horizontal");
        dirh = Vector3.right * h;
        dirh.Normalize();

        if (Input.GetButtonDown("Jump"))
        {
            if(cc.isGrounded == true )yVelocity = jumppower;

            audio.SetActive(true);
            AudioSource ad = audio.GetComponent<AudioSource>();
            ad.Play();
     

        }
        yVelocity += gravity * Time.deltaTime;
        dirh.y = yVelocity;

        cc.Move(dirh * speed * Time.deltaTime);
      

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name.Contains("Enermy"))
        {
            enemyaudio.SetActive(true);
            gorbg.SetActive(true); //Ȱ��ȭ
            it.SetActive(true);
            bg.Stop();

        }
        else if (collision.gameObject.name.Contains("Item"))
        {
            fishaudio.SetActive(true);
            AudioSource fa;
            fa = fishaudio.GetComponent<AudioSource>();
            fa.Play();

        }
        else
        {

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Bullet"))
        {
            print("�¿� ����!!");
            count++;
        }
    }


}
