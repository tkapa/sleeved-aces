using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Level", menuName = "ScriptableObjects/Level")]
public class LevelScriptableObject : ScriptableObject
{
    public int round = 1;

    public WaypointManager waypointManager;
    public Material levelMap;

    [System.NonSerialized]
    public UnityEvent<int> roundStartEvent;
    [System.NonSerialized]
    public UnityEvent<int> roundEndEvent;

    private void OnEnable()
    {
        if(roundStartEvent == null)
            roundStartEvent = new UnityEvent<int>();

        if(roundEndEvent == null)
            roundEndEvent = new UnityEvent<int>();
    }

    public void RoundStart()
    {
        roundStartEvent.Invoke(round);
    }

    public void RoundEnd()
    {
        round++;

        roundEndEvent.Invoke(round);
    }
}
