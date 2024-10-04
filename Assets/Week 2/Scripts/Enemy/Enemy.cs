using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{
    int enemyCurrentHP = 100;
    public int EnemyCurrentHP => enemyCurrentHP;
    int enemyMaxHP = 100;
    int minHP = 0;
    int maxHP = 100;
    private void Awake()
    {
        this.RandomHP();
    }
    public int GetHP()
    {
        return this.enemyCurrentHP;
    }
    public int SetHP(int newHP)
    {
        this.enemyCurrentHP = newHP;
        return this.enemyCurrentHP;
    }
    public void Reborn()
    {
        this.enemyCurrentHP = this.enemyMaxHP;
    }
    private void RandomHP()
    {
        int newHP = Random.Range(this.minHP, this.maxHP);
        this.SetHP(newHP);
    }
}
