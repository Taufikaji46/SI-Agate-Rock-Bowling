using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class temp2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1f;
        Invoke("loading", 1.0f);
    }

    void loading()
    {
        SceneManager.LoadScene("stage_3");
    }
}
