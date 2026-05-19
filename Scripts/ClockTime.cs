using UnityEngine;
using System;
using TMPro;

public class ClockTime : MonoBehaviour
{
    public TextMeshProUGUI TimeText;
    private DateTime currentTime;
    void Start()
    {
        currentTime = DateTime.Now;
    }
    void FixedUpdate()
    {
        currentTime = DateTime.Now;
        int hours = currentTime.Hour;
        int minute = currentTime.Minute;
        TimeText.text = hours.ToString() + ":" + minute.ToString();
    }
}
