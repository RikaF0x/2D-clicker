using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPereodical : MonoBehaviour
{
    [SerializeField] private InformationObject inf;
    [SerializeField] private Button buyButton;
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject parentObj;
    [SerializeField] private float price;
    [SerializeField] private float price_scale;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private GameObject target;
    private void Awake()
    {
        buyButton.onClick.AddListener(Spawn);
    }

    private void Spawn()
    {
        if (inf.Score >= price)
        {
            GameObject newOb = Instantiate(prefab, parentObj.transform);
            if (newOb.TryGetComponent(out PereodicalScript srenderer) && target.TryGetComponent(out SpriteClicker sprite))
            {
                srenderer.GetComponent<PereodicalScript>().spriteClicker = sprite;
            }
            inf.Score -= price;
            price *= price_scale;
            priceText.text = price.ToString();
        }
    }
}
