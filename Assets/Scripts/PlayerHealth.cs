using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int nyawa;
    public GameObject UIScore;

    void Start()
    {
        nyawa = 10;
        
    }

    private void Update()
    {
        UIScore.GetComponent<UnityEngine.UI.Text>().text = nyawa.ToString();
    }

    /*public void nyawakurang(int health)
    {
        nyawa -= health;
        Debug.Log(health); 
        Debug.Log(nyawa);
        UIScore.GetComponent<UnityEngine.UI.Text>().text = nyawa.ToString();
    }*/

    public void nyawakurang(int health)
    {
        nyawa -= health;

        //UIScore.GetComponent<UnityEngine.UI.Text>().text = nyawa.ToString();
        // Debug.Log(UIScore.GetComponent<UnityEngine.UI.Text>().text);
    }
}
