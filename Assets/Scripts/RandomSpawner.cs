using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVehicle", 5.0f, 2.0f);
    }

    void SpawnVehicle()
    {
        int dieRoll = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[dieRoll]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
