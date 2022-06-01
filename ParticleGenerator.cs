using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGenerator : MonoBehaviour
{
    [SerializeField] private float delay;
    [SerializeField] private GameObject proton;
    [SerializeField] private GameObject neutron;
    private float currentTime = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Time.time >= currentTime) //Every delay amount of seconds ...
        {
            int choice = Random.Range(0, 2);
            currentTime = currentTime + delay;
            if (choice == 0)
            {
                Instantiate(proton, new Vector3(0, 0, 0), Quaternion.identity);
            }else
            {
                Instantiate(neutron, new Vector3(0, 0, 0), Quaternion.identity);
            }
            
        }
    }
}
