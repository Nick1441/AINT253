using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    public void LeftInput()
    {
        RaycastHit TestRay;
        if (Physics.Raycast(Camera.position, Camera.TransformDirection(Camera.forward), out TestRay,  10))
        {
            Debug.DrawRay(Camera.position, Camera.TransformDirection(Camera.forward) * TestRay.distance, Color.yellow);

            //Debug.Log(TestRay);

            if (TestRay.transform.tag == "interactableLeft")
            {

                Debug.Log("TEST");
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Debug.Log("HELLO SAM");
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
        }

        
    }

    public void RightInput()
    {
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
