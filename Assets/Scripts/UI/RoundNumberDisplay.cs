using TMPro;
using UnityEngine;

public class RoundNumberDisplay : MonoBehaviour
{
    [SerializeField]
    private TMP_Text roundText;

    [SerializeField]
    private LevelScriptableObject level;

    // Start is called before the first frame update
    private void Start()
    {
        ChangeRoundValue(level.round);
    }

    private void OnEnable()
    {
        level.roundEndEvent.AddListener(ChangeRoundValue);
    }

    private void OnDisable()
    {
        level.roundEndEvent.AddListener(ChangeRoundValue);
    }

    private void ChangeRoundValue(int round)
    {
        roundText.text = round.ToString();
    }
}
