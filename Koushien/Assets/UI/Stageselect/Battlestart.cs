using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Battlestart : MonoBehaviour
{
    public Button stage1;
    public Button stage2;
    public Button stage3;
    public Button title;

    private void Start()
    {
        stage1.onClick.AddListener(() => ButtonClicked("s1"));
        stage2.onClick.AddListener(() => ButtonClicked("s1"));
        stage3.onClick.AddListener(() => ButtonClicked("s1"));
        title.onClick.AddListener(() => ButtonClicked("ti"));

    }

    public void ButtonClicked(string buttonname)
    {
        switch (buttonname)
        {
            case"s1":
                //ここにステージ１の敵設定

                LoadBattle();
                break;
            case "s2":
                //ここにステージ2の敵設定

                LoadBattle();
                break;
            case "s3":
                //ここにステージ3の敵設定

                LoadBattle();
                break;
            case "ti":
                LoadTitle();
                break;
        }
    }

    public void LoadBattle()
    {
        //タイトルのシーンをロード
        SceneManager.LoadScene("Battle");
    }
    public void LoadTitle()
    {
        //タイトルのシーンをロード
        SceneManager.LoadScene("Title");
    }
}
