using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score=0;
    [SerializeField] Text scoreText;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void UpdateScore(int value)
    {
        score += value;
        Debug.Log("Score: "+score);
        scoreText.text = score.ToString();
    }
}
