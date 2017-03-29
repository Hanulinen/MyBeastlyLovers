using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Slot : MonoBehaviour, IPointerClickHandler {

    private Stack<Items> items;
    public Text stackText;
    public Sprite emptyS;

    public bool GetisEmpty()
    {
        return items.Count == 0;
    }

    public bool GetIsAvailable()
    {
        return GetCurrentItem().maxSize > items.Count;
    }

    public Items GetCurrentItem()
    {
        return items.Peek();
    }

    void Start () {
        //Stacks items in one slot
        items = new Stack<Items>();

        RectTransform slotRect = GetComponent<RectTransform>();
        RectTransform txtRect = stackText.GetComponent<RectTransform>();
        //Text to indicate haw many items are stacked in one slot
        int textScale = (int)(slotRect.sizeDelta.x * 0.60);

        stackText.resizeTextMaxSize = textScale;
        stackText.resizeTextMinSize = textScale;

        txtRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotRect.sizeDelta.y);
        txtRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotRect.sizeDelta.x);

    }


    public void AddItem(Items item)
    {
        Sprite itemS = item.itemSprite;
        //Add to stack
        items.Push(item);
        //Adding to textfield
        if (items.Count > 1)
        {
            stackText.text = items.Count.ToString();
        }

        ChangeSprite(itemS);
    }


    
    private void ChangeSprite(Sprite newSprite)
    {
        GetComponent<Image>().sprite = newSprite;
    }
    
    private void UseItem()
    {
        if (GetisEmpty())
        {
            items.Pop().Use();
            // if item count bigger than 1 return item count otherwise return null
            stackText.text = items.Count > 1 ? items.Count.ToString() : string.Empty;

            if (GetisEmpty())
            {
                ChangeSprite(emptyS);
                PlayerInventory.EmptySlot++;
            }

        }

    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            UseItem();
        }
    }
}
