using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ItemType
{
    KeyItem,
    NormalItem
};


public class Items : MonoBehaviour {

    public ItemType type;
    public bool combinable;

    public int maxSize;

    private SpriteRenderer spritere;
    public Sprite itemSprite;

    void Start()
    {
        spritere = gameObject.GetComponent<SpriteRenderer>();
        itemSprite = this.spritere.sprite;
    }



    public void Use()
    {
        switch (type)
        {
            case ItemType.KeyItem:
                Debug.Log("I'm Keyitem");
                break;
            case ItemType.NormalItem:
                Debug.Log("I'm Normalitem");
                break;
            default:
                break;
        }

    }

}
