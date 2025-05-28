using UnityEngine;

public class BallCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            GameManager.instance.UpdateScore(1);
        }
        if(collision.gameObject.tag == "Virus")
        {
            Debug.Log("Collide with virus.");
            Destroy(collision.gameObject);
            HealthManager.Instance.UpdateHealth(-25);
        }
    }
}
