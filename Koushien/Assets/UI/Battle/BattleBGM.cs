using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleBGM : MonoBehaviour
{
    public AudioSource bgm1;
    public AudioSource bgm2;
    public AudioSource bgm3;
    bool st1;
    bool st2;
    bool st3;
    public BGMManager bgmManager;

    // Start is called before the first frame update
    void Start()
    {
        bgmManager.DestroyAudioManager();
        LoadState();
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadState()
    {
        st1 = PlayerPrefs.GetInt("st1", 0) == 1;
        st2 = PlayerPrefs.GetInt("st2", 0) == 1;
        st3 = PlayerPrefs.GetInt("st3", 0) == 1;
    }

    void PlayBGM()
    {
        if(st1==true)
        {
            bgm1.Play();
        }
        else if(st2==true)
        {
            bgm2.Play();
        }
        else if(st3==true)
        {
            bgm3.Play();
        }

    }

}
