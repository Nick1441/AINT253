using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject Camera;
    public GameObject EndScene;

    private void OnTriggerEnter(Collider other)
    {
        Cursor.visible = true;
        SceneManager.LoadScene("EndScreen");
        Cursor.visible = true;
        //END SCREEN. 
        //ADD TIMER TO GAME TO MEASURE HOW LONG IT TOOK


        //Camera.GetComponent<Movement>().enabled = false;
        //Camera.GetComponent<CameraMovement>().enabled = false;
        //Camera.GetComponent<CharacterController>().enabled = false;
        //Camera.GetComponent<Animator>().enabled = true;
        
        //Debug.Log("HIT");
    }
}
