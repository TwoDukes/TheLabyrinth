using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Maze : MonoBehaviour {


   public Maze(int x, int y)
    {
        gridSizeX = x;
        gridSizeY = y;
        //unitSet();
    }

    void unitSet()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for(int y = 0; y < gridSizeY; y++)
            {
                availableUnits.Add(grid[x,y]);
            }
        }
    }

    public List<Unit> availableUnits = new List<Unit>();



    [HideInInspector]
    public static Unit[,] grid;
    public List<Room> rooms =  new List<Room>();
    public int gridSizeX, gridSizeY;



}
