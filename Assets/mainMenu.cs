using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void selection()
    {
        SceneManager.LoadScene(2);
    }

    public void keluar()
    {
        SceneManager.LoadScene(1);
    }
}
