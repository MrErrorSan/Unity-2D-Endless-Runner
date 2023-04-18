using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawnmanager : MonoBehaviour
{
    public GameObject[] obstaclesPrefab;
    private int obstacleIndex;
    public float xRangeToDestroy = 5;
    private Vector3 spawnVector;
    public float xRange=-32;
    public static Spawnmanager instance;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", 1f, 2f);

    }
    private void Awake()
    {
        instance = this;
    }
    public void stopSpawning()
    {
        CancelInvoke("SpawnObstacles");
    }
    void Update()
    {

    }
    void SpawnObstacles()
    {
        obstacleIndex = Random.Range(0, obstaclesPrefab.Length);
        spawnVector = new Vector3(xRange, 0, 0);
        Instantiate(obstaclesPrefab[obstacleIndex], spawnVector, obstaclesPrefab[obstacleIndex].transform.rotation);

    }
    void outOfRange()
    {

    }

}
