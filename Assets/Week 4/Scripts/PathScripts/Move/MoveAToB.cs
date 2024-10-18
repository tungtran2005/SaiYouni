using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAToB : Move
{
    protected override void LoadPath()
    {
        if (this.path != null) return;
        this.path = GameObject.Find("PathAToB").GetComponent<Path>();
        Debug.LogWarning(transform.name + " : LoadPath", gameObject);
    }
}
