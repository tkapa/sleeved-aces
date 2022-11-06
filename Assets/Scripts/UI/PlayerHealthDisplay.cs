using TMPro;
using UnityEngine;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField]
    private TMP_Text healthText;

    [SerializeField]
    private PlayerHealthScriptableObject playerHealth;

    // Start is called before the first frame update
    private void Start()
    {
        ChangeHealthValue(playerHealth.health);
    }

    private void OnEnable()
    {
        playerHealth.healthChangeEvent.AddListener(ChangeHealthValue);
    }

    private void OnDisable()
    {
        playerHealth.healthChangeEvent.AddListener(ChangeHealthValue);
    }

    private void ChangeHealthValue(int health)
    {
        healthText.text = health.ToString();
    }
}
