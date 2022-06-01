using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//Will hold all of the elements in objects, this allows for easy access to them
public class ElementHolder : MonoBehaviour
{
    public static Element[] elements;

    //At the start of the game, we instantiate all elements
    void Start()
    {
        elements = new Element[111];
        string file = @"Assets\ElementInfo.txt";


        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            for (int i = 0; i<lines.Length; i++)
            {
                string[] parameters = new string[6];
                int currentPar = 0;

                char[] currentE = lines[i].ToCharArray();
                string currentBlock = "";
                for (int letter = 0; letter<currentE.Length; letter++)
                {
                    if (currentE[letter] != '_')
                    {
                        currentBlock += currentE[letter];
                    }else
                    {
                        parameters[currentPar] = currentBlock;
                        currentBlock = "";
                        currentPar++;
                    }
                }

                elements[i] = new Element(parameters[0], parameters[1], int.Parse(parameters[2]), int.Parse(parameters[3]), int.Parse(parameters[4]), int.Parse(parameters[5]));
            }
        }
    }
}
