
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
  public  GameManager gm;
  public float ScrollingSpeed = -1.2f;
  public bool GameHasEnded = false;
 public GameObject CanvasScreenEnble;
   public void Start()
    {
        Time.timeScale = 1;
    }

   public void GameOver()
    {
      GameHasEnded = true;
        CanvasScreenEnble.SetActive(true);
       Time.timeScale = 0;
        
    }
}

