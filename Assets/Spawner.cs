using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   // public GameObject SpawnObject;
    public GameObject[] SpawnItems;
    private float CurrentSpawn;

    float PositionX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentSpawn = Random.Range(0, 4);
    }

    void SpawnObjects()
    {
        PositionX = Random.Range(5f, -5f);
        this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);

        if (CurrentSpawn == 0)
        {
            Instantiate(SpawnItems[0], transform.position, transform.rotation);
        }

        if (CurrentSpawn == 1)
        {
            Instantiate(SpawnItems[1], transform.position, transform.rotation);
        }

        if (CurrentSpawn == 2)
        {
            Instantiate(SpawnItems[2], transform.position, transform.rotation);
        }

        if (CurrentSpawn == 3)
        {
            Instantiate(SpawnItems[3], transform.position, transform.rotation);
        }

    }
}
