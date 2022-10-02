using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComixController : MonoBehaviour
{
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject sprite3;
    public GameObject sprite4;
    public GameObject sprite5;
    public GameObject sprite6;
    public GameObject sprite7;
    public GameObject sprite8;
    void Start()
    {
        StartCoroutine(ComixCoroutine());
    }

    private IEnumerator ComixCoroutine()
    {
        yield return new WaitForSeconds(1.5f);
        sprite1.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        sprite2.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        sprite3.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        sprite4.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        sprite5.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        sprite6.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        sprite7.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        sprite8.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        sprite8.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        sprite8.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        sprite8.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        sprite8.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("level1");
    }
}
