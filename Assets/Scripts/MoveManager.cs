using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveManager : MonoBehaviour
{
    public GameObject jpg1;
    public GameObject jpg2;
    public GameObject nextB;
    public GameObject goB;
    GameObject jpg;

    
    // Start is called before the first frame update
    void Start()
    {
        jpg = jpg1;
        AlianMove();

        nextB.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnclickNext()
    {
        jpg1.SetActive(false);
        jpg = jpg2;
        AlianMove();
        nextB.SetActive(false);
        goB.SetActive(true);
    }

    public void OnclickGo()
    {
        SceneManager.LoadScene("YSW");
    }


    void AlianMove()
    {
        iTween.MoveBy(jpg, iTween.Hash("x", -1815, "time", 1.5, "easetype", iTween.EaseType.easeOutBounce,
            "oncomplete", "AlianMoveBack", "oncompletetarget", gameObject));
    }
}
