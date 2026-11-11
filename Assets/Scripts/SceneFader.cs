using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFader : MonoBehaviour
{
    public Image image;
    public AudioSource backgroundMusic;
   

    private void Start()
    {
        StartCoroutine(FadeOut());
    }

    public void FadeAndLoad(string sceneName, float duration)
    {
        StartCoroutine(Fader(sceneName, duration));
        StartCoroutine(FadeMusic(duration));
    
    }

    public void LoadCutScene()
    {
        FadeAndLoad("CutScene", 1f);
    }

    IEnumerator Fader(string sceneName, float duration)
    {
        float t = 0;
        Color c = image.color;

        while (t < duration)
        {
            t += Time.deltaTime;
            c.a = Mathf.Clamp01(t / duration);
            image.color = c;
            yield return null;
        }

        c.a = 1;
        image.color = c;

        SceneManager.LoadScene(sceneName);
    }

    IEnumerator FadeOut()
    {
        float t = 0;
        Color c = image.color;

        while (t < 1)
        {
            t += Time.deltaTime;
            c.a = 1f - Mathf.Clamp01(t / 1f);
            image.color = c;
            yield return null;
        }

        c.a = 0;
        image.color = c;
    }

    IEnumerator FadeMusic(float duration)
    {
        if (backgroundMusic == null)
            yield break;

        float startVolume = backgroundMusic.volume;
        float t = 0;

        while (t < duration)
        {
            t += Time.deltaTime;
            backgroundMusic.volume = Mathf.Lerp(startVolume, 0f, Mathf.Clamp01(t / duration));
            yield return null;
        }

        backgroundMusic.volume = 0f;
    }
}
