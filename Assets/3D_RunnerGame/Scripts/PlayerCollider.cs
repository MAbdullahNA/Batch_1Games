using UnityEngine;

namespace RunnerGame
{
    public class PlayerCollider : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Coin")
            {
                Destroy(other.gameObject);
                RunnerGame.GameController.instance.UpdateScore(1);
                Debug.Log("Score: " + GameController.instance.score);
            }
            if(other.gameObject.tag =="Hurdle")
            {
                RunnerGame.GameController.instance.isMove = false;
            }
        }
    }
}