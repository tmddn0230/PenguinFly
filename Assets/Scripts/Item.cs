using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            gameObject.SetActive(false);
            GameObject smobj = GameObject.Find("ScoreManager");
            ScoreManager sm = smobj.GetComponent<ScoreManager>();
            sm.AddScore(100);
            print("��� ����!!!");

        }
    }
    private void OnCollisionEnter(Collision collision)     // �浹�� �� �����  Collision�� ��� Collision ���� 
    {
        if (collision.gameObject.layer == 6)
        {
            gameObject.SetActive(false);
            GameObject smobj = GameObject.Find("ScoreManager");
            ScoreManager sm = smobj.GetComponent<ScoreManager>();
            sm.AddScore(100);
            print("��� ����!!!");

        }




        // Destroy(gameObject);

    }
}
