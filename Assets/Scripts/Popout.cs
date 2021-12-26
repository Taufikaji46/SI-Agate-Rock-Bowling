using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Popout : MonoBehaviour
{
    public void yes()
    {
        Debug.Log("keluar");
        Application.Quit();
    }

    public void no()
    {
        SceneManager.LoadScene(0);
    }
}
