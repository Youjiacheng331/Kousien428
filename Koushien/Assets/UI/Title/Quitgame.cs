using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitgame : MonoBehaviour
{
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
