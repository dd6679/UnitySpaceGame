using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Shot()
    {
        Transform ac = transform.GetChild(i);

        GameObject bullet = Instantiate(bulletPrefab, new Vector3(0, -1.66f, 3.84f), transform.rotation);

        target = ac.transform;
        bullet.transform.LookAt(target);

        i += 1;
   
    }
}