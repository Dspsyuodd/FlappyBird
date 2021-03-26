using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause_script : MonoBehaviour
{
    public static bool GameIsStarted = false;
    public static bool GameIsPause = false;
    public GameObject PauseMenu;
    public GameObject LoseMenu;
    public GameObject Score_counter;
    public GameObject Pause_Button;
    public Text Dead_score;
    public Text Best_score;
    public GameObject Best_score_plane;
    public GameObject Player;
    //public Animator anim;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
                Resume();
            else
                Pause();
        }
        if (PlayerController.isDead)
        {
            Death();
        }
        
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void Restart_()
    {
        Time.timeScale = 1f;
        GameIsPause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerController.isDead = false;
        PlayerController.score_ = 0;
        GameIsStarted = false;

    }
    void Death()
    {
        LoseMenu.SetActive(true);
        Dead_score.text = PlayerController.score_.ToString();
        if (PlayerController.score_ > PlayerPrefs.GetInt("Best_score"))
        {
            Best_score_changer();
        }
        Best_score.text = PlayerPrefs.GetInt("Best_score").ToString();
        Score_counter.SetActive(false);
        Pause_Button.SetActive(false);
    }
    void Best_score_changer()
    {
        PlayerPrefs.SetInt("Best_score", PlayerController.score_);
        Best_score_plane.SetActive(true);
    }
    
    //public void Menu()
    //{
    //    Time.timeScale = 1f;
    //    GameIsPause = false;
    //    SceneManager.LoadScene(0);
    //}

}
