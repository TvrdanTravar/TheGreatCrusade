using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointInfo : MonoBehaviour
{
    public PointTerrain terrain;

    public GameObject[] connected;

    public List<GameObject> armies = new List<GameObject>();

    [SerializeField]
    private Material isSelected;

    [HideInInspector]
    public bool selected = false;

    private MeshRenderer myRend;

    public UiMaster uiMaster;


    void Start()
    {
        //ClickMe();

        myRend = GetComponent<MeshRenderer>();
        if (terrain.clear == true) myRend.material = terrain.Clear;
        if (terrain.forrest == true) myRend.material = terrain.Forrest;
        if (terrain.mountain == true) myRend.material = terrain.Mountain;
        if (terrain.swamp == true) myRend.material = terrain.Swamp;
        if (terrain.city == true) myRend.material = terrain.City;
    }

    public void Unselect()
    {
        myRend = GetComponent<MeshRenderer>();

        if (terrain.clear == true) myRend.material = terrain.Clear;
        if (terrain.forrest == true) myRend.material = terrain.Forrest;
        if (terrain.mountain == true) myRend.material = terrain.Mountain;
        if (terrain.swamp == true) myRend.material = terrain.Swamp;
        if (terrain.city == true) myRend.material = terrain.City;
    }

    public void ClickMe()
    {
        if (selected == false)
        {
            Unselect();
            uiMaster.currentSpace.Clear();
        }
        if (selected == true)
        {
            myRend.material = isSelected;
            uiMaster.currentSpace.Clear();
            uiMaster.currentSpace.Add(gameObject);
        }
    }

}
