using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject InvalidText;

    public void InvalidInput()
    {
        InvalidText.SetActive(true);
        Invoke("OffText", 2f);
    }
    public void OffText()
    {
        InvalidText = this.gameObject.transform.GetChild(0).gameObject;
        InvalidText.SetActive(false);
    }
}
