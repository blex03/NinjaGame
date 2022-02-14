using UnityEngine;
using System;
using PlayerPos = SpritePositions;

public class PlayerMovement : MonoBehaviour
{

    //Movement
    public float speed = 5;

    private void Movement(){
       
         //NWE
        if (Input.GetKey(KeyCode.W)) {
            if (Input.GetKey(KeyCode.D)) {
                transform.Translate(Vector2.up * (float)(Math.Sqrt(Math.Pow(speed, 2) / 2) * Time.deltaTime));
                transform.Translate(Vector2.right * (float)(Math.Sqrt(Math.Pow(speed, 2) / 2) * Time.deltaTime));
            }
            else if (Input.GetKey(KeyCode.A)) {
                transform.Translate(Vector2.up * (float)(Math.Sqrt(Math.Pow(speed, 2) / 2) * Time.deltaTime));
                transform.Translate(Vector2.left * (float)(Math.Sqrt(Math.Pow(speed, 2) / 2) * Time.deltaTime));
            }
            else {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
        }
        
        //SWE
        else if (Input.GetKey(KeyCode.S)) {
            if (Input.GetKey(KeyCode.D)) {
                transform.Translate(Vector2.down * (float)(Math.Sqrt(Math.Pow(speed, 2) / 2) * Time.deltaTime));
                transform.Translate(Vector2.right * (float)(Math.Sqrt(Math.Pow(speed, 2) / 2) * Time.deltaTime));
            }
            else if (Input.GetKey(KeyCode.A)) {
                transform.Translate(Vector2.down * (float)(Math.Sqrt(Math.Pow(speed, 2) / 2) * Time.deltaTime));
                transform.Translate(Vector2.left * (float)(Math.Sqrt(Math.Pow(speed, 2) / 2) * Time.deltaTime));
            }
            else {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
        }

        //W
        else if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        //E
        else if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    //Sprite Direction
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    private void Direction(){
        Vector2 mousePos = Input.mousePosition;

        float rad = (float)(Math.PI / 180);
        
        float relativeX = mousePos.x - PlayerPos.screenPos.x;
        float relativeY = mousePos.y - PlayerPos.screenPos.y;
        float ratio;

        bool quad1 = false;
        bool quad2 = false;
        bool quad3 = false;
        bool quad4 = false;

        //Mouse Quadrant with Character at origin
        if (relativeX > 0 && relativeY > 0) {
            quad1 = true;
        }
        if (relativeX < 0 && relativeY > 0) {
            quad2 = true;
        }
        if (relativeX < 0 && relativeY < 0) {
            quad3 = true;
        }
        if (relativeX > 0 && relativeY < 0) {
            quad4 = true;
        }

        if (relativeX != 0) {
		ratio = relativeY / relativeX;
        }
        else {
            ratio = 0;
        }
        
        //S
        if (ratio <= Math.Tan(292.5 * rad) && quad4 || ratio >= Math.Tan(247.5 * rad) && quad3) {
            spriteRenderer.sprite = spriteArray[0]; 
        }

        //SW
        if ((ratio < Math.Tan(247.5 * rad) && ratio > Math.Tan(202.5 * rad)) && quad3) {
            spriteRenderer.sprite = spriteArray[1]; 
        }

        //W
        if (ratio <= Math.Tan(202.5 * rad) && quad3 || ratio >= Math.Tan(157.5 * rad) && quad2) {
            spriteRenderer.sprite = spriteArray[2]; 
        }

        //NW
        if ((ratio < Math.Tan(157.5 * rad) && ratio > Math.Tan(112.5 * rad)) && quad2) {
            spriteRenderer.sprite = spriteArray[3]; 
        }
        //N
        if (ratio <= Math.Tan(112.5 * rad) && quad2|| ratio >= Math.Tan(67.5 * rad) && quad1) {
            spriteRenderer.sprite = spriteArray[4]; 
        }

        //NE
        if ((ratio < Math.Tan(67.5 * rad) && ratio > Math.Tan(22.5 * rad)) && quad1) {
            spriteRenderer.sprite = spriteArray[5];
        }

        //E
        if (ratio <= Math.Tan(22.5 * rad) && quad1 || ratio >= Math.Tan(337.5 * rad) && quad4) {
            spriteRenderer.sprite = spriteArray[6]; 
        }

        //SE
        if ((ratio < Math.Tan(337.5 * rad) && ratio > Math.Tan(292.5 * rad)) && quad4) {
            spriteRenderer.sprite = spriteArray[7]; 
        }
        
    }

    //Update
    void Update(){
        Movement();
        Direction();
    }
}