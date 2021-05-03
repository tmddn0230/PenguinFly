using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Start,
        Snow,
        Loading,
        Desert,
        GameOver,
        Clear
    }
    public GameState state;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
