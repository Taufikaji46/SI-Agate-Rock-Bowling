using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public Score score;

    [SerializeField]
    private GameObject lokasi;

    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float EnemyInterval = 3.5f;

    [SerializeField]
    private int maxEnemyCount = 1;

    private int enemyCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(EnemyInterval, enemyPrefab));
    }

    void Update()
    {
        if (enemyCount == maxEnemyCount)
        {
            StopAllCoroutines();
        }
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(lokasi.transform.position.x, lokasi.transform.position.y, lokasi.transform.position.z), Quaternion.identity);
        enemyCount += 1;
        newEnemy.GetComponent<EnemyMovement>().tambahScore = score;
        StartCoroutine(spawnEnemy(interval, enemy));

    }
}