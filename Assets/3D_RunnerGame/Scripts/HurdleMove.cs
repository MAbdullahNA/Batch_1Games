using UnityEngine;

namespace RunnerGame
{public class HurdleMove : MonoBehaviour
    {
        //public AnimationType _AnimationType;
        public Vector3[] positions;
        int posNum = 0;
        [SerializeField] float moveSpeed = 2f;

        private void Start()
        {

        }
        // Update is called once per frame
        void Update()
        {
            Vector3 movePosition = Vector3.MoveTowards(transform.localPosition, positions[posNum], moveSpeed * Time.deltaTime);
            transform.localPosition = movePosition;
            if (transform.localPosition == positions[posNum])
            {
                posNum++;
                if (posNum >= positions.Length)
                {
                    posNum = 0;
                }
            }
        }
    }
}
public enum AnimationType
{
    Rotate,
    Move
}