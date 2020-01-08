using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Logo;
    public GameObject Buttons;
    public GameObject Camera;

    public static bool IsGamePaused = false;
    public GameObject PauseMenuUI;
    //Getting Logo & Buttons.
    public void MainMenuAnimation()
    {
        Logo.GetComponent<Animator>().SetTrigger("Go");
        Buttons.GetComponent<Animator>().SetTrigger("Go");

    }
    public void Endgame()
    {
        Time.timeScale = 1f;
        Cursor.visible = true;
        SceneManager.LoadScene("EndScreen");
        Cursor.visible = true;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainRoom");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //PAUSE MENU
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsGamePaused = false;
        Camera.GetComponent<Movement>().enabled = true;
        Camera.GetComponent<CameraMovement>().enabled = true;
        Cursor.visible = false;
    }

    //Used for pausing the game and turning on the Pause Screen.
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsGamePaused = true;
        Camera.GetComponent<Movement>().enabled = false;
        Camera.GetComponent<CameraMovement>().enabled = false;
        Cursor.visible = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


}
