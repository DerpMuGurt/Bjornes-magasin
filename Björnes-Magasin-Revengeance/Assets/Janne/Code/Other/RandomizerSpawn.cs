using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizerSpawn : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4;
    public GameObject canvasObject;


    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int whatToSpawn;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 6);

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity, transform.parent);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity, transform.parent);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity, transform.parent);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity, transform.parent);
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }
    }
}
