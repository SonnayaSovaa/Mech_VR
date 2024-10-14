using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    private bool _pause=false;
    private bool instr=false;


    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private GameObject pausepanel;
    [SerializeField] private GameObject Instrpanel;

    [SerializeField] private Slider slider;
    [SerializeField] private AudioSource _audioSource;

    private void Awake()
    {
        slider.value = PlayerPrefs.GetFloat("Volume");
        Time.timeScale = 1;
    }


    public void Instr()
    {
        instr = !instr;
        Instrpanel.SetActive(instr);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void ToMenu()
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
        SceneManager.LoadScene("Menu");
        

    }

    public void Starting()
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
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
            _audioSource.Stop();
        }
        else
        {
            Time.timeScale=1;
            buttonText.text = "пауза";
            _pause = false;
            pausepanel.SetActive(false);
            _audioSource.Play();
        }
    }


}
