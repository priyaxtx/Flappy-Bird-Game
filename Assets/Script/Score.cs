using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
   // public Transform Player;
    public PipeSpawner pipeSpawner;
    public  TextMeshProUGUI score;    
    void Update()
    {
        score.text = pipeSpawner.Score.ToString();   
    }
}

