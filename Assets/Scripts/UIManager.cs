using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
 
public class UIManager : MonoBehaviour
{
    [Header("health sprites links")]
    public Sprite fullBottle;
    public Sprite emptyBottle;
    
    [Header("game GUI links")]
    public GameObject healthBottle1;
    public GameObject healthBottle2;
    public GameObject healthBottle3;
    public TMP_Text timerText;
    public TMP_Text deathAdviceText;
    
    [Header("GUI links")]
    public GameObject pauseUI;
    public GameObject ui_Canvas;
    
    private string[] deathAdvices = new string[] { "Try again, please!", "Not NOW!", "Maybe, loot around?", "LOOOOL", "Dont do it", "WHAT? How a're u doing this?"};

    void Start()
    {
        ResetUI(); 
    }

    private void ResetUI()
    {
        healthBottle1.GetComponent<Image>().sprite = fullBottle;
        healthBottle2.GetComponent<Image>().sprite = fullBottle;
        healthBottle3.SetActive(false);

        deathAdviceText.enabled = false;
        
        Debug.Log("UI Reseted");
    }

    public void changePauseUI(bool isPause)
    {
        pauseUI.SetActive(isPause);
    }

    public void ChangeUIHealth(int currentHealth)
    {
        switch (currentHealth)
        {
            case 0:
                healthBottle1.GetComponent<Image>().sprite = emptyBottle;
                healthBottle2.GetComponent<Image>().sprite = emptyBottle;
                healthBottle3.GetComponent<Image>().sprite = emptyBottle;
                break;
            case 1:
                healthBottle1.GetComponent<Image>().sprite = fullBottle;
                healthBottle2.GetComponent<Image>().sprite = emptyBottle;
                healthBottle3.GetComponent<Image>().sprite = emptyBottle;
                break;
            case 2:
                healthBottle1.GetComponent<Image>().sprite = fullBottle;
                healthBottle2.GetComponent<Image>().sprite = fullBottle;
                healthBottle3.GetComponent<Image>().sprite = emptyBottle;
                break;
            case 3:
                healthBottle1.GetComponent<Image>().sprite = fullBottle;
                healthBottle2.GetComponent<Image>().sprite = fullBottle;
                healthBottle3.GetComponent<Image>().sprite = fullBottle;
                break;
            default:
                Debug.Log("Error health changer UI");
                break;
        }
    }

    public void ShowAdvice(int type, float delay)
    {
        switch (type)
        {
            case 0:
                StartCoroutine(ShowAdvice("Welcome   to:   " + SceneManager.GetActiveScene().name, delay));
                break;
            case 1:
                StartCoroutine(ShowAdvice("Card added!", delay));
                break;
            case 2:
                StartCoroutine(ShowAdvice("Checkpoint!", delay));
                break;
            case 3:
                string randomDeathAdvice= deathAdvices[Random.Range (0, deathAdvices.Length)];
                StartCoroutine(ShowAdvice(randomDeathAdvice, delay));
                break;
            default:
                Debug.Log("Error UI - Advice type text unknown");
                break;
        }
    }

    IEnumerator ShowAdvice (string advice, float delay) {
     deathAdviceText.text = advice;
     deathAdviceText.enabled = true;
     yield return new WaitForSeconds(delay);
     deathAdviceText.enabled = false;
 }  
}
