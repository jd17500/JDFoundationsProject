using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingMenuButton : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
