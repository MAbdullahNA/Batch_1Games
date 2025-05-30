using UnityEngine;

namespace RunnerGame
{
    public class PlayerController : MonoBehaviour
    {
        public float turnSpeed = 3f, forwardSpeed = 3f;
        float moveDirection = 0, forward = 0;
        // Update is called once per frame
        void Update()
        {
            if (RunnerGame.GameController.instance.isMove)
            {
                moveDirection = Input.GetAxis("Horizontal");
                forward = Input.GetAxis("Vertical");

                transform.Translate(Vector3.right * Time.deltaTime * moveDirection * turnSpeed);
                transform.Translate(Vector3.forward * Time.deltaTime * forward * forwardSpeed);
            }
        }
    }
}