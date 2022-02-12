using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
