using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    public float speed = 5;



    Vector3 dir;
    // Start is called before the first frame update
    private void Awake()
    {


    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dir = Vector3.down;
        dir.Normalize();
        transform.position = transform.position + dir * speed * Time.deltaTime;
        Destroy(gameObject, 10);
    }



    private void OnCollisionEnter(Collision collision)     // 충돌할 때 실행됨  Collision을 담는 Collision 변수 
    {
        if (collision.gameObject.layer == 6)
        {
            gameObject.SetActive(false);
            GameObject smobj = GameObject.Find("ScoreManager1");
            ScoreManager1 sm = smobj.GetComponent<ScoreManager1>();
            sm.AddScore(100);
            print("물방울 먹음!!!");

        }


    }
}
