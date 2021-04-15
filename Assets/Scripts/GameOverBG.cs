using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverBG : MonoBehaviour
{
    public void OnClickRetry()
    {
        SceneManager.LoadScene("YSW");
    }
}
