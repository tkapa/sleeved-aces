using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Player Health", menuName = "ScriptableObjects/PlayerHealth")]
public class PlayerHealthScriptableObject : ScriptableObject
{
    [SerializeField]
    private int maxHealth = 100;

    [SerializeField]
    public int health = 100;

    [System.NonSerialized]
    public UnityEvent<int> healthChangeEvent;

    private void OnEnable()
    {
        health = maxHealth;

        if( healthChangeEvent == null)
            healthChangeEvent = new UnityEvent<int>();
    }

    public void DecreaseHealth(int amount)
    {
        health -= amount;
        healthChangeEvent.Invoke(health);
    }
}
