using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void restartGame()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("temp");
    }

    public void selectLevel()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("SelectionLevel");
    }

    public void backtoMenu()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("Mainmenu");
    }
}
