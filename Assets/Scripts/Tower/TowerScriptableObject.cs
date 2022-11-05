using UnityEngine;

public class TowerScriptableObject : ScriptableObject
{
    public int attack { get; set; } = 1;
    public float attackSpeed { get; set; } = 10f;
    public float range { get; set; } = 10f;
}
