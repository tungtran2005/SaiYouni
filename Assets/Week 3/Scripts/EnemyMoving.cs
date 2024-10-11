using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Transform targetPos;
    private void Reset()
    {
        this.LoadAgent();
        this.LoadTarget();
    }
    private void Awake()
    {
        this.LoadAgent();
        this.LoadTarget();
    }
    protected virtual void LoadAgent()
    {
        this.agent = transform.parent.GetComponent<NavMeshAgent>();
    }
    protected virtual void LoadTarget()
    {
        this.targetPos = GameObject.Find("Point").transform;
    }
    private void FixedUpdate()
    {
        this.Moving();
    }
    protected virtual void Moving()
    {
        this.agent.SetDestination(this.targetPos.position);
    }
}
