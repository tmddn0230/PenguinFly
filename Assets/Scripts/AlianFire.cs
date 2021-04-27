using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlianFire : MonoBehaviour
{
    public GameObject bulletFactory;
    GameObject bf;
    float currentTime;
    int randnum;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       if( target.activeSelf != false )
        {

        currentTime += Time.deltaTime;
        randnum = Random.Range(1, 3);

        if(currentTime>randnum)
        {
        bf = Instantiate(bulletFactory);
        bf.transform.position = transform.position;
            currentTime = 0;
        }
        }
        
    }
}
