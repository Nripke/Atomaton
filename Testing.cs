using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StreamReader sr = new StreamReader(@"Assets\ElementInfo.txt");
        string l = sr.ReadLine();

        Debug.Log(l);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
