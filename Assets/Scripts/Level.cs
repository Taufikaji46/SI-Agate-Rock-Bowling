using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void level1()
    {
        Debug.Log("get");
        SceneManager.LoadScene(3);
    }

    public void level2()
    {
        Debug.Log("got");
        SceneManager.LoadScene(4);
    }

    public void level3()
    {
        Debug.Log("gat");
        SceneManager.LoadScene(5);
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
