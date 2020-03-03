using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroy : MonoBehaviour
{
    public GameObject bomb;
    public GameObject explosion;
    float timer = 0;
    int bombSize;
    Vector3 bombPos;
    Vector3 orgPos;
    GameObject[] gameObjects;
    void Start() {
        bombSize = Player1Stats.BombSize;
        bombPos = bomb.transform.position;
        orgPos = bomb.transform.position;
        gameObjects = GameObject.FindGameObjectsWithTag("Wall");
    }
    void createBox(Vector3 pos) {
        Instantiate(explosion, pos, Quaternion.identity);
    }
    void RightSide() {
        createBox(bombPos);
        for (int i = 0; i < bombSize; i++) {
            bombPos[0] = orgPos[0] + (i + 1);
            for (int k = 0; k < gameObjects.Length; k++) {
                if ((int)gameObjects[k].transform.position.x == (int)bombPos[0] && (int)gameObjects[k].transform.position.y == (int)bombPos[1]) {
                    return;
                }
            }
            createBox(bombPos);
        }
    }
    void LeftSide() {
        for (int i = 0; i < bombSize; i++) {
            bombPos[0] = orgPos[0] - (i + 1);
            for (int k = 0; k < gameObjects.Length; k++) {
                if ((int)gameObjects[k].transform.position.x == (int)bombPos[0] && (int)gameObjects[k].transform.position.y == (int)bombPos[1]) {
                    return;
                }
            }
            createBox(bombPos);
        }
    }
    void TopSide() {
        for (int i = 0; i < bombSize; i++) {
            bombPos[1] = orgPos[1] + (i + 1);
            for(int k = 0; k < gameObjects.Length; k++) {
                if ((int)gameObjects[k].transform.position.y == (int)bombPos[1] && (int)gameObjects[k].transform.position.x == (int)bombPos[0]) {
                    return;
                }
            }
            createBox(bombPos);
        }
    }
    void BotSide() {
        for (int i = 0; i < bombSize; i++) {
            bombPos[1] = orgPos[1] + (-i - 1);
            createBox(bombPos);
            for (int k = 0; k < gameObjects.Length; k++) {
                if ((int)gameObjects[k].transform.position.y == (int)bombPos[1] && (int)gameObjects[k].transform.position.x == (int)bombPos[0]) {
                    return;
                }
            }
        }
    }
    void CreateExplosion() {

        createBox(bombPos);

        RightSide();
        LeftSide();

        bombPos[0] = orgPos[0];

        TopSide();
        BotSide();
    }
    void Update() {
        if(timer > 2) {
            CreateExplosion();
           
            Destroy(gameObject);
        }
        timer += Time.deltaTime;
    }
}
