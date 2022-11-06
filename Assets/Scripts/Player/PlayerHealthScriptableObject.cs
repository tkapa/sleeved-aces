using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Player Health", menuName = "ScriptableObjects/PlayerHealth")]
public class PlayerHealthScriptableObject : ScriptableObject
{
    [SerializeField]
    private int MaxHealth = 100;

    [SerializeField]
    public int Health = 100;

    [System.NonSerialized]
    public UnityEvent<int> healthChangeEvent;

    private void OnEnable()
    {
        Health = MaxHealth;

        if( healthChangeEvent == null)
            healthChangeEvent = new UnityEvent<int>();
    }

    public void DecreaseHealth(int amount)
    {
        Health -= amount;
        healthChangeEvent.Invoke(Health);
    }
}
