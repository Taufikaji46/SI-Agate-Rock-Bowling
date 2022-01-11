using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void selection()
    {
        FindObjectOfType<audioManager>().Play("sound");
        SceneManager.LoadScene("SelectionLevel");
        Debug.Log("1");
    }

    public void keluar()
    {
        FindObjectOfType<audioManager>().Play("sound");
        SceneManager.LoadScene("Mainmenu 1");
        Debug.Log("2");
    }
}
