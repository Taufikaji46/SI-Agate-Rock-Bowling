using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Score tambahScore;
    public Transform[] target;
    public float kecepatan;
    public int scoreValue = 10;

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
            Destroy(gameObject);
            Debug.Log("ancur");
        }
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
                tambahScore.updateScore(1);
                Debug.Log("ancur");
            }
    }
}
