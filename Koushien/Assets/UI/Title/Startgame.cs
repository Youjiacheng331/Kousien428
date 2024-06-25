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
        //�X�e�[�W�Z���N�g�̃V�[�������[�h
        SceneManager.LoadScene("StageSelect");
    }
    public void Quit()
    {
        //�G�f�B�^�Ŏ��s���Ă���ꍇ�̓G�f�B�^���~
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        //�Q�[�����r���h���Ď��s���Ă���ꍇ�̓A�v���P�[�V�������I��
        Application.Quit();

    }
}
