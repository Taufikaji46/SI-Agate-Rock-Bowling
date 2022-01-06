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
        //SceneManager.LoadScene(3, LoadSceneMode.Additive);
        SceneManager.LoadScene("temp");
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(5);
    }

    public void selectLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void backtoMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
