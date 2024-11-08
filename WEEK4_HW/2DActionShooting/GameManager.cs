using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemyObjs;
    public Transform[] spawnPoints;

    public float maxSpawnDelay;
    public float curSpawnDelay;

    public GameObject player;

    private void Update()
    {
        curSpawnDelay += Time.deltaTime;

        if(curSpawnDelay > maxSpawnDelay)
        {
            SpawnEnemy();
            maxSpawnDelay = Random.Range(0.5f, 3f);
            curSpawnDelay = 0;
        }
    }

    void SpawnEnemy()
    {
        int randomEnemy = Random.Range(0, 3);
        int randomPoint = Random.Range(0, 9);
        GameObject enemy = Instantiate(enemyObjs[randomEnemy],
                    spawnPoints[randomPoint].position,
                    spawnPoints[randomPoint].rotation);
        Rigidbody2D rigid = enemy.GetComponent<Rigidbody2D>();
        Enemy enemyLogic = enemy.GetComponent<Enemy>();
        // prefab 타입은 생성 전엔 생성된 오브젝트 값을 가져올 수 없음. 따라서 Enemy가 생성 된 후에 값을 가져옴. 
        enemyLogic.player = player;
        if(randomPoint == 7 || randomPoint == 8)
        {
            enemy.transform.Rotate(Vector3.back * 90);
            rigid.velocity = new Vector2(enemyLogic.speed * (-1), -1);
        }
        else if (randomPoint == 5 || randomPoint == 6)
        {
            enemy.transform.Rotate(Vector3.forward * 90);
            rigid.velocity = new Vector2(enemyLogic.speed * 1, -1);
        }
        else
        {
            rigid.velocity = new Vector2(0, enemyLogic.speed*(-1));
        }

    }

    public void RespawnPlayer()
    {
        Invoke("RespawnPlayerExe", 2);
        
    }

    public void RespawnPlayerExe()
    {
        player.transform.position = Vector3.down * (4f);
        player.SetActive(true);
    }
}
