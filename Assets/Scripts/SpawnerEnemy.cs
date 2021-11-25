using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public GameObject capsule;
    public Transform lokasi;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnerenermy());
    }

    IEnumerator spawnerenermy()
    {
        spawn();
        yield return new WaitForSeconds(3); //setiap 3 detik
    }

    public void spawn()
    {
        Instantiate(capsule, new Vector3(lokasi.transform.position.x, lokasi.transform.position.y, lokasi.transform.position.z), Quaternion.identity);
    }
}
