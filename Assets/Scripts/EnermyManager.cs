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
    int createTime=0 ; //�����ð� 
    float currentTime; // �帣�� �ð� (����ð�)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime; //currentTime�� �帣�� �Ѵ�(������Ų��), deltaTime �� �־� ��¥ �ð�ó�� �帣�� 
        if (createTime < currentTime)               // �����ð� < �귯�� �ð�
        {
            
            
            if (createTime == 1 )
            {
                GameObject item = Instantiate(enermyFactory);
                item.transform.position = enermyManager.transform.position;
            }
            else if(createTime == 2)
            {
                GameObject item2 = Instantiate(enermyFactory2);
                item2.transform.position = enermyManager.transform.position;
            }
            else if(createTime == 3)
            {
                GameObject item3 = Instantiate(enermyFactory3);
                item3.transform.position = enermyManager.transform.position;
            }
            else if(createTime == 4)
            {
                GameObject item4 = Instantiate(enermyFactory4);
                item4.transform.position = enermyManager.transform.position;
            }
            else
            {

                GameObject item5 = Instantiate(enermyFactory5); 
                item5.transform.position = enermyManager.transform.position;
            }
            currentTime = 0;
            createTime = Random.Range(1, 5);


        }
       

    }
}
