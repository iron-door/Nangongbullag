using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SceneChangeToStage()
    {
        SceneManager.LoadScene("Stage");
    }
    public void SceneChangeToGame1()
    {
        SceneManager.LoadScene("Game1");
    }
}
