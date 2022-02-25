using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{

    public float health = 20;

    public Rigidbody2D rb;
    public Transform player;
    
    private Vector2 playerPos;
    private Vector2 zombiePos;
   
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    private void zombieDirection(){
        Vector2 lookDir = playerPos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;    

        //Zombie Direction

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

    private void death(){
        if (health <= 0){
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D dataFromCollision)
    {

        if (dataFromCollision.gameObject.name == "Slash_4(Clone)")
        {
            health -= 10;
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        zombiePos = transform.position;
        playerPos = player.transform.position;
    }

    void FixedUpdate(){
        zombieDirection();
        death();
    }
}
