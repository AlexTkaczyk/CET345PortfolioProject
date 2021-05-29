using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemies/Enemy")]
public class Enemy_scriptableObject : ScriptableObject
{
    public string enemy_name = "New Enemy";
    public int enemy_health;
}
