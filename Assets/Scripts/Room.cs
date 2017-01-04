using UnityEngine;
using System.Collections;

public class Room : MonoBehaviour {

    

   public Room(int x, int y)
    {
        this.x = x;
        this.y = y;
       // Maze.grid[x, y] = new Unit();
        //TODO Make this work with rooms larger than 1x1
    }

    public int x, y;


    Unit [] checkArea()
    {
        int rand= Random.Range(0, GetComponent<Maze>().availableUnits.Count+1);

       // GetComponent<Maze>().availableUnits[rand]


        return null;
    }
    void generate()
    {

    }
    void pick()
    {

    }

    
}
