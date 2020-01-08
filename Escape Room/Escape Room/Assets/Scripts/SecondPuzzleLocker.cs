using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPuzzleLocker : MonoBehaviour
{
    // Start is called before the first frame update
    private ControllerV2Controller Controller;
    public Transform Camera;
    public GameObject KeyCardItem;
    public GameObject Light;
    public float RayDistance = 3f;
    bool GotKeyCard = false;
    public GameObject Noise;

    void Start()
    {
        Controller = gameObject.GetComponent<ControllerV2Controller>();
        Controller.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetKeyCode();
    }

    public void GetKeyCode()
    {
        var layerMask = ~(1 << 10);
        RaycastHit Ray;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out Ray, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * Ray.distance, Color.red);
            if (Ray.transform.tag == "KeyCard")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("GOT KEY");
                    GotKeyCard = true;
                    KeyCardItem.SetActive(false);

                    //DISPLAY KEYCARD GUI
                    //KEYCODE SOUND.
                }
            }
        }

        RaycastHit Ray2;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out Ray2, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * Ray2.distance, Color.red);
            if (Ray.transform.tag == "Reciever")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (GotKeyCard == true)
                    {
                        Controller.enabled = true;
                        Light.GetComponent<Animator>().SetTrigger("On");
                        Noise.GetComponent<AudioSource>().Play();
                    }
                }
            }
        }

    }
}
