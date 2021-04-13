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
    public GameObject itemManager;  //에너미 생산 위치 설정
    float createTime = 0; //생성시간 
    float currentTime; // 흐르는 시간 (현재시간)
    // Start is called before the first frame update
    void Start()
    {
        createTime = Random.Range(1f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime; //currentTime을 흐르게 한다(증가시킨다), deltaTime 을 넣어 진짜 시계처럼 흐르게 
        if (createTime < currentTime)               // 일정시간 < 흘러간 시간
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
