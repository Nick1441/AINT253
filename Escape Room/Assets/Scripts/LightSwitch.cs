using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject SwitchOn;
    public GameObject SwitchOff;
    public GameObject[] Lights;
    public float Duration = 3f;

    public Material Mat;
    public Color ColorOn = new Vector4(67, 67, 62, 1);
    public Color ColorOff = new Vector4(67, 67, 62, 0);
    public Transform Camera;
    public float RayDistance = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Lights = GameObject.FindGameObjectsWithTag("Light");
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
        SwitchOn.SetActive(true);
        SwitchOff.SetActive(false);

        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].GetComponent<Animator>().SetBool("On", false);
            //Lights[i].GetComponent<Light>().intensity = 2.61f;
            //Lights[i].GetComponent<Light>().color = Color.Lerp(ColorOff, ColorOn, Duration);
        }
    }

    public void OffLights()
    {
        SwitchOn.SetActive(false);
        SwitchOff.SetActive(true);

        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].GetComponent<Animator>().SetBool("On", true);
            //Lights[i].GetComponent<Light>().intensity = 0f;
            //Lights[i].GetComponent<Light>().color = Color.Lerp(ColorOn, ColorOff, Duration);
        }
    }
}
