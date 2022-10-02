using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void EnterGame()
    {
        SceneManager.LoadScene("StoryComix");
    }

    public void GameExit()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
