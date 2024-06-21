using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image timeimage;
    public Damy damy;//ここにエネミーを取る
    public Text timerText;

    // Update is called once per frame
    void Update()
    {
        timerText.text = damy.attackCountdown.ToString("F2") + "s";
        timeimage.fillAmount = damy.timeper;
    }
}
