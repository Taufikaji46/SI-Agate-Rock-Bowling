using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingScene : MonoBehaviour
{
    public void quit()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        Application.Quit();
    }

    public void backToMenu()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("Mainmenu");
    }
}
