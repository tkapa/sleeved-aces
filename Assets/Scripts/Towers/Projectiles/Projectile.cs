using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private ProjectileScriptableObject projectile;

    private readonly Enemy _enemy;

    public Projectile(Enemy enemy)
    {
        this._enemy = enemy;
    }

    private void Awake()
    {
        var cc = gameObject.AddComponent<CircleCollider2D>();
    }
}
