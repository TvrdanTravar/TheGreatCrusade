using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointType : MonoBehaviour
{

    public bool key = false;
    public bool capital = false;

    public Material Key;
    public Material Capital;

    private MeshRenderer myRend;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        if (key == true) myRend.material = Key;
        if (capital == true) myRend.material = Capital;
    }

}
