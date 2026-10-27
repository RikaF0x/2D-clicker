using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MarketScript : MonoBehaviour
{
    [SerializeField] private float price;
    [SerializeField] private float dmg_scale;
    [SerializeField] private float price_scale;
    [SerializeField] private Button upgradeButton;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private InformationObject inf;
    private void Awake()
    {
        upgradeButton.onClick.AddListener(upgrade);
    }

    private void upgrade()
    {
        if (inf.Score >= price)
        {
            inf.damage *= dmg_scale;
            inf.Score -= price;
            price *= price_scale;
            priceText.text = price.ToString();
        }
    }

}
