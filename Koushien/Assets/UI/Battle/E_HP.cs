using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class E_HP : MonoBehaviour
{
    public Image hpimage;
    public Damy damy;
    public Text HPtext;

    // Update is called once per frame
    void Update()
    {
        HPtext.text = damy.EnemyHP.ToString();
        hpimage.fillAmount = damy.E_HPper;
    }
}
