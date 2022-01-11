using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundManager : MonoBehaviour
{
    [SerializeField] Image soundOnicon;
    [SerializeField] Image soundOfficon;

    private bool muted = false;
    

    void Start()
    {
        if(PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Save();
        }
            else
            {
                Load();
            }
        updatebutton();
        AudioListener.pause = muted;

    }
   
    public void onButtonPress()
    {
        
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        } 
            else
            {
                muted = false;
                AudioListener.pause = false;
            }

        FindObjectOfType<audioManager>().Play("sound");
        Save();
        updatebutton();
    }

    private void updatebutton()
    {
        if(muted == false)
        {
            soundOnicon.enabled = true;
            soundOfficon.enabled = false;
            Debug.Log("lihat");
        }
        else
        {
            soundOnicon.enabled = false;
            soundOfficon.enabled = true;
            Debug.Log("engga");
        }
    }
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
        Debug.Log("loaded");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
        Debug.Log("save");
    }

   

    /*public static soundManager instance { get; set; }

    private void Awake()
    {
        DontDestroyOnLoad(this);
        
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }*/


}
