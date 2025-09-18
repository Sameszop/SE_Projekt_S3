using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject bigRock;

    [SerializeField]
    private GameObject smallRock;

    [SerializeField]
    private float smallSpawnInterval = 3.5f;

    [SerializeField]
    private float bigSpawnInterval= 10f; 

   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnRocks(smallSpawnInterval, smallRock));
        StartCoroutine(spawnRocks(bigSpawnInterval, bigRock));
    }

    private IEnumerator spawnRocks(float interval, GameObject rock)
    {
        yield return new WaitForSeconds(interval);
        GameObject newRock = Instantiate(rock, new Vector2(Random.Range(-5f, 5f), Random.Range(-6f, 6f)),Quaternion.identity);
        StartCoroutine(spawnRocks(interval, rock));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
