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
        createTime = Random.Range(1f, 15f);

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
        
            else if (createTime <= 5)
            {
                GameObject tree = Instantiate(treeFactory2);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 7)
            {
                GameObject tree = Instantiate(treeFactory3);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 9)
            {
                GameObject tree = Instantiate(treeFactory4);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 11)
            {
                GameObject tree = Instantiate(treeFactory5);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 13)
            {
                GameObject tree = Instantiate(treeFactory6);
                tree.transform.position = transform.position;
            }
            else if (createTime <= 15)
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
