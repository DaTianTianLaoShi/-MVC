using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterInfo : MonoBehaviour
{
    private int ID;
    private int HP;
    private float MoveSpeed;

    public int id { get => ID; set => ID = value; }
    public int hp { get => HP; set => HP = value; }
    public float movespeed { get => MoveSpeed; set => MoveSpeed = value; }
}
