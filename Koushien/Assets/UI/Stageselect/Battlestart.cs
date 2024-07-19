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
    public bool st1 = false;
    public bool st2 = false;
    public bool st3 = false;
    public BGMManager bgmManager;


    private void Start()
    {
        stage1.onClick.AddListener(() => ButtonClicked("s1"));
        stage2.onClick.AddListener(() => ButtonClicked("s2"));
        stage3.onClick.AddListener(() => ButtonClicked("s3"));
        title.onClick.AddListener(() => ButtonClicked("ti"));

    }

    public void ButtonClicked(string buttonname)
    {
        switch (buttonname)
        {
            case"s1":
                //ここにステージ１の敵設定
                PlaySE(stageclip);
                st1 = true;
                st3 = false;
                st2 = false;
                SaveState();
                fadeManager.FadeToScene("Battle", false);
                
                break;
            case "s2":
                //ここにステージ2の敵設定
                PlaySE(stageclip);
                st2 = true;
                st1 = false;
                st3 = false;
                SaveState();
                
                fadeManager.FadeToScene("Battle", false);
                
                break;
            case "s3":
                //ここにステージ3の敵設定
                PlaySE(stageclip);
                st3 = true;
                st1 = false;
                st2 = false;
                SaveState();
                
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

    void SaveState()
    {
        PlayerPrefs.SetInt("st1", st1 ? 1 : 0);
        PlayerPrefs.SetInt("st2", st2 ? 1 : 0);
        PlayerPrefs.SetInt("st3", st3 ? 1 : 0);
        PlayerPrefs.Save();
    }

}
