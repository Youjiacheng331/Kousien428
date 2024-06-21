using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Returntitle : MonoBehaviour
{
    public void LoadTitle()
    {
        //タイトルのシーンをロード
        SceneManager.LoadScene("Title");
    }
}
