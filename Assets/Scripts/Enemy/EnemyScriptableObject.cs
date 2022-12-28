using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "ScriptableObjects/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    public int health = 1;
    public float speed = 5f;
    public int damage = 1;
    public bool isDebugMode = false;
}
