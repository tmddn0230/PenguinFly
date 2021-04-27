using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public GameObject textMove;
    public GameObject textMove2;
    public GameObject textMove3;

    public static Loading instance;

    float createTime;
    float currTime;

    void Start()
    {
        textMove.SetActive(false);

        textMove2.SetActive(false);

        textMove3.SetActive(false);

        StartCoroutine(ShowPgnd());
    }

    private void Update()
    {
        currTime += Time.deltaTime;
        if (currTime > 1)
        {
            SceneManager.LoadScene("SSYY");
        }
    }

    public float delayTime1 = 0.1f;
    public float delayTime2 = 0.1f;

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

           
        }

    }
    
}
    
