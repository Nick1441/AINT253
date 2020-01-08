using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text timerText;
    private float secondsCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
    }

    public void UpdateTimerUI()
    {
        secondsCount += Time.deltaTime;
        timerText.text = (int)secondsCount + "s";
    }

    void FixedUpdate()
    {
        PlayerPrefs.SetInt("Score", (int) secondsCount);
    }
}