using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{

    public float speed;
    Vector3 dir;
    public GameObject[] models;

    // Start is called before the first frame update
    void Start()
    {
        int randModel = Random.Range(0, models.Length);         //int는 끝을 포함하지 않으므로 2가 아닌 3 
        models[randModel].SetActive(true);
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
