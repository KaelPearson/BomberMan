using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateText : MonoBehaviour
{
    public Text text;
    public Text text2;
    float p1MS = 3;
    int p1BS = 1;
    int p1BA = 1;
    float p2MS = 3;
    int p2BS = 1;
    int p2BA = 1;
    void Update()
    {
        p1MS = Player1Stats.MovementSpeed;
        p1MS -= 3;
        p1BS = Player1Stats.BombSize;
        p1BA = Player1Stats.BombAvaiable;

        p2MS = Player2Stats.MovementSpeed;
        p2MS -= 3;
        p2BS = Player2Stats.BombSize;
        p2BA = Player2Stats.BombAvaiable;
        text.text = "Movespeed : " + p1MS + "/6 || Bomb Size : " + p1BS + "/6 || Bomb Available : " + p1BA + "/6";
        text2.text = "Movespeed : " + p2MS + "/6 || Bomb Size : " + p2BS + "/6 || Bomb Available : " + p2BA + "/6";
    }
}
