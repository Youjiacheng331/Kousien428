using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Battlestart : MonoBehaviour
{
    public void LoadBattle()
    {
        //タイトルのシーンをロード
        SceneManager.LoadScene("Battle");
    }
}
