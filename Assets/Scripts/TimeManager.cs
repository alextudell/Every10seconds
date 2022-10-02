using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeManager : MonoBehaviour
{
    UIManager uiManager;
    PlayerManager playerManager;

    public float timeDefault;
    private float timeLeft;
    public bool timerOn;
    [SerializeField]
    private float _addTime;

    // Start is called before the first frame update
    void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
        uiManager = GetComponent<UIManager>();

        timerOn = true;
        resetTimer();
    }

    public void resetTimer()
    {
        timeLeft = timeDefault;
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
                playerManager.ResetPlayer();
                resetTimer();
                uiManager.ShowAdvice(3,2f);
            }
            
        }
    }

    private void UpdateTimer(float currentTime)
    {
        currentTime +=1;

        float leftSeconds = Mathf.FloorToInt(currentTime % 60);
        uiManager.timerText.SetText(leftSeconds.ToString());
    }

    public void GetTimeForKilling()
    {
        timeLeft += _addTime;
    }
}
