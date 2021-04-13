using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject itemFactory;  //에너미 공장 만듦
    public GameObject itemManager;  //에너미 생산 위치 설정
    float createTime = 1; //생성시간 
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
            GameObject item = Instantiate(itemFactory);           //공장으로 부터 enermy 생산, Instantiate 가 만드는 느낌 
            item.transform.position = itemManager.transform.position;
            currentTime = 0; //currentTime 초기화 1초->0 
            createTime = Random.Range(10f, 30f);      //createTime을 랜덤하게 설정하여 지루하지 않은 enermy 생산 가능
        }
    }
}
