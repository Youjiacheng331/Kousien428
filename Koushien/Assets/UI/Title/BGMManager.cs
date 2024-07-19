using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager instance;
    public AudioSource bgmSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayBGM(AudioClip clip)
    {
        if (bgmSource.clip != clip)
        {
            bgmSource.clip = clip;
            bgmSource.Play();
        }
    }

    public void StopBGM()
    {
        if (bgmSource.isPlaying)
        {
            bgmSource.Stop();
        }
    }

    public void SaveBGMProgress()
    {
        PlayerPrefs.SetFloat("BGMTime", bgmSource.time);
        PlayerPrefs.Save();
    }

    public void LoadBGMProgress()
    {
        if (PlayerPrefs.HasKey("BGMTime"))
        {
            bgmSource.time = PlayerPrefs.GetFloat("BGMTime");
            bgmSource.Play();
        }
    }

    public void DestroyAudioManager()
    {
        if (instance != null)
        {
            Destroy(instance.gameObject);
            instance = null;
        }
    }
}
