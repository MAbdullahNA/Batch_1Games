using UnityEngine;

namespace RunnerGame
{
    public class GameController : MonoBehaviour
    {
        public static GameController instance;
        public int score = 0;
        public bool isMove = true;

        private void Start()
        {
            if (instance == null)
            {
                instance = this;
            }
        }
    }
}