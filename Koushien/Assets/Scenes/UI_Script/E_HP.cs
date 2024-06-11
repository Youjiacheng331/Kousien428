using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class E_HP : MonoBehaviour
{
    public Damy damy;
    public Text HPtext;

    // Update is called once per frame
    void Update()
    {
        HPtext.text = damy.EnemyHP.ToString();
    }
}
