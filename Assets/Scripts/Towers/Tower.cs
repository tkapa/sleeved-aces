using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField]
    private TowerScriptableObject tower;

    private TowerFiring _towerFiring;

    private void Awake()
    {
        _towerFiring = gameObject.AddComponent<TowerFiring>();
        UpdateTowerFiring();
    }

    private void UpdateTowerFiring()
    {
        _towerFiring.attackSpeed = tower.attackSpeed;
        _towerFiring.range = tower.range;
    }
}
