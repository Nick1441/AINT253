using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchOnPlayer : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Torch;

    void Update()
    {
        Torch.transform.position = Camera.transform.position;
        Torch.transform.rotation = Camera.transform.rotation;
    }
}
