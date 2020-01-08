using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject SwitchOn;
    public GameObject SwitchOff;
    public GameObject Torch;
    public GameObject TurnLight;
    public GameObject[] Lights;

    public GameObject[] Items;
    public float Duration = 3f;

    public Material Mat;
    public Transform Camera;
    public float RayDistance = 10f;
    public GameObject Switch;

    public bool GotTorch = false;

    // Start is called before the first frame update
    void Start()
    {
        Lights = GameObject.FindGameObjectsWithTag("Light");
        Items = GameObject.FindGameObjectsWithTag("Item");
        TurnLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCheck();
    }

    public void SwitchCheck()
    {
        var layerMask = ~(1 << 10);
        RaycastHit Ray;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out Ray, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * Ray.distance, Color.red);
            if (Ray.transform.tag == "SwitchOn")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Contact");
                    OffLights();
                }
            }
            else if (Ray.transform.tag == "SwitchOff")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Contact");
                    OnLights();
                }
            }
        }
    }

    public void OnLights()
    {
        //Make Arm Animation Make
        if (GotTorch == true)
        {
            Torch.GetComponent<Animator>().SetTrigger("TorchUp");
            Invoke("TurnLightOn", 0.9f);
            //Trigger Animation For Holding Into IDLE Place.
        }

        SwitchOn.SetActive(true);
        SwitchOff.SetActive(false);

        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].GetComponent<Animator>().SetTrigger("LightOff");
        }

        for (int i = 0; i < Items.Length; i++)
        {
            Items[i].GetComponent<Animator>().SetTrigger("ItemOff");
        }
    }

    public void OffLights()
    {
        //Make Arm Animation Make
        if (GotTorch == true)
        {
            Torch.GetComponent<Animator>().SetTrigger("TorchDown");
            Invoke("TurnLightOff", 0.2f);
        }

        SwitchOn.SetActive(false);
        SwitchOff.SetActive(true);

        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].GetComponent<Animator>().SetTrigger("LightOn");
        }

        for (int i = 0; i < Items.Length; i++)
        {
            Items[i].GetComponent<Animator>().SetTrigger("ItemOn");
        }
    }

    public void PickedUpTorch()
    {
        GotTorch = true;
    }

    public void TurnLightOn()
    {
        
        TurnLight.SetActive(true);
        Switch.GetComponent<AudioSource>().Play();
    }

    public void TurnLightOff()
    {
        Switch.GetComponent<AudioSource>().Play();
        TurnLight.SetActive(false);
    }
}
