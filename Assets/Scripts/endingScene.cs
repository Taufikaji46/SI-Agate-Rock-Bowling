using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingScene : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
    }

    public void backToMenu()
    {
        
        SceneManager.LoadScene("Mainmenu");
    }
}
