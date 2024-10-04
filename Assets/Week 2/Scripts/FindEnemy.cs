using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    
    public List<Enemy> enemies = new List<Enemy>();
    Enemy minEnemy;
    Enemy maxEnemy;
    private void Start()
    {
        this.LoadEnemys();
        this.FindMinEnemy();
        this.FindMaxEnemy();
    }
    protected void LoadEnemys()
    {
        foreach(Transform child in transform)
        {
            Enemy enemy = child.GetComponent<Enemy>();
            this.enemies.Add(enemy);
        }
    }
    protected void FindMinEnemy()
    {
        this.minEnemy = this.FindEnemyWithSmallestHealth(this.enemies);
        if (this.minEnemy == null) Debug.Log("No Enemy");
        Debug.Log("min hp : " + this.minEnemy.EnemyCurrentHP, this.minEnemy.gameObject);
    }
    protected void FindMaxEnemy()
    {
        this.maxEnemy = this.FindEnemyWithLargestHealth(this.enemies);
        if (this.maxEnemy == null) Debug.Log("No Enemy");
        Debug.Log("max hp : " + this.maxEnemy.EnemyCurrentHP, this.maxEnemy.gameObject);
    }
//----------------------Edit below here --------------------
    public Enemy FindEnemyWithSmallestHealth(List<Enemy> enemies)
    {
        if (this.enemies == null || this.enemies.Count == 0) return null;
        Enemy minEnemy = enemies[0];
        foreach (Enemy enemy in enemies)
        {
            if(enemy.EnemyCurrentHP < minEnemy.EnemyCurrentHP) minEnemy = enemy;
            
        }
        return minEnemy;
    }

    public Enemy FindEnemyWithLargestHealth(List<Enemy> enemies)
    {
        if (this.enemies == null || this.enemies.Count == 0) return null;
        Enemy maxEnemy = enemies[0];
        foreach (Enemy enemy in enemies)
        {
            if (enemy.EnemyCurrentHP > maxEnemy.EnemyCurrentHP) maxEnemy = enemy;

        }
        return maxEnemy;
    }

    //----------------------Edit above here --------------------
}
