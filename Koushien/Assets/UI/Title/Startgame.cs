using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public void LoadStageSelect()
    {
        //�X�e�[�W�Z���N�g�̃V�[�������[�h
        SceneManager.LoadScene("StageSelect");
    }
}
