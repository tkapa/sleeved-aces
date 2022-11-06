using UnityEngine;

// Done with assistance from https://www.youtube.com/watch?v=EwHiMQ3jdHw
public class WaypointManager : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        foreach(Transform t in transform)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(t.position, 0.25f);
        }

        Gizmos.color = Color.red;

        for (int i = 0; i < transform.childCount -1; i++){
            Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);    
        }
    }

    public Transform GetNextWaypoint(Transform currentWaypoint)
    {
        if (currentWaypoint == null)
            return transform.GetChild(0);

        if (currentWaypoint.GetSiblingIndex() < transform.childCount - 1)
            return transform.GetChild(currentWaypoint.GetSiblingIndex() + 1);

        return null;
    }
}
