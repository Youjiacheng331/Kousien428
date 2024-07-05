using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStageselect : MonoBehaviour
{
    public FadeManager fadeManager;
    public AudioClip returnclip;

    public void GoSS()
    {
        PlaySE(returnclip);
        fadeManager.FadeToScene("StageSelect",false);
    }

    void PlaySE(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    }
}
