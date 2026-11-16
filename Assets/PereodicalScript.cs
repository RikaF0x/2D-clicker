using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PereodicalScript : MonoBehaviour
{
    public SpriteClicker spriteClicker;
    [SerializeField] float duration;
    [SerializeField] float damage;
    [SerializeField] Image damageImage;
    private float timer = 0;
    
    private void Update()
    {
        timer += Time.deltaTime;
        damageImage.fillAmount = timer / duration;
        if (timer >= duration)
        {
            spriteClicker.GetDamage(damage);
            timer = 0;
        }
    }
}
