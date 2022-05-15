using UnityEngine;

public class FlyingBird : MonoBehaviour
{
    //public GameManager gameManager;
    public  FlyingBird fg;
   public float velocity =1f;
   public Rigidbody2D rb;
   public float scrollSpeed = -1.5f;
  
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    if(Input.GetMouseButton(0))   
    {
       rb.velocity = Vector2.up * velocity;
    } 
 
    }
    
}
