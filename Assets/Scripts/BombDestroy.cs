﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 19 x 9
public class BombDestroy : MonoBehaviour
{
    public GameObject bomb;
    public GameObject speed;
    public GameObject bombRange;
    public GameObject moreBomb;

    public GameObject explosion;
    float timer = 0;
    int bombSize;
    Vector3 bombPos;
    Vector3 orgPos;
    GameObject[] gameObjects;
    GameObject[] gameObjects2;
    public GameObject explosionPart;
    public GameObject woodDestroyPart;
    public GameObject wall;
    void Start() {
        bombSize = Player1Stats.BombSize;
        bombPos = bomb.transform.position;
        orgPos = bomb.transform.position;
    }
    void CreateBox(Vector3 pos) {
        pos[2] = -2;
        Instantiate(explosionPart, pos, Quaternion.identity);
        Instantiate(explosion, pos, Quaternion.identity);
    }
    void CreatePowerup(Vector3 loc) {

        int rand = Random.Range(0, 4);
        if (rand == 0) {
            rand = Random.Range(0, 3);
            if(rand == 0) {
                Instantiate(speed, loc, Quaternion.identity);
            } else if (rand == 1) {
                Instantiate(bombRange, loc, Quaternion.identity);
            } else if (rand == 2){
                Instantiate(moreBomb, loc, Quaternion.identity);
            }
        } else {
            if (gameStats.Hell == true) {
                rand = Random.Range(0, 3);
                if (rand == 0) {
                    GameObject wallSpawn = Instantiate(wall, loc, Quaternion.identity);
                    if (gameStats.Level == "LevelTwo") {
                        Destroy(wallSpawn, 90);
                    } else {
                        Destroy(wallSpawn, 30);
                    }
                }
            } else {
                rand = Random.Range(0, 100);
                if (rand == 0) {
                    GameObject wallSpawn = Instantiate(wall, loc, Quaternion.identity);
                    Destroy(wallSpawn, 120);
                }
            }
        }
    }

    void RightSide() {
        CreateBox(bombPos);
        for (int i = 0; i < bombSize; i++) {
            bombPos[0] = orgPos[0] + (i + 1);
            for (int k = 0; k < gameObjects.Length; k++) {
                if ((int)gameObjects[k].transform.position.x == (int)bombPos[0] && (int)gameObjects[k].transform.position.y == (int)bombPos[1]) {
                    return;
                }
            }
            for(int k = 0; k < gameObjects2.Length; k++) {
                if((int)gameObjects2[k].transform.position.x == (int)bombPos[0] && (int)gameObjects2[k].transform.position.y == (int)bombPos[1]) {
                    CreatePowerup(gameObjects2[k].transform.position);
                    Instantiate(woodDestroyPart, gameObjects2[k].transform.position, Quaternion.identity);
                    Destroy(gameObjects2[k], 0);
                    return;
                }
            }
            CreateBox(bombPos);
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
            for (int k = 0; k < gameObjects2.Length; k++) {
                if ((int)gameObjects2[k].transform.position.x == (int)bombPos[0] && (int)gameObjects2[k].transform.position.y == (int)bombPos[1]) {
                    CreatePowerup(gameObjects2[k].transform.position);
                    Instantiate(woodDestroyPart, gameObjects2[k].transform.position, Quaternion.identity);
                    Destroy(gameObjects2[k], 0);
                    return;
                }
            }
            CreateBox(bombPos);
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
            for(int k = 0; k < gameObjects2.Length; k++) {
                if((int)gameObjects2[k].transform.position.y == (int)bombPos[1] && (int)gameObjects2[k].transform.position.x == (int)bombPos[0]) {
                    CreatePowerup(gameObjects2[k].transform.position);
                    Instantiate(woodDestroyPart, gameObjects2[k].transform.position, Quaternion.identity);
                    Destroy(gameObjects2[k], 0);
                    return;
                }
            }
            CreateBox(bombPos);
        }
    }
    void BotSide() {
        for (int i = 0; i < bombSize; i++) {
            bombPos[1] = orgPos[1] + (-i - 1);
            for (int k = 0; k < gameObjects.Length; k++) {
                if ((int)gameObjects[k].transform.position.y == (int)bombPos[1] && (int)gameObjects[k].transform.position.x == (int)bombPos[0]) {
                    return;
                }
            }
            for (int k = 0; k < gameObjects2.Length; k++) {
                if ((int)gameObjects2[k].transform.position.y == (int)bombPos[1] && (int)gameObjects2[k].transform.position.x == (int)bombPos[0]) {
                    CreatePowerup(gameObjects2[k].transform.position);
                    Instantiate(woodDestroyPart, gameObjects2[k].transform.position, Quaternion.identity);
                    Destroy(gameObjects2[k], 0);
                    return;
                }
            }
            CreateBox(bombPos);
        }
    }
    void CreateExplosion() {

        CreateBox(bombPos);

        RightSide();
        LeftSide();

        bombPos[0] = orgPos[0];

        TopSide();
        BotSide();
    }
    void Update() {
        if(timer > 2) {
            gameObjects = GameObject.FindGameObjectsWithTag("Wall");
            gameObjects2 = GameObject.FindGameObjectsWithTag("Crate");
            CreateExplosion();
            Player1Stats.BombAvaiable += 1;
            Destroy(gameObject);
        }
        timer += Time.deltaTime;
    }
}
