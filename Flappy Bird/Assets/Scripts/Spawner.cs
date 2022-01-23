using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    public GameObject pipeRefer;
    public float timeToDestroy;
    public float height;

    float timer;

    void Start()
    {
        GameObject newPipe = Instantiate(pipeRefer);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipeRefer);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, timeToDestroy);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
