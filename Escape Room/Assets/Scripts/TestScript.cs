﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        //gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT");
        gameObject.GetComponent<Animator>().SetTrigger("LightIn");
        //gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Animator>().SetTrigger("LightOut");
        //gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}