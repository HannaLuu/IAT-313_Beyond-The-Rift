using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    private float barMaskWidth;
    private RectTransform barMaskRectTransform;
    private RawImage barRawImage;

    public const int MANA_MAX = 100;
    public float manaAmount;
    public float manaRegenAmount = 10f;
    public float manaCost = 0.05f;
    public float manaAttackCost = 20f;

    public bool SpendMana;

    private void Awake()
    {
        barMaskRectTransform = transform.Find("FillMask").GetComponent<RectTransform>();
        barRawImage = transform.Find("FillMask").Find("Fill").GetComponent<RawImage>();

        barMaskWidth = barMaskRectTransform.sizeDelta.x;

        manaAmount = MANA_MAX;
    }

    private void Update()
    {
        // Debug.Log(manaAmount);
        Rect uvRect = barRawImage.uvRect;
        uvRect.x += 0.2f * Time.deltaTime;
        barRawImage.uvRect = uvRect;

        Vector2 barMaskSizeDelta = barMaskRectTransform.sizeDelta;
        barMaskSizeDelta.x = GetManaNormalized() * barMaskWidth;
        barMaskRectTransform.sizeDelta = barMaskSizeDelta;

        manaAmount += manaRegenAmount * Time.deltaTime;
        manaAmount = Mathf.Clamp(manaAmount, 0f, MANA_MAX);

        if (SpendMana == true)
        {
            SpendMana1(manaCost);
        }
    }

    public bool CanSpendMana(float amount)
    {
        if (manaAmount >= amount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SpendMana1(float amount)
    {
        manaAmount -= amount;
    }

    public float GetManaNormalized()
    {
        return manaAmount / MANA_MAX;
    }
}
