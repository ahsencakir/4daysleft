using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isGamePaused = false;
    public GameObject pauseMenu_obj;
    public bool isGameOver = false;
    public GameObject badguy;
    private void Update()
    {
            if (Input.GetKeyDown(KeyCode.Escape) && !isGameOver)
            {
                if (!isGamePaused)
                {
                    Pause();
                }
                else
                {
                    Resume();
                }
            }
        }
    
    private void Pause()
    {
        Time.timeScale = 0;
        pauseMenu_obj.SetActive(true);
        isGamePaused = true;
    }

    private void Resume()
    {
        Time.timeScale = 1;
        pauseMenu_obj.SetActive(false);
        isGamePaused = false;
    }
    public void resumebutton()
    {
        Resume();
    }
}
