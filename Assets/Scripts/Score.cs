using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int currentscore = 99;
    public GameObject panelScore;

    public void Start()
    {
        currentscore = 0;
        updateScore(0);
    }
    public void updateScore(int score)
    {
        currentscore += score;
        panelScore.GetComponent<UnityEngine.UI.Text>().text = currentscore.ToString();
    }
}
