using UnityEngine;
using System.Collections;

public class builder : MonoBehaviour {

    public int mazeSizeX = 100, mazeSizeY = 100, reverseProb = 3;
    public GameObject testCube;

    Room entrance, exit, center;
    Maze maze;

	// Use this for initialization
	void Awake () {
        setIntitalRooms();

        //build0();
        //build1();
        //build2();
        //build3();
        //build4();
        build5();
    }

    void build0()
    {
        int curx = entrance.x, cury= entrance.y;
        while(curx != exit.x && cury != exit.y)
        {
            Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

            if (curx > exit.x)
            {
                if(cury > exit.y) maze.rooms.Add(new Room(--curx, --cury));
                if (cury < exit.y) maze.rooms.Add(new Room(--curx, ++cury));
                if (cury == exit.y) maze.rooms.Add(new Room(--curx, cury));
            }
            if (curx < exit.x)
            {
                if (cury > exit.y) maze.rooms.Add(new Room(++curx, --cury));
                if (cury < exit.y) maze.rooms.Add(new Room(++curx, ++cury));
                if (cury == exit.y) maze.rooms.Add(new Room(++curx, cury));
            }
            if (curx == exit.x)
            {
                if (cury > exit.y) maze.rooms.Add(new Room(curx, --cury));
                if (cury < exit.y) maze.rooms.Add(new Room(curx, ++cury));
            }

            //NICE, ITS TERRIBLE!!!
        }

    }

    void build1()
    {
        int curx = entrance.x, cury = entrance.y;
        while (curx != exit.x )
        {
            Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

            if (curx > exit.x)
            {
                 maze.rooms.Add(new Room(--curx, cury));
            }
            if (curx < exit.x)
            {
               maze.rooms.Add(new Room(++curx, cury));
            }
            if (curx == exit.x)
            {
                while (cury != exit.y)
                {
                   

                    if (cury > exit.y)
                    {
                        maze.rooms.Add(new Room(curx, --cury));
                    }
                    if (cury < exit.y)
                    {
                        maze.rooms.Add(new Room(curx, ++cury));
                    }
                    
                }

                //LOOK, ITS AN 'L'!!!
            }
        }

    }

    void build2()
    {
        int curx = entrance.x, cury = entrance.y;
        int tempVal = 0;
        while (curx != exit.x && cury != exit.y)
        {
            Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);



            if (tempVal == 0)
            {
                tempVal = Random.Range(0, 2);

                

                if (curx > exit.x)
                {
                    maze.rooms.Add(new Room(--curx, cury));
                }
                if (curx < exit.x)
                {
                    maze.rooms.Add(new Room(++curx, cury));
                }
                if (curx == exit.x)
                {
                    tempVal = 1;

                }

            }
            else
            {
                tempVal = Random.Range(0, 1);

               

                if (cury > exit.y)
                {
                    maze.rooms.Add(new Room(curx, --cury));
                }
                if (cury < exit.y)
                {
                    maze.rooms.Add(new Room(curx, ++cury));
                }
                if (cury == exit.y)
                {
                    tempVal = 0;

                }
            }
        }

        //LESS JANK

    }

    void build3()
    {
        int curx = entrance.x, cury = entrance.y;
        int tempVal = 0, switcher = 0, switcherChance = 7;
        while (!(curx == exit.x && cury == exit.y))
        {
            Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

            //switcherChance = Random.Range(0, 11);

            if (tempVal == 0)
            {

                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                tempVal = Random.Range(0, 2);

                if (curx > exit.x )
                {
                    maze.rooms.Add(new Room(--curx, cury));
                }
                if (curx < exit.x )
                {
                    maze.rooms.Add(new Room(++curx, cury));
                }
                if (curx == exit.x )
                {
                    tempVal = 1;

                }

            }
            else
            {
                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (cury > exit.y )
                {
                    maze.rooms.Add(new Room(curx, --cury));
                }
                if (cury < exit.y )
                {
                    maze.rooms.Add(new Room(curx, ++cury));
                }
                if (cury == exit.y )
                {
                    tempVal = 0;

                }
            }

            //JANKLES
        }
        Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

    }

    void build4()
    {
        int curx = entrance.x, cury = entrance.y;
        int tempVal = Random.Range(0, 2), switcher = 0, switcherChance = 7;
        int Quad = 0;

        if(tempVal == 0)
        {
            quad1(ref curx, ref cury, ref Quad);
        }
        else
        {
            quad3(ref curx, ref cury, ref Quad);
        }




        while (!(curx == exit.x && cury == exit.y))
        {
            Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

            //switcherChance = Random.Range(0, 11);

            if (tempVal == 0)
            {

                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (curx > exit.x)
                {
                    maze.rooms.Add(new Room(--curx, cury));
                }
                if (curx < exit.x)
                {
                    maze.rooms.Add(new Room(++curx, cury));
                }
                if (curx == exit.x)
                {
                    tempVal = 1;

                }

            }
            else
            {
                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (cury > exit.y)
                {
                    maze.rooms.Add(new Room(curx, --cury));
                }
                if (cury < exit.y)
                {
                    maze.rooms.Add(new Room(curx, ++cury));
                }
                if (cury == exit.y)
                {
                    tempVal = 0;

                }
            }

            //JANKLES
        }
        Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

    }

    void quad1(ref int curx, ref int cury, ref int Quad)
    {
        int tempVal = Random.Range(0, 2), switcher = 0, switcherChance = 7;
        int x = Random.Range(mazeSizeX / 2 + 10, mazeSizeX - 9);
        int y = Random.Range(10, mazeSizeY / 2 - 9);



        while (!(curx == x && cury == y))
        {
            Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

            //switcherChance = Random.Range(0, 11);

            if (tempVal == 0)
            {

                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (curx > x)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && cury > 1)
                            maze.rooms.Add(new Room(curx, --cury));
                        else if (tempVal == 1 && cury < mazeSizeY - 1)
                            maze.rooms.Add(new Room(curx, ++cury));
                    }
                    else
                        maze.rooms.Add(new Room(--curx, cury));
                }
                if (curx < x)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && cury > 1)
                            maze.rooms.Add(new Room(curx, --cury));
                        else if (tempVal == 1 && cury < mazeSizeY - 1)
                            maze.rooms.Add(new Room(curx, ++cury));
                    }
                    else
                        maze.rooms.Add(new Room(++curx, cury));
                }
                if (curx == x)
                {
                    tempVal = 1;

                }

            }
            else
            {
                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (cury > y)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && curx > 1)
                            maze.rooms.Add(new Room(--curx, cury));
                        else if (tempVal == 1 && curx < mazeSizeX - 1)
                            maze.rooms.Add(new Room(++curx, cury));
                    }
                    else
                        maze.rooms.Add(new Room(curx, --cury));
                }
                if (cury < y)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && curx > 1)
                            maze.rooms.Add(new Room(--curx, cury));
                        else if (tempVal == 1 && curx < mazeSizeX - 1)
                            maze.rooms.Add(new Room(++curx, cury));
                    }
                    else
                        maze.rooms.Add(new Room(curx, ++cury));
                }
                if (cury == y)
                {
                    tempVal = 0;

                }
            }
        }



        if (Quad == 0)
        {
            Quad++;
            quad3(ref curx, ref cury, ref Quad);
        }


    }

    void quad3(ref int curx, ref int cury, ref int Quad)
    {
        int tempVal = Random.Range(0, 2), switcher = 0, switcherChance = 7;
        int x = Random.Range(10, mazeSizeX / 2 - 9);
        int y = Random.Range(mazeSizeY / 2 + 10, mazeSizeY - 9);


        while (!(curx == x && cury == y))
        {
            Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

            //switcherChance = Random.Range(0, 11);

            if (tempVal == 0)
            {

                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (curx > x)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && cury > 1)
                            maze.rooms.Add(new Room(curx, --cury));
                        else if (tempVal == 1 && cury < mazeSizeY - 1)
                            maze.rooms.Add(new Room(curx, ++cury));
                    }
                    else
                        maze.rooms.Add(new Room(--curx, cury));
                }
                if (curx < x)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && cury > 1)
                            maze.rooms.Add(new Room(curx, --cury));
                        else if (tempVal == 1 && cury < mazeSizeY - 1)
                            maze.rooms.Add(new Room(curx, ++cury));
                    }
                    else
                        maze.rooms.Add(new Room(++curx, cury));
                }
                if (curx == x)
                {
                    tempVal = 1;

                }

            }
            else
            {
                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (cury > y)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && curx > 1)
                            maze.rooms.Add(new Room(--curx, cury));
                        else if (tempVal == 1 && curx < mazeSizeX - 1)
                            maze.rooms.Add(new Room(++curx, cury));
                    }
                    else
                        maze.rooms.Add(new Room(curx, --cury));
                }
                if (cury < y)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && curx > 1)
                            maze.rooms.Add(new Room(--curx, cury));
                        else if (tempVal == 1 && curx < mazeSizeX - 1)
                            maze.rooms.Add(new Room(++curx, cury));
                    }
                    else
                        maze.rooms.Add(new Room(curx, ++cury));
                }
                if (cury == y)
                {
                    tempVal = 0;

                }
            }
        }


        if (Quad == 0)
        {
            Quad++;
            quad1(ref curx, ref cury, ref Quad);
        }

    }

    void build5()
    {
        int curx = entrance.x, cury = entrance.y;
        int tempVal = Random.Range(0, 2), switcher = 0, switcherChance = 7;
        int Quad = 0;

        if (tempVal == 0)
        {
            quad1(ref curx, ref cury, ref Quad);
        }
        else
        {
            quad3(ref curx, ref cury, ref Quad);
        }


        while (!(curx == exit.x && cury == exit.y))
        {
            Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

            //switcherChance = Random.Range(0, 11);

            if (tempVal == 0)
            {

                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (curx > exit.x)
                {
                    if(reverseProb > switcher)
                    {
                        if(tempVal == 0 && cury > 1)
                            maze.rooms.Add(new Room(curx, --cury));
                        else if(tempVal == 1 && cury < mazeSizeY - 1)
                            maze.rooms.Add(new Room(curx, ++cury));
                    }
                    else
                    maze.rooms.Add(new Room(--curx, cury));
                }
                if (curx < exit.x)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && cury > 1)
                            maze.rooms.Add(new Room(curx, --cury));
                        else if (tempVal == 1 && cury < mazeSizeY-1)
                            maze.rooms.Add(new Room(curx, ++cury));
                    }
                    else
                        maze.rooms.Add(new Room(++curx, cury));
                }
                if (curx == exit.x)
                {
                    tempVal = 1;

                }

            }
            else
            {
                switcher = Random.Range(0, 11);
                if (switcher < switcherChance)
                    tempVal = Random.Range(0, 2);

                if (cury > exit.y)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && curx > 1)
                            maze.rooms.Add(new Room(--curx, cury));
                        else if (tempVal == 1 && curx < mazeSizeX - 1)
                            maze.rooms.Add(new Room(++curx, cury));
                    }
                    else
                        maze.rooms.Add(new Room(curx, --cury));
                }
                if (cury < exit.y)
                {
                    if (reverseProb > switcher)
                    {
                        if (tempVal == 0 && curx > 1)
                            maze.rooms.Add(new Room(--curx, cury));
                        else if (tempVal == 1 && curx < mazeSizeX - 1)
                            maze.rooms.Add(new Room(++curx, cury));
                    }
                    else
                        maze.rooms.Add(new Room(curx, ++cury));
                }
                if (cury == exit.y)
                {
                    tempVal = 0;

                }
            }
        }
        Instantiate(testCube, new Vector3(curx, 0, cury), Quaternion.identity);

    }

    void newCoord(out int x, out int y)
    {
        x = Random.Range(0, mazeSizeX);
        y = Random.Range(0, mazeSizeY);  
    }

    void setIntitalRooms()
    {
        int x, y;
        maze = new Maze(mazeSizeX, mazeSizeY);



        newCoord(out x, out y);
        entrance = new Room(0, 0);
        newCoord(out x, out y);
        exit = new Room(mazeSizeX, mazeSizeY);



        center = new Room(mazeSizeX / 2, mazeSizeY / 2);
    }

    
}
