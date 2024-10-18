using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandom : TungMonoBehaviour
{
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected float range = 20f;
    [SerializeField] protected Vector3 currentPoint = new Vector3(0,4.5f,0);
    [SerializeField] protected float pointDistance = Mathf.Infinity;
    [SerializeField] protected float pointDistanceLimit = 1f;
    private void FixedUpdate()
    {
        this.Moving();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAgent();
    }
    protected virtual void LoadAgent()
    {
        if (this.agent != null) return;
        this.agent = GetComponentInParent<NavMeshAgent>();
        Debug.LogWarning(transform.name + " : LoadAgent", gameObject);
    }
    protected virtual void Moving()
    {
        this.GetNextPoint();
        this.agent.SetDestination(this.currentPoint);
    }
    protected virtual void GetNextPoint()
    {
        this.pointDistance = Vector3.Distance(this.currentPoint, this.transform.position);
        if(this.pointDistance < pointDistanceLimit )
        {
            float randomX = Random.Range(-range, range);
            float randomZ = Random.Range(-range, range);
            currentPoint = new Vector3(randomX, transform.position.y, randomZ);
        }
    }
}
