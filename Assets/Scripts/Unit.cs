using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
    public Unit()
    {

    }
    bool[] walls; //north, south, east, west
    Room occupying;
    public bool isFree = true;
}
