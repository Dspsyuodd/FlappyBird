using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause_script : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject PauseMenu;
    public GameObject LoseMenu;
    public GameObject Score_counter;
    public GameObject Pause_Button;

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

    }
    void Death()
    {
        LoseMenu.SetActive(true);
        Score_counter.SetActive(false);
        Pause_Button.SetActive(false);
    }
    //public void Menu()
    //{
    //    Time.timeScale = 1f;
    //    GameIsPause = false;
    //    SceneManager.LoadScene(0);
    //}

}
