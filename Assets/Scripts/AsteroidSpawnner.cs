using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnner : MonoBehaviour
{
    public GameObject asteroid;
    public float lowerlimit = 20.0f;
    public float upperlimit = 281.0f;
    public float interval;
    public float intervalTimer;

    void Start()
    {
        float intervalTimer = Time.time;
        float interval = Random.Range(0.5f, 2.1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //spwan a new
        //pos b/w 20 and 280
        if (intervalTimer + interval <= Time.time)
        {
            Vector3 asteroidPosition = new Vector3(Random.Range(lowerlimit, upperlimit), 700.0f, 0.0f);
            Instantiate(asteroid, asteroidPosition, Quaternion.identity);
            intervalTimer = Time.time;
            interval = Random.Range(0.5f, 2.0f);
        }

    }
}
