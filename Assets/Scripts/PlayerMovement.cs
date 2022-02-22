using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody2D rb;
    public Camera cam;
    public Transform attackPoint;

    public float speed = 5.0f;

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    private Vector2 direction;
    private Vector2 mousePos;

    Vector2 playerPos;
    Vector2 attackPos; 
    

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
            attackPoint.transform.position = new Vector2(playerPos.x, playerPos.y - 0.9f);
            attackPoint.transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        //SW
        if (angle > -157.5 && angle < -112.5) {
            spriteRenderer.sprite = spriteArray[1]; 
            attackPoint.transform.position = new Vector2(playerPos.x - 0.636f, playerPos.y - 0.636f);
            attackPoint.transform.rotation = Quaternion.Euler(0, 0, 55);
        }

        //W
        if (angle >= 157.5 || angle <= -157.5) {
            spriteRenderer.sprite = spriteArray[2];
            attackPoint.transform.position = new Vector2(playerPos.x - 0.9f, playerPos.y);
            attackPoint.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //NW
        if (angle < 157.5 && angle > 112.5) {
            spriteRenderer.sprite = spriteArray[3]; 
            attackPoint.transform.position = new Vector2(playerPos.x - 0.636f, playerPos.y + 0.636f);
            attackPoint.transform.rotation = Quaternion.Euler(0, 0, 315);
            
        }
        //N
        if (angle <= 112.5 && angle >= 67.5) {
            spriteRenderer.sprite = spriteArray[4]; 
            attackPoint.transform.position = new Vector2(playerPos.x, playerPos.y + 0.9f);
            attackPoint.transform.rotation = Quaternion.Euler(0, 180, 270);
        }

        //NE
        if (angle < 67.5  && angle > 22.5) {
            spriteRenderer.sprite = spriteArray[5];
            attackPoint.transform.position = new Vector2(playerPos.x + 0.636f, playerPos.y + 0.636f);
            attackPoint.transform.rotation = Quaternion.Euler(0, 180, 315);
        }

        //E
        if (angle <= 22.5 &&  angle >= -22.5)  {
            spriteRenderer.sprite = spriteArray[6];
            attackPoint.transform.position = new Vector2(playerPos.x + 0.9f, playerPos.y);
            attackPoint.transform.rotation = Quaternion.Euler(0, 180, 0);
            
        }

        //SE
        if (angle > -67.5  && angle < -22.5) {
            spriteRenderer.sprite = spriteArray[7]; 
            attackPoint.transform.position = new Vector2(playerPos.x + 0.636f, playerPos.y - 0.636f);
            attackPoint.transform.rotation = Quaternion.Euler(0, 180, 55);
        }
        
    }

    void Update () {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        playerPos = transform.position;
        attackPos = attackPoint.position;
    }

    void FixedUpdate(){
        moveCharacter(direction);
        playerDirection();
    }

    
}