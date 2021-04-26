using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alian : MonoBehaviour
{
    public GameObject alianmove;
    RectTransform rt;


    void Start()
    {
        AlianMove();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AlianMove()
    {
        iTween.MoveBy(alianmove, iTween.Hash("x", 5, "time", 1.5, "easetype", iTween.EaseType.easeOutBounce,
            "oncomplete", "AlianMoveBack", "oncompletetarget", gameObject));
    }

    void AlianMoveBack()
    {
        iTween.MoveBy(alianmove, iTween.Hash("x",-10, "time", 2, "easetype", iTween.EaseType.easeOutBounce, "looptype", iTween.LoopType.pingPong,
          "oncomplete", "AlianMoveGo", "oncompletetarget", gameObject));
    }

    void AlianMoveGo()
    {
        iTween.MoveBy(alianmove, iTween.Hash("x", 10, "time", 2, "easetype", iTween.EaseType.easeOutBounce, "looptype", iTween.LoopType.pingPong,
            "oncomplete", "AlianMoveRe", "oncompletetarget", gameObject));
    }

    void AlianMoveRe()
    {
        iTween.MoveBy(alianmove, iTween.Hash("x", -5, "time", 1.5, "easetype", iTween.EaseType.easeOutBounce,
           "oncomplete", "AlianMove", "oncompletetarget", gameObject));
    }
}
