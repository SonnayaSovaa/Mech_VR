using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonControl : MonoBehaviour
{
    private bool _pause=false;

    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private GameObject pausepanel;
    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");

    }

    public void Start()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Pause()
    {
        if (!_pause)
        {
            Time.timeScale=0;
            buttonText.text = "продолжить";
            _pause = true;
            pausepanel.SetActive(true);
        }
        else
        {
            Time.timeScale=1;
            buttonText.text = "пауза";
            _pause = false;
            pausepanel.SetActive(false);
        }
    }


}
