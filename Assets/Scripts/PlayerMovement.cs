using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Rigidbody2D rb;
    public GameObject player;
    Vector2 Movement;
    float movementSpeed = 1;
    // up down right left
    string[] dir = {"","", "", ""};
    void Start() {
        if(player.name == "Player1") {
            dir[0] = "w";
            dir[1] = "s";
            dir[2] = "d";
            dir[3] = "a";
        } else if (player.name == "Player2") {
            dir[0] = "up";
            dir[1] = "down";
            dir[2] = "right";
            dir[3] = "left";
            movementSpeed = Player2Stats.MovementSpeed;
        }
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        Vector3 pos = transform.position;
        if (player.name == "Player1") {
            movementSpeed = Player1Stats.MovementSpeed;
        } else {
            movementSpeed = Player2Stats.MovementSpeed;
        }
        if (Input.GetKey(dir[0])) {
            pos.y += movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(dir[1])) {
            pos.y -= movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(dir[2])) {
            pos.x += movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(dir[3])) {
            pos.x -= movementSpeed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
