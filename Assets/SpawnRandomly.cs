using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomly : MonoBehaviour
{
    public GameObject spawn;
    public Vector3 spawnPosition;
    public Transform spawnTransform;
    public GameManager manager;
    public float amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnPosition = new Vector3(Random.Range(-2.7f, 2.7f), Random.Range(-4.85f, 4.85f), 1);
    }
    public void RandomSpawn()
    {
        if(manager.TotalClicks >= amount)
        {
            manager.TotalClicks = manager.TotalClicks - amount;
            Instantiate(spawn, spawnPosition, new Quaternion(0, 0, 0, 0));
        }
       
    }
}
