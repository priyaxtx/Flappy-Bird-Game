
using UnityEngine;

public class ScreenBoundary : MonoBehaviour
{
private Vector2 ScreenBounds;
    void Start()
    {
        ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
    }
}
