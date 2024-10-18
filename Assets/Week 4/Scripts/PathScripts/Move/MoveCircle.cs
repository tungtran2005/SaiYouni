using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle : Move
{
    protected override void LoadPath()
    {
        if (this.path != null) return;
        this.path = GameObject.Find("PathCircle").GetComponent<Path>();
        Debug.LogWarning(transform.name + " : LoadPath", gameObject);
    }
}
