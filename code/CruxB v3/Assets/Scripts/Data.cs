using System.Collections;
using System.Collections.Generic;

public class Data
{
    public static List<string> constantNames = new List<string>()
    {
        "up", "down", "left", "right", "space", "<", ">", "0", "1", "3", "10", "0.1", "true"
    };

    public static List<string> variableNames = new List<string>()
    {
        "score", "A.speed", "A.rate", "A.time", "M.speed"
    };

    public static List<string> functionNames = new List<string>()
    {
        "input", "update", "spawn", "despawn", "A.collide", "R.move", "END"
    };
    // hard coded in Draggable.cs, addBlank(). change accordingly

    public static List<string> objectNames = new List<string>()
    {
        "Rocket", "Asteroid", "Missile", "Ground"
    };

    public static List<string> blockNames = new List<string>()
    {
        "Initialize", "Handle input", "Update Position", "Spawn Asteroid", "Collision Check"
    };

    // public static ArrayList blockContent = new ArrayList()
    // {
    //     // block 0
    //     new ArrayList() { 
    //         // assign statement
    //         new ArrayList() {"asn",  
    //             new ArrayList() { new ArrayList() {"var", "score"}, "=", new ArrayList() {"con", "0"} }
    //         }
    //     },
    //     // block 1
    //     new ArrayList() {},
    //     // block 2
    //     new ArrayList() {},
    //     // block 3
    //     new ArrayList() {},
    //     // block 4
    //     new ArrayList() {},
    // };
}
