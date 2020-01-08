using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float Speed = 65f;
    void Update()
    {
        transform.Rotate(0, Speed * Time.deltaTime, 0);
    }
}
