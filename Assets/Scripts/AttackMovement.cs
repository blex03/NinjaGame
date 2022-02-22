using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5.0f;

    private Vector2 direction;

    //Movement
    void moveCharacter(Vector2 direction){
        rb.MovePosition(rb.position + (direction.normalized * speed * Time.fixedDeltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate(){
        moveCharacter(direction);
    }
}
