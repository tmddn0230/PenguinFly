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
    public GameObject enermyManager;  //에너미 생산 위치 설정
    int createTime=0 ; //생성시간 
    float currentTime; // 흐르는 시간 (현재시간)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime; //currentTime을 흐르게 한다(증가시킨다), deltaTime 을 넣어 진짜 시계처럼 흐르게 
        if (createTime < currentTime)               // 일정시간 < 흘러간 시간
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
