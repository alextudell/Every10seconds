using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class UIManager : MonoBehaviour
{
    public Sprite fullBottle;
    public Sprite emptyBottle;
    
    public GameObject healthBottle1;
    public GameObject healthBottle2;
    public GameObject healthBottle3;

    public GameObject ui_Canvas;
    public TMP_Text timerText;

    void Start()
    {
        ResetUI(); 
    }

    private void ResetUI()
    {
        healthBottle1.GetComponent<Image>().sprite = fullBottle;
        healthBottle2.GetComponent<Image>().sprite = fullBottle;
        healthBottle3.SetActive(false);
        
        Debug.Log("UI Reseted");
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
}
