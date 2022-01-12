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
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("temp");
    }

    public void restartStage2()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("temp 1");
    }

    public void restartStage3()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("temp 2");
    }

    public void nextLevel2()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("stage_2");
    }

    public void nextLevel3()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("stage_3");
    }

    public void endingLevel()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("EndingScene");
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
