using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float maxTime = 0.3f;
    private float timer =0;
    public int Score=0;
    void Start()
    {
        GameObject NewPipe = Instantiate(pipe);
    
        NewPipe.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);

    }

    void Update()
    {
        if(timer>maxTime)
        {
            GameObject NewPipe = Instantiate(pipe);
            Score++;
            NewPipe.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
            Destroy(NewPipe,15);
         timer=0;
        
        }
        timer +=Time.deltaTime;
    }
}
