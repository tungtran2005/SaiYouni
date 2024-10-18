using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : TungMonoBehaviour
{
    [SerializeField] protected List<Point> points = new List<Point>();
    public List<Point> Points => points;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPoint();
    }
    protected virtual void LoadPoint()
    {
        if(this.points.Count > 0) return;
        Point point;
        foreach(Transform child in transform)
        {
            point = child.GetComponent<Point>();
            if(point == null) continue;
            points.Add(point);
        }
        Debug.LogWarning(transform.name + " : LoadPoint", gameObject);
    }
    public Point GetPoint(int index)
    {
        return points[index];
    }
}
