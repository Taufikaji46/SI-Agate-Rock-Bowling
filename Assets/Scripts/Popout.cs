using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Popout : MonoBehaviour
{
    public void yes()
    {
        FindObjectOfType<audioManager>().Play("klik");
        Application.Quit();
    }

    public void no()
    {
        FindObjectOfType<audioManager>().Play("klik");
        SceneManager.LoadScene("Mainmenu");
    }
}
