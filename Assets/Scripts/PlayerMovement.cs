using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
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

    public static SpriteRenderer spriteRenderer;
    public static Sprite[] spriteArray;

    public static void Direction(float screenPosX, float screenPosY){
        Debug.Log("X: " + screenPosX + ", Y: " + screenPosY);
    }

    private void Update()
    {
        Movement();
    }
}