using UnityEditor.SceneManagement;
using UnityEngine;

public class TrackEnd : MonoBehaviour
{
    [SerializeField]
    private PlayerHealthScriptableObject playerHealth;

    private void Awake()
    {
        var bc = gameObject.AddComponent<BoxCollider2D>();
        bc.isTrigger = true;
        bc.size = new Vector2(1.0f, 1.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Track end trigger hit");
        playerHealth.DecreaseHealth(1);
    }
}
