using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public Button start;
    public Button option;
    public Button quit;

    private void Start()
    {
        start.onClick.AddListener(() => ButtonClickd("st"));
        option.onClick.AddListener(() => ButtonClickd("op"));
        quit.onClick.AddListener(() => ButtonClickd("qu"));

    }

    public void ButtonClickd(string buttonname)
    {
        switch (buttonname)
        {
            case "st":

                LoadStageSelect();

                break;
            case "op":

                break;
            case "qu":
                Quit();
                break;


        }

    }

    public void LoadStageSelect()
    {
        //ステージセレクトのシーンをロード
        SceneManager.LoadScene("StageSelect");
    }
    public void Quit()
    {
        //エディタで実行している場合はエディタを停止
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        //ゲームをビルドして実行している場合はアプリケーションを終了
        Application.Quit();

    }
}
