using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject player;
    Vector2 Movement;
    float movementSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetMouseButton(0)) {
            pos.x -= movementSpeed * Time.deltaTime;
        }
        if (Input.GetMouseButton(1)) {
            pos.x += movementSpeed * Time.deltaTime;

        }
        var d = Input.GetAxis("Mouse ScrollWheel");
        if (d > 0f) {
            pos.y += movementSpeed * Time.deltaTime;
        } else if (d < 0f) {
            pos.y -= movementSpeed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
