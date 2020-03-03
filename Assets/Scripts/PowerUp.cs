using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject obj;
    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Player1") {
            if(obj.tag == "shoe") {
                Player1Stats.MovementSpeed += 1;
            } else if (obj.tag == "bombSize") {
                Player1Stats.BombSize += 1;
            } else {
                Player1Stats.BombAvaiable += 1;
            }
            Destroy(gameObject);
        } else if(collider.gameObject.tag == "Player2") {
            Debug.Log("two");
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
