using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
     public float speed;
    public GameManager gm;
    private Rigidbody2D rb2d;
    public float RestartDelay =2f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(gm.ScrollingSpeed,0);
       
    }

    // Update is called once per frame
    void Update()
    {
        
       transform.position += Vector3.left * speed * Time.deltaTime;
    }
}


