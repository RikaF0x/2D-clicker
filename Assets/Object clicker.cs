using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpriteClicker : MonoBehaviour
{
    public int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] private float MaxHealth;
    private float health;
    [SerializeField] public Image HealthBar;
    private float dmg;
    [SerializeField] public InformationObject Inf;
    [SerializeField] private float obj_score;
    
    private void Awake()
    {
        health = MaxHealth;
    }
    public void OnMouseDown()
    {
        Inf.Score++;
        health -= Inf.damage;
        HealthBar.fillAmount = health/MaxHealth;
        gameObject.transform.localScale = Vector3.one * 0.9f;
        if (health <= 0)
        {
            Inf.Score += obj_score;
            health = MaxHealth;
            HealthBar.fillAmount = health/MaxHealth;
        }
    }

    public void OnMouseUp()
    {
        gameObject.transform.localScale = Vector3.one;
    }
}
