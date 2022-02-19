using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody2D rb;
    public Camera cam;

    public float speed = 5.0f;

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    private Vector2 direction;
    private Vector2 mousePos;

    //Movement
    void moveCharacter(Vector2 direction){
        rb.MovePosition(rb.position + (direction.normalized * speed * Time.fixedDeltaTime));
    }
    
    //Direction
    private void playerDirection(){
        Vector2 lookDir = mousePos - rb.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;    

        //S
        if (angle >= -112.5 && angle <= -67.5) {
            spriteRenderer.sprite = spriteArray[0]; 
        }

        //SW
        if (angle > -157.5 && angle < -112.5) {
            spriteRenderer.sprite = spriteArray[1]; 
        }

        //W
        if (angle >= 157.5 || angle <= -157.5) {
            spriteRenderer.sprite = spriteArray[2]; 
        }

        //NW
        if (angle < 157.5 && angle > 112.5) {
            spriteRenderer.sprite = spriteArray[3]; 
        }
        //N
        if (angle <= 112.5 && angle >= 67.5) {
            spriteRenderer.sprite = spriteArray[4]; 
        }

        //NE
        if (angle < 67.5  && angle > 22.5) {
            spriteRenderer.sprite = spriteArray[5];
        }

        //E
        if (angle <= 22.5 &&  angle >= -22.5)  {
            spriteRenderer.sprite = spriteArray[6]; 
        }

        //SE
        if (angle > -67.5  && angle < -22.5) {
            spriteRenderer.sprite = spriteArray[7]; 
        }
        
    }

    void Update () {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate(){
        moveCharacter(direction);
        playerDirection();
    }

    
}