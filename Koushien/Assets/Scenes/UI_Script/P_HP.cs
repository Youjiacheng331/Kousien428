using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P_HP : MonoBehaviour
{
    public Damy damy;
    public Text HPtext;

    // Update is called once per frame
    void Update()
    {
        HPtext.text = damy.PlayerHP.ToString();
    }
}
