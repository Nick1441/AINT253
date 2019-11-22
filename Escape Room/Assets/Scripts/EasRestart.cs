using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasRestart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Invalid;
    public GameObject InvalidLevel;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

    public void InvalidInput()
    {
        Invalid.SetActive(true);
        Invoke("Reset", 1f);
    }

    public void Reset()
    {
        Invalid.SetActive(false);
    }

    public void InvalidLevels()
    {
        InvalidLevel.SetActive(true);
        Invoke("Reset2", 1f);
    }

    public void Reset2()
    {
        InvalidLevel.SetActive(false);
    }
}
