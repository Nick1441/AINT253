using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Escaped : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Text;

    private void OnTriggerEnter(Collider other)
    {
        Text.SetActive(true);
        Invoke("EndGame", 3f);
        Camera.GetComponent<Movement>().enabled = false;
        //END SCREEN. 
        //ADD TIMER TO GAME TO MEASURE HOW LONG IT TOOK


        //Camera.GetComponent<Movement>().enabled = false;
        //Camera.GetComponent<CameraMovement>().enabled = false;
        //Camera.GetComponent<CharacterController>().enabled = false;
        //Camera.GetComponent<Animator>().enabled = true;

        //Debug.Log("HIT");
    }

    public void EndGame()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("EndScreen");
    }
}
