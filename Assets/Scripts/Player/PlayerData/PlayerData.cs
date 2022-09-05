using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
    [Header("Stat")]
    public int hp = 100;
    public int maxHp = 100;
    public int mana = 5;
    public int maxMana = 5;
    public int defence = 10;

    [Header("Move State")]
    public float speed = 10.0f;
}
