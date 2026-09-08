using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float spawnBallInterval = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnBallInterval = Random.Range(3, 5);
        Invoke(nameof(SpawnRandomBall), spawnBallInterval);
    }

    private void Update()
    {
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        var ball = ballPrefabs[Random.Range(0, ballPrefabs.Length)];

        // instantiate ball at random spawn location
        Instantiate(ball, spawnPos, ball.transform.rotation);

        // Invoke next call
        Invoke(nameof(SpawnRandomBall), spawnBallInterval);
    }

}
