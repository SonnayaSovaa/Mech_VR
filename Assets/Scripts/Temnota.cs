using System.Collections; 
using UnityEngine; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class FadeInOut : MonoBehaviour 
{ 
    public Image fadePanel; 
    public float fadeSpeed = 1f; 

    private void Start() 
    { 
        StartCoroutine(FadeIn()); 
    } 

    public void FadeAndLoadScene(string sceneName) 
    { 
        StartCoroutine(FadeOutAndLoad(sceneName)); 
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

    private IEnumerator FadeOutAndLoad(string sceneName) 
    { 
        float t = 0f; 

        while (t < 1f) 
        { 
            t += Time.deltaTime * fadeSpeed; 
            fadePanel.color = new Color(0f, 0f, 0f, t); 
            yield return null; 
        } 

        SceneManager.LoadScene(sceneName); 
    } 
}