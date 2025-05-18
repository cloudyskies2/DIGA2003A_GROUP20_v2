using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMANU1 : MonoBehaviour
{
    public MAINMANU1()
    {
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
