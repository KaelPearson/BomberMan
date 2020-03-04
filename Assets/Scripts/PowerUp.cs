using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject obj;
    void OnTriggerEnter2D(Collider2D collider) {
        
        if(collider.gameObject.tag == "Player1") {
            if(obj.tag == "shoe") {
                if (Player1Stats.MovementSpeed <= 6) {
                    Player1Stats.MovementSpeed += 1f;
                } else {
                    Debug.Log("Max");
                }
            } else if (obj.tag == "bombSize") {
                if (Player1Stats.BombSize <= 5) {
                    Player1Stats.BombSize += 1;
                } else {
                    Debug.Log("Max");
                }
            } else {
                if (Player1Stats.BombAvaiable <= 5) {
                    Player1Stats.BombAvaiable += 1;
                } else {
                    Debug.Log("Max");
                }
            }
            Destroy(gameObject);
        } else if(collider.gameObject.tag == "Player2") {
            if (obj.tag == "shoe") {
                Player2Stats.MovementSpeed += 1;
            } else if (obj.tag == "bombSize") {
                Player2Stats.BombSize += 1;
            } else {
                Player2Stats.BombAvaiable += 1;
            }
            Destroy(gameObject);
        }
    }
}
