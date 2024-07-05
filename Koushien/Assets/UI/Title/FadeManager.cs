using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeManager : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeToScene(string sceneName,bool isQuit=false)
    {
        StartCoroutine(FadeOut(sceneName, isQuit));
    }

    IEnumerator FadeIn()
    {
        float elapsedTime = 0f;
        Color color = fadeImage.color;
        while(elapsedTime<fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Clamp01(1.0f - (elapsedTime / fadeDuration));
            fadeImage.color = color;
            yield return null;
        }
    }

    IEnumerator FadeOut(string sceneName, bool isQuit)
    {
        float elapsedTime = 0f;
        Color color = fadeImage.color;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Clamp01(elapsedTime / fadeDuration);
            fadeImage.color = color;
            yield return null;
        }

        if (isQuit)
        {
            //エディタで実行している場合はエディタを停止
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            //ゲームをビルドして実行している場合はアプリケーションを終了
            Application.Quit();
        }
        else
        { 
            SceneManager.LoadScene(sceneName);
        }
    }

}
