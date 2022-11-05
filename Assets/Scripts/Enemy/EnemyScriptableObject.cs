using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "ScriptableObjects/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    public int health { get; set; } = 1;
    public float speed { get; set; } = 5f;
    public int damage { get; set; } = 1;
}
