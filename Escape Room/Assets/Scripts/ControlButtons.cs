using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControlButtons : MonoBehaviour
{
    public GameObject Output1;
    public GameObject Output2;
    public GameObject Output3;

    public GameObject In1;
    public GameObject In2;
    public GameObject In3;

    public int InputLeft = 1;
    public int InputRight = 1;

    public Transform Camera;
    public GameObject Text;

    public int RayDistance = 4;
    public UnityEvent SendInputEvent;


    public bool Floaty = false;
    // Start is called before the first frame update
    void Start()
    {
        Output1.SetActive(true);
        Output2.SetActive(false);
        Output3.SetActive(false);

        In1.SetActive(true);
        In2.SetActive(false);
        In3.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        LeftInput();
        RightInput();
        RightInput2();
        LeftInput2();
        SendInput();
        FloatingText();
    }

    public void FloatingText()
    {
        if (!Floaty) 
        {
            Text.SetActive(false);
        }
        else
        {
            Text.SetActive(true);
        }
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
                }
            }
        }
    }
    public void LeftInput()
    {
        var layerMask = ~(1 << 10);
        RaycastHit TestRay;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out TestRay, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

            if (TestRay.transform.tag == "interactableLeft")
            {
                Floaty = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("WORKS - Bottom");
                    if (Output1.activeSelf == true)
                    {
                        Output1.SetActive(false);
                        Output2.SetActive(true);
                        Output3.SetActive(false);
                        InputLeft = 2;
                    }
                    else if (Output2.activeSelf == true)
                    {
                        Output1.SetActive(false);
                        Output2.SetActive(false);
                        Output3.SetActive(true);
                        InputLeft = 3;
                    }
                    else
                    {
                        Output1.SetActive(true);
                        Output2.SetActive(false);
                        Output3.SetActive(false);
                        InputLeft = 1;
                    }
                }
            }
            else
            {
                Floaty = false;
            }
        }
    }

    public void LeftInput2()
    {
        var layerMask = ~(1 << 10);
        RaycastHit TestRay;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out TestRay, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

            if (TestRay.transform.tag == "interactableLeft2")
            {
                Floaty = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("WORKS");
                    if (Output1.activeSelf == true)
                    {
                        Output1.SetActive(false);
                        Output2.SetActive(false);
                        Output3.SetActive(true);
                        InputLeft = 3;
                    }
                    else if (Output2.activeSelf == true)
                    {
                        Output1.SetActive(true);
                        Output2.SetActive(false);
                        Output3.SetActive(false);
                        InputLeft = 1;
                    }
                    else
                    {
                        Output1.SetActive(false);
                        Output2.SetActive(true);
                        Output3.SetActive(false);
                        InputLeft = 2;
                    }
                }
            }
            else
            {
                Floaty = false;
            }
        }
    }

    public void RightInput()
    {
        var layerMask = ~(1 << 10);
        RaycastHit TestRay;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out TestRay, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

            if (TestRay.transform.tag == "interactableRight")
            {
                Floaty = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (In1.activeSelf == true)
                    {
                        In1.SetActive(false);
                        In2.SetActive(true);
                        In3.SetActive(false);
                        InputRight = 2;
                    }
                    else if (In2.activeSelf == true)
                    {
                        In1.SetActive(false);
                        In2.SetActive(false);
                        In3.SetActive(true);
                        InputRight = 3;
                    }
                    else
                    {
                        In1.SetActive(true);
                        In2.SetActive(false);
                        In3.SetActive(false);
                        InputRight = 1;
                    }
                }
            }
        }

    }

    public void RightInput2()
    {
        var layerMask = ~(1 << 10);
        RaycastHit TestRay;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out TestRay, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

            if (TestRay.transform.tag == "interactableRight2")
            {
                Floaty = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (In1.activeSelf == true)
                    {
                        In1.SetActive(false);
                        In2.SetActive(false);
                        In3.SetActive(true);
                        InputRight = 3;
                    }
                    else if (In2.activeSelf == true)
                    {
                        In1.SetActive(true);
                        In2.SetActive(false);
                        In3.SetActive(false);
                        InputRight = 1;
                    }
                    else
                    {
                        In1.SetActive(false);
                        In2.SetActive(true);
                        In3.SetActive(false);
                        InputRight = 2;
                    }
                }
            }
        }

    }
}
