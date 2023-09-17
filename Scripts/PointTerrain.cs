using UnityEngine;

[CreateAssetMenu]
public class PointTerrain : ScriptableObject
{
    public bool clear = false;
    public bool forrest = false;
    public bool mountain = false;
    public bool swamp = false;
    public bool city = false;
    public bool trench = false;
    public bool river = false;
    public bool sea = false;

    
    public Material Clear;
    public Material Forrest;
    public Material Mountain;
    public Material Swamp;
    public Material City;

}
