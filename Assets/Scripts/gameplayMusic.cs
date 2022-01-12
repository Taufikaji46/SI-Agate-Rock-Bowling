using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplayMusic : MonoBehaviour
{
    void Start()
    {
        GameObject musik = GameObject.Find("Audio Source");
        if (musik != null)
        {
            AudioSource sourceA = musik.GetComponent<AudioSource>();
            sourceA.Stop();
        }
    }

}
