using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 0.0f;

    private Transform currentWaypoint;
    private float distanceThreshold = 0.1f;
    private WaypointManager waypointManager;

    private void Awake()
    {
        waypointManager = FindObjectOfType<WaypointManager>();
        currentWaypoint = waypointManager.GetNextWaypoint(null);
    }

    void FixedUpdate()
    {
        if (currentWaypoint == null)
        {
            TriggerDespawn();
            return;
        }
            

        transform.position = Vector2.MoveTowards(transform.position, currentWaypoint.position, movementSpeed * Time.fixedDeltaTime);

        if (Vector2.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
            currentWaypoint = waypointManager.GetNextWaypoint(currentWaypoint);
    }

    // Enemy has reached the end of the track, they should despawn.
    private void TriggerDespawn()
    {
        Destroy(gameObject);
    }
}
