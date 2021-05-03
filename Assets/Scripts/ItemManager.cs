using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject itemFactory;
    public GameObject[] itemPos;
  
    float createTime = 0; //생성시간 
    float currentTime; // 흐르는 시간 (현재시간)
    // Start is called before the first frame update

    static int count;
    void Start()
    {
        createTime = Random.Range(1f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime; //currentTime을 흐르게 한다(증가시킨다), deltaTime 을 넣어 진짜 시계처럼 흐르게 
        if (createTime < currentTime)               // 일정시간 < 흘러간 시간
        {
            count++;
            print("아이템 생성 : " + count);

            if (createTime <= 5)
            {
                GameObject item = Instantiate(itemFactory);
                item.transform.position = itemPos[0].transform.position;
            }
            else if (createTime <= 10)
            {
                GameObject item2 = Instantiate(itemFactory);
                item2.transform.position = itemPos[1].transform.position;
            }
            else if (createTime <= 15)
            {
                GameObject item3 = Instantiate(itemFactory);
                item3.transform.position = itemPos[2].transform.position;
            }
          
            else
            {
                GameObject item4 = Instantiate(itemFactory);
                item4.transform.position = itemPos[3].transform.position;
            }
            currentTime = 0;
            createTime = Random.Range(1f, 20f);


        }


    }
}
