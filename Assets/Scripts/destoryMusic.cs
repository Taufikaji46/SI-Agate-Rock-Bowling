using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryMusic : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        GameObject musik = GameObject.Find("Background Music");
        if (musik != null)
        {
            AudioSource sourceA = musik.GetComponent<AudioSource>();
            sourceA.Stop();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
