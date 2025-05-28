using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;
    [SerializeField] Slider healthSlider;
    int health = 100;


    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void UpdateHealth(int value)
    {
        health += value;
        healthSlider.value = health;
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
