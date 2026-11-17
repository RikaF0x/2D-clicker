using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class SpriteClicker : MonoBehaviour
{
    public int score;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] private float MaxHealth;
    private float health;
    [SerializeField] public Image HealthBar;
    private float dmg;
    [SerializeField] public InformationObject Inf;
    [SerializeField] private float obj_score;
    [SerializeField] public ParticleSystem myParticle;
    
    private void Awake()
    {
        
        health = MaxHealth;
        HealthBar.fillAmount = 1;
        myParticle.Stop();
    }
    public void OnMouseDown()
    {
        Inf.Score++;
        GetDamage(Inf.damage);
        gameObject.transform.localScale = Vector3.one * 0.9f;
        StartCoroutine(CoroutineDamage());
    }

    public void OnMouseUp()
    {
        gameObject.transform.localScale = Vector3.one;
    }

    private IEnumerator CoroutineDamage()
    {
        
        myParticle.Play();
        yield return new WaitForSeconds(0.5f);
        myParticle.Stop();
    }

    public void GetDamage(float damageAc)
    {
        health -= damageAc;
        HealthBar.fillAmount = health / MaxHealth;
        if (health <= 0)
        {
            Inf.Score += obj_score;
            health = MaxHealth;
            HealthBar.fillAmount = 1;
        }
    }
}
