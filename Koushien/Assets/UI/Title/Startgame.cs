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
    public AudioClip startclip;
    public AudioClip optionclip;
    public AudioClip quitclip;
    public FadeManager fadeManager;

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
                //SE‚ð–Â‚ç‚·
                PlaySE(startclip);

                fadeManager.FadeToScene("stageSelect");

                break;
            case "op":
                //SE‚ð–Â‚ç‚·
                PlaySE(optionclip);
                break;
            case "qu":
                //SE‚ð–Â‚ç‚·
                PlaySE(quitclip);

                fadeManager.FadeToScene(null,true);
                
                break;


        }

    }

    void PlaySE(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    }

}
