using UnityEngine;
using UnityEngine.UI;

namespace RunnerGame
{
    public class GameController : MonoBehaviour
    {
        public static GameController instance;
        public int score = 0;
        public bool isMove = false;
        public GameObject startPanel;

        public Text scoreText;

        private void Start()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void UpdateScore(int value)
        {
            score += value;
            scoreText.text = score.ToString();
        }
        public void PlayGame()
        {
            isMove = true;
            startPanel.SetActive(false);
        }
    }
}