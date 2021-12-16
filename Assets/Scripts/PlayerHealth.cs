using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public static int nyawa;
    public int nyawaAwal = 3;
    
    public static int totalEnemy = 9;
    public GameObject UIScore;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;

    void Start()
    {
        nyawa = nyawaAwal;
        totalEnemy = 9;
    }

    private void Update()
    {
        //Debug.Log(totalEnemy);
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < nyawa)
            {
                hearts[i].sprite = fullHearts;
            }
            else
            {
                hearts[i].sprite = emptyHearts;
            }

            if (i < nyawaAwal)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        UIScore.GetComponent<UnityEngine.UI.Text>().text = nyawa.ToString();
        if(totalEnemy <= 0 && nyawa >= 1)
        {
            SceneManager.LoadScene("Winning");
        }
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
        if (nyawa <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        //UIScore.GetComponent<UnityEngine.UI.Text>().text = nyawa.ToString();
        // Debug.Log(UIScore.GetComponent<UnityEngine.UI.Text>().text);
    }
    
    
    private void WinningGame(int totalEnemy)
    {
        SceneManager.LoadScene("Win");
    }

}
