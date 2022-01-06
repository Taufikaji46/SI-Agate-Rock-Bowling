using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;

    // Start is called before the first frame update
    public void pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;

    }

    public void mainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mainmenu");
    }

    public void leaveGame()
    {
        Application.Quit();
    }

}
