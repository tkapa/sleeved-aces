using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthScriptableObject : ScriptableObject
{
    [SerializeField]
    private int maxHealth { get; set; } = 100;

    public int health { get; set; } = 100;

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
