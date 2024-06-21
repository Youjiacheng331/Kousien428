using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitgame : MonoBehaviour
{
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
