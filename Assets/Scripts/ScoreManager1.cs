using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager1 : MonoBehaviour
{
    int currentScore;
    public Text currentScoreUI;
    public Text clearScoreUI;
    public GameObject alian;

    // Start is called before the first frame update
    void Start()
    {
        //SetHighScore(PlayerPrefs.GetInt("CS"));
       clearScoreUI.text = "Clear Score: " + 2000;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentScore >= 500)
        {
            alian.SetActive(true);
        }
        if(currentScore >= 2000)
        {
            SceneManager.LoadScene("Clear");
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
