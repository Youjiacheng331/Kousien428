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
    public AudioClip stageclip;
    public AudioClip titleclip;
    public FadeManager fadeManager;

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
                PlaySE(stageclip);

                fadeManager.FadeToScene("Battle", false);
                break;
            case "s2":
                //ここにステージ2の敵設定
                PlaySE(stageclip);

                fadeManager.FadeToScene("Battle", false);
                break;
            case "s3":
                //ここにステージ3の敵設定
                PlaySE(stageclip);

                fadeManager.FadeToScene("Battle", false);
                break;
            case "ti":
                //タイトルに戻る
                PlaySE(titleclip);
                fadeManager.FadeToScene("Title", false);
                break;
        }
    }

    void PlaySE(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    }

}
