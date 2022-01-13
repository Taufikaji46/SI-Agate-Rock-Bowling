using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    public static backgroundMusic bgmusic;

    public void Awake()
    {
        GameObject musik = GameObject.Find("Background Music");
        if (bgmusic == null)
        {
            bgmusic = this;
            DontDestroyOnLoad(bgmusic);
        }
            else
            {
                Destroy(gameObject);
            }
        if (musik != null)
        {
            AudioSource sourceA = musik.GetComponent<AudioSource>();
            sourceA.Play();
        }
    }
    
}
