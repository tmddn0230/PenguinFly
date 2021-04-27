using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyManager : MonoBehaviour
{
    public GameObject enermyFactory;
    public GameObject enermyFactory2;
    public GameObject enermyFactory3;
    public GameObject enermyFactory4;
    public GameObject enermyFactory5;
    public GameObject enermyManager;  //���ʹ� ���� ��ġ ����
    float createTime=0 ; //�����ð� 
    float currentTime; // �帣�� �ð� (����ð�)
    // Start is called before the first frame update
    void Start()
    {
        createTime = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime; //currentTime�� �帣�� �Ѵ�(������Ų��), deltaTime �� �־� ��¥ �ð�ó�� �帣�� 
        if (createTime < currentTime)               // �����ð� < �귯�� �ð�
        {
            
            
            if (createTime <= 1 )
            {
                GameObject item = Instantiate(enermyFactory);
                item.transform.position = enermyManager.transform.position;
            }
            else if(createTime <= 1.5 )
            {
                GameObject item = Instantiate(enermyFactory2);
                item.transform.position = enermyManager.transform.position;
            }
            else if(createTime <= 2)
            {
                GameObject item = Instantiate(enermyFactory3);
                item.transform.position = enermyManager.transform.position;
            }
            else if(createTime <= 2.5)
            {
                GameObject item = Instantiate(enermyFactory4);
                item.transform.position = enermyManager.transform.position;
            }
            else
            {

                GameObject item = Instantiate(enermyFactory5); 
                item.transform.position = enermyManager.transform.position;
            }
            currentTime = 0;
            createTime = Random.Range(1f, 3f);


        }
       

    }
}
