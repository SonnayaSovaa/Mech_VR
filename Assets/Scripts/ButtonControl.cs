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

    [SerializeField] Image fadePanel; 
    [SerializeField] float fadeSpeed = 1f; 


    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Volume");
        if (sliderC!=null) sliderC.value = PlayerPrefs.GetFloat("Volume");
        _audioSource.volume = slider.value;
        Time.timeScale = 1;
        _audioSource.Play();
        StartCoroutine(FadeIn());
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
        StartCoroutine(FadeOut("SampleScene"));
    }

    public void ToMenu()
    {
        if (slider.IsActive()) PlayerPrefs.SetFloat("Volume", slider.value);
        if (sliderC.IsActive()) PlayerPrefs.SetFloat("Volume", sliderC.value);
        StartCoroutine(FadeOut("Menu"));
        

    }

    public void Starting()
    {
        if (slider.IsActive()) PlayerPrefs.SetFloat("Volume", slider.value);
        if (sliderC!=null&&sliderC.IsActive()) PlayerPrefs.SetFloat("Volume", sliderC.value);
        StartCoroutine(FadeOut("SampleScene"));
        
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
    
    
    private IEnumerator FadeIn() 
    { 
        float t = 1f; 

        while (t > 0f) 
        { 
            t -= Time.deltaTime * fadeSpeed; 
            fadePanel.color = new Color(0f, 0f, 0f, t); 
            yield return null; 
        } 
    } 

    private IEnumerator FadeOut(string sceneName) 
    {
        float t=0f;
        for (int i = 0; i < 100000; i++)
        {
            t = 0f;
        }
        
        while (t < 1f) 
        { 
            t += Time.deltaTime * fadeSpeed; 
            fadePanel.color = new Color(0f, 0f, 0f, t); 
            yield return null; 
        } 

        SceneManager.LoadScene(sceneName); 
    } 


}
