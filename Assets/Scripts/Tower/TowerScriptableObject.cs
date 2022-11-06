using UnityEngine;

[CreateAssetMenu(fileName = "New Tower", menuName = "ScriptableObjects/Tower")]
public class TowerScriptableObject : ScriptableObject
{
    public int attack = 1;
    public float attackSpeed = 10f;
    public float range = 10f;
}
