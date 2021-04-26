using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itween : MonoBehaviour
{
    public GameObject GameText;
    public GameObject OverText;
    GameObject gorbg;

    RectTransform rt1;
    RectTransform rt2;
   

    // Start is called before the first frame update
    void Start()
    {
        rt1 = GameText.GetComponent<RectTransform>();
        rt2 = OverText.GetComponent<RectTransform>();

        iTween.ValueTo(gameObject, iTween.Hash("time", 1, "from", rt1.anchoredPosition.y, "to", -500,
        "easetype", iTween.EaseType.easeOutBounce,
            "onupdate", "OnUpdateAniUI", "onupdatetarget", gameObject));

        iTween.ValueTo(gameObject, iTween.Hash("time", 1, "from", rt2.anchoredPosition.y, "to", -500,
        "easetype", iTween.EaseType.easeOutBounce,
            "delay", 0.5,
            "onupdate", "OnUpdateAniUI2", "onupdatetarget", gameObject));
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    void OnUpdateAniUI(float value)
    {
        Vector2 pos = rt1.anchoredPosition;
        pos.y = value;
        rt1.anchoredPosition = pos;


    }

    void OnUpdateAniUI2(float value)
    {
     Vector2 pos2 = rt2.anchoredPosition;
    pos2.y = value;
        rt2.anchoredPosition = pos2;
    }
}
