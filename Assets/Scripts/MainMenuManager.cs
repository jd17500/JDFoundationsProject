using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject infoPanel;

   public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowInfo ()
    {
        mainMenuPanel.SetActive(false);
        infoPanel.SetActive(true);
    }

    public void ShowMainMenu()
    {
        infoPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
