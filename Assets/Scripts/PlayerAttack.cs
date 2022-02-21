using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform attackPoint;
    public GameObject slashPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            GameObject slash = Instantiate(slashPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
