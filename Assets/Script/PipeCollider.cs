
using UnityEngine;

public class PipeCollider : MonoBehaviour
{
    public GameObject CanvasScreenEnble;
     public FlyingBird playerMovement; 
    
public void OnCollisionEnter2D(Collision2D colliderInfo)
{   

if(colliderInfo.collider.tag == "Obstacle")
{
    playerMovement.enabled = false;
        CanvasScreenEnble.SetActive(true);
        Time.timeScale = 0;
}
}
}
