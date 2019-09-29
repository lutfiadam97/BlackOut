using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;


    // Update is called once per frame

    public void Resume()
    {
    	pauseMenuUI.SetActive(false);
    	Time.timeScale = 1f;
    	GameIsPaused = false;
    }

    public void Pause()
    {
    	pauseMenuUI.SetActive(true);
    	Time.timeScale = 0f;
    	GameIsPaused = true;
    }

    public void LoadMenu()
    {
    	SceneManager.LoadScene("Opening");

    }

    public void Restart()
    {
    	SceneManager.LoadScene("Stage1");
    }

    public void Item()
    {
    	SceneManager.LoadScene("ItemMenu");
    }
}
