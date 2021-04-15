using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Clear : MonoBehaviour
{
    public Text ClearTitle;
    float a;
    float dir = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        a += 0.01f * dir;
        ClearTitle.color = new Color(0.95f, 0.92f , 0.4f, a);

        if (a >= 1 || a <= 0) dir *= -1;
    }
   
}
