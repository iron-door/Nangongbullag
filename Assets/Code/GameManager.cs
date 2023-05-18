using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public bool isLive;

    public void goToBattle()
    {
        SceneManager.LoadScene("Stage");
    }
    private void Awake()
    {
        instance = this;
    }
}
