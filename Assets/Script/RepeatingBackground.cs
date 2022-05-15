using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
  
    private float horizontalLength;
    // Start is called before the first frame update
    void Start()
    {
        horizontalLength = 8f;
    }

    void Update()
    {
   if(transform.position.x < -horizontalLength)
   {
       RepositionBackground();
   }
    }
    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(horizontalLength*2f,0);
        transform.position =(Vector2)transform.position + groundOffset;
    }
}
