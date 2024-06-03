using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTetris : MonoBehaviour
{
    public void OnPlayerHandler()
    {
        SceneManager.LoadScene(1);
    }
    public void OnExitHandler()
    {
        Application.Quit();
    }
}
