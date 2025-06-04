using UnityEngine;

namespace RunnerGame
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody playerRB;
        public float turnSpeed = 3f, forwardSpeed = 3f, jumpForce = 10f;
        [SerializeField]float turnInput = 0, forwardInput = 0, jumpInput=0;
        // Update is called once per frame

        private void Start()
        {
            playerRB = GetComponent<Rigidbody>();
        }
        private void FixedUpdate()
        {
            if (RunnerGame.GameController.instance.isMove)
            {
                jumpInput = Input.GetAxis("Jump");
                if (jumpInput==1)
                {
                    playerRB.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
                }
            }
        }
        void Update()
        {
            if (RunnerGame.GameController.instance.isMove)
            {
                forwardInput = Input.GetAxis("Vertical");
                turnInput = Input.GetAxis("Horizontal");

                transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
                transform.Translate(Vector3.right * Time.deltaTime * turnInput * turnSpeed);

                Vector3 playerPos = transform.position;
                float xDir = Mathf.Clamp(playerPos.x, -1.8f, 1.8f);
                playerPos.x = xDir;
                transform.position = playerPos;
                
            }
        }
    }
}