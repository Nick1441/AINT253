using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerV2Controller : MonoBehaviour
{
    public int InputLeft = 1;
    public int InputRight = 1;
    public GameObject DisL;
    public GameObject DisR;

    public GameObject L1;
    public GameObject L2;
    public GameObject L3;

    public GameObject R1;
    public GameObject R2;
    public GameObject R3;

    public GameObject SI;

    public Transform Camera;
    public int RayDistance = 4;
    public UnityEvent SendInputEvent;
    public GameObject KeyPress;

    void Update()
    {
        SendInput();
        PlayerInput();
    }
    void Start()
    {
        DisL.GetComponent<TextMesh>().text = "1";
        DisR.GetComponent<TextMesh>().text = "1";
    }

    public void SendInput()
    {
        var layerMask = ~(1 << 10);
        RaycastHit TestRay;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out TestRay, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

            if (TestRay.transform.tag == "SendInput")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SendInputEvent.Invoke();
                    KeyPress.GetComponent<AudioSource>().Play(0);
                     SI.GetComponent<Animator>().SetTrigger("Click");
                }
            }
        }
    }

    public void PlayerInput()
    {
        var layerMask = ~(1 << 10);
        RaycastHit TestRay;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out TestRay, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

            if (TestRay.transform.tag == "Left1")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    InputLeft = 1;
                    DisL.GetComponent<TextMesh>().text = "1";
                    L1.GetComponent<Animator>().SetTrigger("Click");
                    KeyPress.GetComponent<AudioSource>().Play(0);
                }
            }
            else if (TestRay.transform.tag == "Left2")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    InputLeft = 2;
                    DisL.GetComponent<TextMesh>().text = "2";
                    L2.GetComponent<Animator>().SetTrigger("Click");
                    KeyPress.GetComponent<AudioSource>().Play(0);
                }
            }
            else if (TestRay.transform.tag == "Left3")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    InputLeft = 3;
                    DisL.GetComponent<TextMesh>().text = "3";
                    L3.GetComponent<Animator>().SetTrigger("Click");
                    KeyPress.GetComponent<AudioSource>().Play(0);
                }
            }
            else if (TestRay.transform.tag == "Right1")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    InputRight = 1;
                    DisR.GetComponent<TextMesh>().text = "1";
                    R1.GetComponent<Animator>().SetTrigger("Click");
                    KeyPress.GetComponent<AudioSource>().Play(0);
                }
            }
            else if (TestRay.transform.tag == "Right2")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    InputRight = 2;
                    DisR.GetComponent<TextMesh>().text = "2";
                    R2.GetComponent<Animator>().SetTrigger("Click");
                    KeyPress.GetComponent<AudioSource>().Play(0);
                }
            }
            else if (TestRay.transform.tag == "Right3")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    InputRight = 3;
                    DisR.GetComponent<TextMesh>().text = "3";
                    R3.GetComponent<Animator>().SetTrigger("Click");
                    KeyPress.GetComponent<AudioSource>().Play(0);
                }
            }
        }
    }
}
