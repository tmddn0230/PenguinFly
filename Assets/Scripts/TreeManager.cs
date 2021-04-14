using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    
    public GameObject treeFactory;
    public GameObject treeFactory2;
    public GameObject treeFactory3;
    public GameObject treeFactory4;
    public GameObject treeFactory5;
    public GameObject treeFactory6;
    public GameObject treeFactory7;
    public GameObject treeFactory8;
    public GameObject treeManager;
    float createTime = 0;
    float currTime;

    void Start()
    {
        createTime = Random.Range(1f, 10f);

    }

    
    void Update()
    {
        currTime += Time.deltaTime;
        if (createTime < currTime)
        {

            if (createTime <= 2)
            {
                GameObject tree = Instantiate(treeFactory);
                tree.transform.position = transform.position;
            }
        
            else if (createTime <= 3)
            {
                GameObject tree2 = Instantiate(treeFactory2);
                tree2.transform.position = transform.position;
            }
            else if (createTime <= 4)
            {
                GameObject tree3 = Instantiate(treeFactory3);
                tree3.transform.position = transform.position;
            }
            else if (createTime <= 5)
            {
                GameObject tree4 = Instantiate(treeFactory4);
                tree4.transform.position = transform.position;
            }
            else if (createTime <= 6)
            {
                GameObject tree5 = Instantiate(treeFactory5);
                tree5.transform.position = transform.position;
            }
            else if (createTime <= 7)
            {
                GameObject tree6 = Instantiate(treeFactory6);
                tree6.transform.position = transform.position;
            }
            else if (createTime <= 8)
            {
                GameObject tree7 = Instantiate(treeFactory7);
                tree7.transform.position = transform.position;
            }
            else 
            {
                GameObject tree8 = Instantiate(treeFactory8);
                tree8.transform.position = transform.position;
            }

            currTime = 0;

            createTime = Random.Range(1f, 10f);
        }
    }
}
