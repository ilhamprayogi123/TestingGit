using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private LocalizedString localStringScore;
    [SerializeField] private TextMeshProUGUI textComp;

    private int score;

    private void OnEnable()
    {
        localStringScore.Arguments = new object[] { score };
        localStringScore.StringChanged += UpdateText;
    }

    private void OnDisable()
    {
        localStringScore.StringChanged -= UpdateText;
    }

    private void UpdateText(string value)
    {
        textComp.text = value;
    }

    public void increasingScore()
    {
        score++;
        localStringScore.Arguments[0] = score;
        localStringScore.RefreshString();
    }
}
