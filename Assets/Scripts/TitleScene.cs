using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour
{
    public GameObject textMove;
    public GameObject textMove2;
    public GameObject textMove3;
    public GameObject textMove4;
    public static TitleScene instance;

    void Awake()
    {
        if (TitleScene.instance == null)
            TitleScene.instance = this;
    }

    void Start()
    {
        textMove.SetActive(false);
        
        textMove2.SetActive(false);
        
        textMove3.SetActive(false);
        
        textMove4.SetActive(false);
       
        StartCoroutine(ShowPgnd());
    }

    public float delayTime1 = 0.2f;
    public float delayTime2 = 0.25f;
    IEnumerator ShowPgnd()
    {
        yield return new WaitForSeconds(delayTime1);
        while (true)
        {

            textMove.SetActive(true);
            yield return new WaitForSeconds(delayTime1);
            textMove.SetActive(false);
            yield return new WaitForSeconds(delayTime1);
            

            textMove2.SetActive(true);
            yield return new WaitForSeconds(delayTime2);
            textMove2.SetActive(false);
            yield return new WaitForSeconds(delayTime2);
           

            textMove3.SetActive(true);
            yield return new WaitForSeconds(delayTime1);
            textMove3.SetActive(false);
            yield return new WaitForSeconds(delayTime1);
           

            textMove4.SetActive(true);
            yield return new WaitForSeconds(delayTime2);
            textMove4.SetActive(false);
            yield return new WaitForSeconds(delayTime2);
          
        }
    }
    public void OnClickRetry()
    {
        SceneManager.LoadScene("YSW");
    }

}
