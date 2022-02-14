using UnityEngine;
using System.Collections;

public class SpritePositions : MonoBehaviour
{
    public Transform player;
    Camera cam;
    public static Vector2 screenPos;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = cam.WorldToScreenPoint(player.position);
    }
}
