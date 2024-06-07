using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public GameObject panel, board;

    public void PauseButtonPressed()
    {
        panel.SetActive(true);
        board.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ContinueButtonPressed()
    {
        panel.SetActive(false);
        board.SetActive(true);
        Time.timeScale = 1.0f;
    }
    public void MenuButtonPressed()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
