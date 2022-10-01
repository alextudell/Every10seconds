using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeManager : MonoBehaviour
{
    UIManager uiManager;

    public float timeLeft;
    public bool timerOn;

    // Start is called before the first frame update
    void Awake()
    {
        uiManager = GetComponent<UIManager>();
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
            }
            else
            {
                timeLeft = 0;
                timerOn = false;
            }
            
        }
    }

    private void UpdateTimer(float currentTime)
    {
        currentTime +=1;

        float leftSeconds = Mathf.FloorToInt(currentTime % 60);
        uiManager.timerText.SetText(leftSeconds.ToString());
        Debug.Log(leftSeconds);
        // uiManager.timerText = leftSeconds;
    }
}
