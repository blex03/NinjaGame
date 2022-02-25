using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{

    public float health = 20;

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
        death();
    }
}
