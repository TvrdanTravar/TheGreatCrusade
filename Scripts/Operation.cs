using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation : MonoBehaviour
{
    public pointInfo pointInfo;
    public LayerMask points;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        RaycastHit raycast;
        if (Physics.Raycast(position, Vector3.down, out raycast, Mathf.Infinity, points))
        {
            pointInfo = raycast.collider.GetComponent<pointInfo>();
            pointInfo.armies.Add(this.gameObject);
        }
    }

    public void Movement()
    {

    }
}
