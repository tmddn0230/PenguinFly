using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyManager : MonoBehaviour
{
    public GameObject enermyFactory;  //���ʹ� ���� ����
    public GameObject enermyManager;  //���ʹ� ���� ��ġ ����
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
            GameObject item = Instantiate(enermyFactory);           //�������� ���� enermy ����, Instantiate �� ����� ���� 
            item.transform.position = enermyManager.transform.position;
            currentTime = 0; //currentTime �ʱ�ȭ 1��->0 
            createTime = Random.Range(1f, 7f);      //createTime�� �����ϰ� �����Ͽ� �������� ���� enermy ���� ����
        }

    }
}
