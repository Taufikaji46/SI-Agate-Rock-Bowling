using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void selection()
    {
        SceneManager.LoadScene("SelectionLevel");
    }

    public void keluar()
    {
        Application.Quit();
        Debug.Log("keluar");
    }
}
