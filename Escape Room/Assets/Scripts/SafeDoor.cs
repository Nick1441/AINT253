using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeDoor : MonoBehaviour
{
    //CODE
    string Code = "1234";
    public GameObject CodeText;
    public string CodeMaker = "";
    int length;

    //RAYCAST
    public float RayDistance = 100f;
    public Transform Camera;

    //DOOR OPEN
    bool Open = false;
    int Reset = 0;

    //NUMBERS BUTTONS
    public GameObject But1;
    public GameObject But2;
    public GameObject But3;
    public GameObject But4;
    public GameObject But5;
    public GameObject But6;
    public GameObject But7;
    public GameObject But8;
    public GameObject But9;

    public GameObject Light;
    public GameObject Door;

    void Update()
    {
        KeyPad();
        CodeChecker();
        length = CodeMaker.Length;
        //Debug.Log(CodeMaker);
        
    }

    public void KeyPad()
    {
        var layerMask = ~(1 << 10);
        RaycastHit Ray;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out Ray, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * Ray.distance, Color.blue);
            if (Ray.transform.tag == "Code1")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "1";
                    But1.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 1;
                    Invoke("ResetButton", 1.2f);
                }
            }
            else if (Ray.transform.tag == "Code2")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "2";
                    But2.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 2;
                    Invoke("ResetButton", 1.2f);
                }
            }
            else if (Ray.transform.tag == "Code3")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "3";
                    But3.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 3;
                    Invoke("ResetButton", 1.2f);
                }
            }
            else if (Ray.transform.tag == "Code4")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "4";
                    But4.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 4;
                    Invoke("ResetButton", 1.2f);
                }
            }
            else if (Ray.transform.tag == "Code5")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "5";
                    But5.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 5;
                    Invoke("ResetButton", 1.2f);
                }
            }
            else if (Ray.transform.tag == "Code6")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "6";
                    But6.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 6;
                    Invoke("ResetButton", 1.2f);
                }
            }
            else if (Ray.transform.tag == "Code7")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "7";
                    But7.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 7;
                    Invoke("ResetButton", 1.2f);
                }
            }
            else if (Ray.transform.tag == "Code8")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "8";
                    But8.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 8;
                    Invoke("ResetButton", 1.2f);
                }
            }
            else if (Ray.transform.tag == "Code9")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeMaker = CodeMaker + "9";
                    But9.GetComponent<Animator>().SetBool("Pressed", true);
                    Reset = 9;
                    Invoke("ResetButton", 1.2f);
                }
            }
        }
    }

    public void CodeChecker()
    {
        CodeText.GetComponent<TextMesh>().text = CodeMaker;

        if (length >= 4)
        {
            Debug.Log("ENTERED = " + CodeMaker);
            Debug.Log("Code = " + Code);
            if (CodeMaker == Code)
            {
                Light.GetComponent<Animator>().SetTrigger("Correct");
                Debug.Log("Safe Open");
                if (Open == false)
                {
                    Door.GetComponent<Animator>().SetTrigger("Open");
                    Open = true;
                }
                CodeMaker = "";
            }
            else
            {
                Light.GetComponent<Animator>().SetTrigger("Incorrect");
                Debug.Log("Safe Locked");
                CodeMaker = "";
            }
        }


        
    }

    public void ResetButton()
    {
        if (Reset == 1)
        {
            But1.GetComponent<Animator>().SetBool("Pressed", false);
        }
        else if (Reset == 2)
        {
            But2.GetComponent<Animator>().SetBool("Pressed", false);
        }
        else if (Reset == 3)
        {
            But3.GetComponent<Animator>().SetBool("Pressed", false);
        }
        else if (Reset == 4)
        {
            But4.GetComponent<Animator>().SetBool("Pressed", false);
        }
        else if (Reset == 5)
        {
            But5.GetComponent<Animator>().SetBool("Pressed", false);
        }
        else if (Reset == 6)
        {
            But6.GetComponent<Animator>().SetBool("Pressed", false);
        }
        else if (Reset == 7)
        {
            But7.GetComponent<Animator>().SetBool("Pressed", false);
        }
        else if (Reset == 8)
        {
            But8.GetComponent<Animator>().SetBool("Pressed", false);
        }
        else if (Reset == 9)
        {
            But9.GetComponent<Animator>().SetBool("Pressed", false);
        }
    }
}
