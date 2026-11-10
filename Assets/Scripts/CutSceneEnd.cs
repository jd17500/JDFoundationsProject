using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CutsceneEnd : MonoBehaviour
{
    private PlayableDirector director;

    private void OnEnable()
    {
        director = GetComponent<PlayableDirector>();
        director.stopped += OnTimelineFinished;
    }

    private void OnDisable()
    {
        director.stopped -= OnTimelineFinished;
    }

    private void OnTimelineFinished(PlayableDirector playableDirector)
    {
        SceneManager.LoadScene("ArcadeHunt");
    }
}