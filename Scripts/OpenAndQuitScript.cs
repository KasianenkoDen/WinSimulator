using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenAndQuitScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
