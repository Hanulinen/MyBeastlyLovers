using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

    private RectTransform inventoryRect;

    private float invWidth, invHight;
    public int slots;
    public int rows;

    //Padding between slots
    public float slotPadL, slotPadTop;

    public float slotSize;

    public GameObject slotPrefab;

    private List<GameObject> allSlots;

    private static int emptySlot;

    public static int EmptySlot
    {
        get
        {
            return emptySlot;
        }
        set
        {
            emptySlot = value;
        }
    }


	void Awake () {

        CreateLayout();
	}

    private void CreateLayout ()
    {
        allSlots = new List<GameObject>();

        emptySlot = slots;

        //Calculate the size of inventorys background image
        invWidth = (slots / rows) * (slotSize + slotPadL) + slotPadL;
        invHight = rows * (slotSize + slotPadTop) + slotPadTop;
 
        inventoryRect = GetComponent<RectTransform>();

        inventoryRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, invHight);
        inventoryRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, invWidth);

        int columns = slots / rows;

        //Creates the inventoryslots
        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < columns; x++)
            { 
                GameObject newSlot = Instantiate(slotPrefab);

                RectTransform slotRect = newSlot.GetComponent<RectTransform>();

                newSlot.name = "Slot";

                newSlot.transform.SetParent(transform.parent);

                slotRect.localPosition = inventoryRect.localPosition + new Vector3(slotPadL * (x + 1) + (slotSize * x), -slotPadTop * (y + 1) - (slotSize * y));
                slotRect.localScale = new Vector3(1,1,1);

                slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotSize);
                slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotSize);

                allSlots.Add(newSlot);
            }
        }
    }

    public bool AddItem(Items item)
    {
        if (item.maxSize == 1)
        {
            PlaceEmpty(item);

            return true;
        }
        else 
            foreach (GameObject slot in allSlots)
            {
                Slot tmp = slot.GetComponent<Slot>();

                if (!tmp.GetisEmpty())
                {
                    if (tmp.GetCurrentItem().type == item.type && tmp.GetIsAvailable())
                    {
                        tmp.AddItem(item);
                        return true;
                    }
                }
                
            }
        if (emptySlot > 0)
        {
            PlaceEmpty(item);
            return true;

        }
        return false;
    }


    public bool PlaceEmpty(Items item)
    {
        if (emptySlot > 0)
        {
            foreach (GameObject slot in allSlots)
            {
                Slot tmp = slot.GetComponent<Slot>();

                if (tmp.GetisEmpty())
                {
                    tmp.AddItem(item);
                    emptySlot--;
                    print(item.name + " " + item.type);
                    return true;
                }
            }
        }

        return false;
    }


}
