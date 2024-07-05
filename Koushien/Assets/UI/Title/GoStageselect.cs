using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStageselect : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }
    public void GoSS()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
