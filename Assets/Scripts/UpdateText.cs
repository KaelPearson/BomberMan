using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateText : MonoBehaviour
{
    public Text text;
    float p1MS = 3;
    int p1BS = 1;
    int p1BA = 1;
    void Update()
    {
        p1MS = Player1Stats.MovementSpeed;
        p1BS = Player1Stats.BombSize;
        p1BA = Player1Stats.BombAvaiable;
        text.text = "PlayerOne Movespeed : " + p1MS + "/7 || Bomb Size : " + p1BS + "/6 || Bomb Available : " + p1BA + "/6";
    }
}
