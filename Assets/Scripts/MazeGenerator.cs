using System.IO;
using UnityEngine;

namespace Assets.Scripts
{
    public class MazeGenerator : MonoBehaviour 
    {
        public GameObject main;
        void Start()
        {  
            var lines = File.ReadAllLines(@"C:\Users\Reina\Documents\GitHub\Maze\ExampleMaze.txt");

            foreach (var line in lines)
            {
                var wall = GameObject.CreatePrimitive(PrimitiveType.Cube);

                wall.transform.parent = main.transform;
                var seperateValues = line.Split(' ');

                if(seperateValues[0] == "V")
                {
                    wall.transform.rotation = Quaternion.identity;
                    wall.transform.localScale = new Vector3(0.33f, 1, float.Parse(seperateValues[4]));
                }
                if(seperateValues[0] == "H")
                {
                    wall.transform.rotation = new Quaternion(0, 0, 0, 0);
                    wall.transform.localScale = new Vector3(1, 1, float.Parse(seperateValues[4]));
                }
                wall.transform.localPosition = new Vector3(float.Parse(seperateValues[1]), float.Parse(seperateValues[2]), float.Parse(seperateValues[3]));
            }
        }

    }
}
