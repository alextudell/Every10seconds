using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private int lastLevelIndex;

    void Awake()
    {
        lastLevelIndex = PlayerPrefs.GetInt("LastLevel");
    }

    public void EnterGame()
    {
        // if (PlayerPrefs.HasKey("LastLevel"))
        // {
        //     SceneManager.LoadScene(lastLevelIndex);
        // }
        // else
        // {
            SceneManager.LoadScene("StoryComix");
        // }
    }

    public void GameExit()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
