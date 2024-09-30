using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    private bool _pause=false;
    
    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Start()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Pause()
    {
        if(!_pause) Time.timeScale=0;
        else Time.timeScale=1;
    }


}
