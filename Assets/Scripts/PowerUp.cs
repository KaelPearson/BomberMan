using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject obj;
    void OnTriggerEnter2D(Collider2D collider) {
        
        if(collider.gameObject.tag == "Player1") {
            if(obj.tag == "shoe") {
                if (Player1Stats.MovementSpeed < 9) {
                    Player1Stats.MovementSpeed += 1f;
                } 
            } else if (obj.tag == "bombSize") {
                if (Player1Stats.BombSize < 6) {
                    Player1Stats.BombSize += 1;
                } 
            } else {
                if (Player1Stats.BombTotal < 6) {
                    Player1Stats.BombAvaiable += 1;
                    Player1Stats.BombTotal += 1;
                }
            }
            Destroy(gameObject);
        } else if(collider.gameObject.tag == "Player2") {
            if (obj.tag == "shoe") {
                if (Player2Stats.MovementSpeed < 9) {
                    Player2Stats.MovementSpeed += 1;
                }
            } else if (obj.tag == "bombSize") {
                if (Player2Stats.BombSize < 6) {
                    Player2Stats.BombSize += 1;
                }
            } else {
                if (Player2Stats.BombTotal < 6) {
                    Player2Stats.BombAvaiable += 1;
                    Player2Stats.BombTotal += 1;
                }
            }
            Destroy(gameObject);
        }
    }
}
