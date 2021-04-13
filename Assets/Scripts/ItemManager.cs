using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject itemFactory;
    public GameObject itemFactory2;
    public GameObject itemFactory3;
    public GameObject itemFactory4;
    public GameObject itemFactory5;
    public GameObject itemManager;  //���ʹ� ���� ��ġ ����
    float createTime = 0; //�����ð� 
    float currentTime; // �帣�� �ð� (����ð�)
    // Start is called before the first frame update
    void Start()
    {
        createTime = Random.Range(1f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime; //currentTime�� �帣�� �Ѵ�(������Ų��), deltaTime �� �־� ��¥ �ð�ó�� �帣�� 
        if (createTime < currentTime)               // �����ð� < �귯�� �ð�
        {


            if (createTime <= 6)
            {
                GameObject item = Instantiate(itemFactory);
                item.transform.position = itemManager.transform.position;
            }
            else if (createTime <= 12)
            {
                GameObject item2 = Instantiate(itemFactory2);
                item2.transform.position = itemManager.transform.position;
            }
            else if (createTime <= 18)
            {
                GameObject item3 = Instantiate(itemFactory3);
                item3.transform.position = itemManager.transform.position;
            }
            else if (createTime <= 24)
            {
                GameObject item4 = Instantiate(itemFactory4);
                item4.transform.position = itemManager.transform.position;
            }
            else
            {

                GameObject item5 = Instantiate(itemFactory5);
                item5.transform.position = itemManager.transform.position;
            }
            currentTime = 0;
            createTime = Random.Range(1f, 30f);


        }


    }
}
