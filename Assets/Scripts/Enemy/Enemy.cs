using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private EnemyScriptableObject enemy;

    private void Awake()
    {
        if (!enemy.isDebugMode)
        {
            var em = gameObject.AddComponent<EnemyMovement>();
            em.movementSpeed = enemy.speed;
        }

        var rb = gameObject.AddComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;

        var cc = gameObject.AddComponent<CircleCollider2D>();
    }
}
