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

            if (createTime <= 1)
            {
                GameObject tree = Instantiate(treeFactory);
                tree.transform.position = transform.position;
            }
        
            else if (createTime <= 2)
            {
                GameObject tree = Instantiate(treeFactory2);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 4)
            {
                GameObject tree = Instantiate(treeFactory3);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 6)
            {
                GameObject tree = Instantiate(treeFactory4);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 8)
            {
                GameObject tree = Instantiate(treeFactory5);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 9)
            {
                GameObject tree = Instantiate(treeFactory6);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 10)
            {
                GameObject tree = Instantiate(treeFactory7);
                tree.transform.position = transform.position;
            }
            else 
            {
                GameObject tree8 = Instantiate(treeFactory8);
                tree8.transform.position = transform.position;
            }

            currTime = 0;

            createTime = Random.Range(1f, 15f);
        }
    }
}
