using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void restartStage1()
    {
        SceneManager.LoadScene("temp");
    }

    public void restartStage2()
    {
        SceneManager.LoadScene("temp 1");
    }

    public void restartStage3()
    {
        SceneManager.LoadScene("temp 2");
    }

    public void nextLevel2()
    {
        Debug.Log("test");
        SceneManager.LoadScene("stage_2");
    }

    public void nextLevel3()
    {
        SceneManager.LoadScene("stage_3");
    }

    public void endingLevel()
    {
        SceneManager.LoadScene("EndingScene");
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
