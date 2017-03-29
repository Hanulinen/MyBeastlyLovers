using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public PlayerInventory inventory;

    [SerializeField]
    int MovementSpeed;

    Rigidbody2D rbody;
    Animator anim;
   
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();   
	}
	

	void FixedUpdate () {

        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        HandleMovement(movement_vector);
        
	}


    private void HandleMovement(Vector2 movement_vector)
    {
        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("iswalking", true);
            anim.SetFloat("input_x", movement_vector.x);
            anim.SetFloat("input_y", movement_vector.y);
        }
        else
        {
            anim.SetBool("iswalking", false);
        }
        rbody.velocity = new Vector2(movement_vector.x * MovementSpeed, movement_vector.y * MovementSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Item")
        {
            inventory.AddItem(other.GetComponent<Items>());
        }

    }


}