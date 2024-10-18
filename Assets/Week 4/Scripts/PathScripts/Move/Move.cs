using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : TungMonoBehaviour
{
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Path path;
    [SerializeField] protected int currentPointIndex = 0;
    [SerializeField] protected Point currentPoint;
    [SerializeField] protected float pointDistance = Mathf.Infinity;
    [SerializeField] protected float pointDistanceLimit = 1f;
    [SerializeField] protected bool isFinish = false;
    private void FixedUpdate()
    {
        this.Moving();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAgent();
        this.LoadPath();
    }
    protected virtual void LoadAgent()
    {
        if (this.agent != null) return;
        this.agent = GetComponentInParent<NavMeshAgent>();
        Debug.LogWarning(transform.name + " : LoadAgent", gameObject);
    }
    protected virtual void LoadPath()
    {
        if(this.path != null) return;
        this.path = GameObject.Find("PathZicZac").GetComponent<Path>();
        Debug.LogWarning(transform.name + " : LoadPath", gameObject);
    }
    protected virtual void Moving()
    {
        if (this.isFinish)
        {
            this.agent.isStopped = true;
            return;
        }
        this.GetNextPoint();
        this.agent.SetDestination(this.currentPoint.transform.position);
    }
    protected virtual void GetNextPoint()
    {
        this.currentPoint = path.GetPoint(this.currentPointIndex);
        this.pointDistance = Vector3.Distance(this.currentPoint.transform.position, transform.position);
        if (this.pointDistance < pointDistanceLimit) this.currentPointIndex++;
        if (this.currentPointIndex > this.path.Points.Count - 1) this.isFinish = true;
    }
}
