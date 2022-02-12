using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 5;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.up);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.down);
    }
}
