using TMPro;
using UnityEngine;

public class InformationObject : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public float damage;
    private float score;
    public float Score
    {
        get => score;
        set
        {
            score = value;
            scoreText.text = score.ToString("0.00");
        }
    }

    private void Awake()
    {
        Score = 0;
    }
}
