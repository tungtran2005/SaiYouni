using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSpawner : TungSingleton<EffectSpawner>
{
    [SerializeField] protected GameObject Bullet;
    public virtual void SpawnBullet(FirePoint firePoint)
    {
        GameObject newBullet = Instantiate(this.Bullet);
        newBullet.transform.position = firePoint.transform.position;
        newBullet.transform.rotation = firePoint.transform.rotation;
    }
}
