using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    int currentScore;
    public Text currentScoreUI;
    public Text clearScoreUI;
    public GameObject alianGo;

    // Start is called before the first frame update
    void Start()
    {
        //SetHighScore(PlayerPrefs.GetInt("CS"));
       clearScoreUI.text = "Clear Score: " + 1000;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(currentScore >= 1000)
        {
            SceneManager.LoadScene("Loading");
        }
    if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            currentScore = currentScore + 900;
            currentScoreUI.text = "Score: " + currentScore;
        }
    }


public void AddScore(int AddValue)
    {
        currentScore += AddValue;
        currentScoreUI.text = "Score: " + currentScore;

        /*if (currentScore > clearScore)          
        {
            clearScore = currentScore;
            clearScoreUI.text = "Clear Score: " + clearScore;
            PlayerPrefs.SetInt("CS", clearScore);    
        }*/

    }

   
}
