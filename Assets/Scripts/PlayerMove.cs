using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float speed = 3;
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
        float h = Input.GetAxis("Horizontal");
        Vector3 dirh = Vector3.right * h;

        dirh.Normalize();
        transform.position += dirh * speed * Time.deltaTime;

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
        if (collision.gameObject.name.Contains("Item"))
        {

        }
        else
        {
            gorbg.SetActive(true); //활성화   

        }
        
    }
}
