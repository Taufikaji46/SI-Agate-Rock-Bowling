using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    public static backgroundMusic bgmusic;

    public void Awake()
    {
        if (bgmusic == null)
        {
            bgmusic = this;
            DontDestroyOnLoad(bgmusic);
        }
            else
            {
                Destroy(gameObject);
            }
    }
    
}
