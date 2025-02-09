﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class FindingTorch : MonoBehaviour
{
    //RayCast Info
    public Transform Camera;
    public float RayDistance = 100f;

    //Torch
    public GameObject TorchAsset;
    //WILL NEED TO CHANGE TO IMAGE
    public GameObject TorchText;

    public UnityEvent SendTorch;

    void Update()
    {
        Torch();
    }

    public void Torch()
    {
        var layerMask = ~(1 << 10);
        RaycastHit Ray;
        if (Physics.Raycast(Camera.position, transform.TransformDirection(Camera.forward), out Ray, RayDistance, layerMask))
        {
            Debug.DrawRay(Camera.position, transform.TransformDirection(Camera.forward) * Ray.distance, Color.green);
            if (Ray.transform.tag == "StartingTorch")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("FOUND TORCH");

                    TorchAsset.SetActive(false);
                    TorchText.SetActive(true);

                    SendTorch.Invoke();
                }
            }
        }

    }
}
