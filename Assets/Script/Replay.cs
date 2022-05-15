using UnityEngine.SceneManagement;
using UnityEngine;

public class Replay : MonoBehaviour
{
    // Start is called before the first frame update


   public void StartGame()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
