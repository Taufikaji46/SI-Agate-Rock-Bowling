using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Score tambahScore;
    public Transform[] target;
    public PlayerHealth nyawa;
    public int hpEnemy = 2;
    public int nyawaKurangDino = 1;
    public float kecepatan;

    private int current;

    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector3 posisi = Vector3.MoveTowards(transform.position, target[current].position, kecepatan * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(posisi);
        } else current = (current + 1) % target.Length;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "target1")
        {
            nyawa.nyawakurang(nyawaKurangDino);
            //Debug.Log("kena");
            gameObject.SetActive(false);
            PlayerHealth.totalEnemy -= 1;
        }
        if (collision.gameObject.tag == "Player")
        {
             hpEnemy -= 1;
             if (hpEnemy <= 0)
             {
                dead();
                tambahScore.updateScore(1);
             }
             //Debug.Log("ancur");
        }
        else if (collision.gameObject.tag == "Player2")
        {
            hpEnemy -= 2;
            if (hpEnemy <= 0)
            {
                dead();
                tambahScore.updateScore(1);
            }
            //Debug.Log("ancur");
        }
        else if (collision.gameObject.tag == "Player3")
        {
            hpEnemy -= 3;
            if (hpEnemy <= 0)
            {
                dead();
                tambahScore.updateScore(1);
             }
            //Debug.Log("ancur");
        }
    }

    void dead()
    {
        gameObject.SetActive(false);
        PlayerHealth.totalEnemy -= 1;
    }
}
