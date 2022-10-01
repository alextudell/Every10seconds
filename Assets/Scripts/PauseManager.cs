using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static bool gamePaused;
    UIManager uiManager;

    void Awake()
    {
        uiManager = GetComponent<UIManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamePaused = !gamePaused;
            PauseGame(gamePaused);

            uiManager.changePauseUI(gamePaused);
        }
    }

    void PauseGame(bool isPause)
    {
        Debug.Log("game is paused: " + isPause);

        if(isPause)
        {
            Time.timeScale = 0f;
        }
        else 
        {
            Time.timeScale = 1;
        }
    }
}
