using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform target;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}
