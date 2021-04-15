using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour
{
    public Text textTitle;
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
        textTitle.color = new Color(1, 1, 1, a);

        if (a >= 1 || a <= 0) dir *= -1;
    }
    public void OnClickRetry()
    {
        SceneManager.LoadScene("YSW");
    }
}
