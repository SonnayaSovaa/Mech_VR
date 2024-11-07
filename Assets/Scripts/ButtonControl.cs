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
    
    [SerializeField] private TMP_Text buttonTextC;
    [SerializeField] private GameObject pausepanelC;

    [SerializeField] private Slider sliderC;



    private void Awake()
    {
        slider.value = PlayerPrefs.GetFloat("Volume");
        if (sliderC!=null) sliderC.value = PlayerPrefs.GetFloat("Volume");
        _audioSource.volume = slider.value;
        Time.timeScale = 1;
        _audioSource.Play();
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
        if (slider.IsActive()) PlayerPrefs.SetFloat("Volume", slider.value);
        if (sliderC.IsActive()) PlayerPrefs.SetFloat("Volume", sliderC.value);
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void ToMenu()
    {
        if (slider.IsActive()) PlayerPrefs.SetFloat("Volume", slider.value);
        if (sliderC.IsActive()) PlayerPrefs.SetFloat("Volume", sliderC.value);
        SceneManager.LoadScene("Menu");
        

    }

    public void Starting()
    {
        if (slider.IsActive()) PlayerPrefs.SetFloat("Volume", slider.value);
        if (sliderC.IsActive()) PlayerPrefs.SetFloat("Volume", sliderC.value);
        SceneManager.LoadScene("SampleScene");
    }

    public void Pause()
    {
        if (!_pause)
        {
            _audioSource.Pause();
            Time.timeScale=0;
            buttonText.text = "продолжить";
            buttonTextC.text = "продолжить";
            _pause = true;

            
        }
        else
        {
            Time.timeScale=1;
            buttonText.text = "пауза";
            buttonTextC.text = "пауза";
            _pause = false;
           //_audioSource.UnPause();
        }
        
        pausedUI();
    }

    void pausedUI()
    {
        pausepanel.SetActive(_pause);
        pausepanelC.SetActive(_pause);
    }


}
