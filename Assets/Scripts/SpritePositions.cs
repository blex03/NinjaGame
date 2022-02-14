using UnityEngine;
using System.Collections;
using Player = PlayerMovement;

public class SpritePositions : MonoBehaviour
{
    public Transform target;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(target.position);
        Player.Direction(screenPos.x, screenPos.y);
    }
}
