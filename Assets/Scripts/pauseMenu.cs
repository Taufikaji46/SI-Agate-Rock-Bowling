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
        FindObjectOfType<audioManager>().Play("clickButton");
    }

    public void resumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        FindObjectOfType<audioManager>().Play("clickButton");
    }

    public void mainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mainmenu");
        FindObjectOfType<audioManager>().Play("clickButton");
    }

    public void leaveGame()
    {
        SceneManager.LoadScene("SelectionLevel");
        FindObjectOfType<audioManager>().Play("clickButton");
    }

}
