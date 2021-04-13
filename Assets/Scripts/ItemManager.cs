using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject itemFactory;  //���ʹ� ���� ����
    public GameObject itemManager;  //���ʹ� ���� ��ġ ����
    float createTime = 1; //�����ð� 
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
            GameObject item = Instantiate(itemFactory);           //�������� ���� enermy ����, Instantiate �� ����� ���� 
            item.transform.position = itemManager.transform.position;
            currentTime = 0; //currentTime �ʱ�ȭ 1��->0 
            createTime = Random.Range(10f, 30f);      //createTime�� �����ϰ� �����Ͽ� �������� ���� enermy ���� ����
        }
    }
}
