using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void level1()
    {
        Debug.Log("get");
        SceneManager.LoadScene("stage_1");
    }

    public void level2()
    {
        Debug.Log("got");
        SceneManager.LoadScene("stage_2");
    }

    public void level3()
    {
        Debug.Log("gat");
        SceneManager.LoadScene("stage_3");
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
