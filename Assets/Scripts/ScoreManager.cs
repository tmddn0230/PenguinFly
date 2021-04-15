using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int currentScore;
    public Text currentScoreUI;
    int clearScore = 10000;
    public Text clearScoreUI;

    // Start is called before the first frame update
    void Start()
    {
        //SetHighScore(PlayerPrefs.GetInt("CS"));
       clearScoreUI.text = "Clear Score: " + 10000;
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void SetHighScore(int cs)
    {
        clearScore = cs;
        clearScoreUI.text = "Clear Score: " + clearScore;



    }
}
