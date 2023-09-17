using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiMaster : MonoBehaviour
{
    public List<GameObject> currentSpace = new List<GameObject>();

    public void Move()
    {
        if (currentSpace.Count != 0) Debug.Log("Move" + currentSpace[0]);
    }
    public void Fortify()
    {
        if (currentSpace.Count != 0) Debug.Log("Fortify" + currentSpace[0]);
    }
}
