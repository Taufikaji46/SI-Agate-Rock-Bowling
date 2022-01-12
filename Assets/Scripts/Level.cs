using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public void level1()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("stage_1");
    }

    public void level2()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("stage_2");
    }

    public void level3()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("stage_3");
    }

    public void back()
    {
        FindObjectOfType<audioManager>().Play("clickButton");
        SceneManager.LoadScene("Mainmenu");
    }
}
