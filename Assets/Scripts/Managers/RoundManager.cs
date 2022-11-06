using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    [SerializeField]
    private LevelScriptableObject level;

    public void StartNextRound()
    {
        level.RoundStart();
    }

    public void EndRound()
    {
        level.RoundEnd();
    }
}
