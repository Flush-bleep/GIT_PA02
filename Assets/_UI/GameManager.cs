using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState {  GameOver, GameStart, GameIdle};
    public static GameState CurrentState = GameState.GameIdle;

    public static int Lives = 3;
    public static int Score = 0;

    private HUD theHUD;

    void Start()
    {
        Lives = 3;
        Score = 0;
        Time.timeScale = 0;
        CurrentState = GameState.GameIdle;

        theHUD = FindObjectOfType<HUD>();
    }
    
    void Update()
    {
        if(CurrentState == GameState.GameIdle && Input.GetKeyDown(KeyCode.Return))
        {            
            CurrentState = GameState.GameStart;
            Time.timeScale = 1;
            HUD.HUDManager.DismissMessage();
        }

        else if(CurrentState == GameState.GameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }

        if (Lives == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }


    public void TakeDamage(int LiveToReduce)
    {
        Lives -= LiveToReduce;
        theHUD.UpdateLives();
    }

    public void AddScore(int ScoreToGive)
    {
        Score += ScoreToGive;
        theHUD.UpdateScore();
    }

}
