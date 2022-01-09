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

    [SerializeField]
    public static int totalEnemy = 9;

    public int jumlahMusuh = 9;
    public GameObject UIScore;

    public GameObject[] hearts;

    [SerializeField]
    public GameObject winningLevelUI;

    [SerializeField]
    public GameObject losingLevelUI;

    void Start()
    {
        Time.timeScale = 1f;
        nyawa = nyawaAwal;
        totalEnemy = jumlahMusuh;

    }

    private void Awake()
    {
        totalEnemy = jumlahMusuh;
    }

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < nyawa)
            {
                
            }
            else
            {
                hearts[i].transform.localScale = new Vector3(0f, 0f, 0f);
            }

            if (i < nyawaAwal)
            {
                hearts[i].SetActive(true);
            }
            else
            {
                hearts[i].SetActive(false);
            }
        }

        UIScore.GetComponent<UnityEngine.UI.Text>().text = nyawa.ToString();
        if(totalEnemy <= 0 && nyawa >= 1)
        {
            winningLevel();

        }
            if (nyawa <= 0)
            {
                losingLevel();
                
        }
        //Debug.Log(totalEnemy);

    }

    public void nyawakurang(int health)
    {
        nyawa -= health;
    }
    
    public void winningLevel()
    {
        winningLevelUI.SetActive(true);
        StartPause();
    }

    public void losingLevel()
    {
        losingLevelUI.SetActive(true);
        StartPause();

    }

    public void StartPause()
    {
        // how many seconds to pause the game
        StartCoroutine(PauseGame());
    }
    public IEnumerator PauseGame()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0f;
    }

}
