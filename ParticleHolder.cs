using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Contains all information regarding the amount of subatomic particles the player has,
 * the variables will be static so they can be accessed anywhere in the game.
 */
public class ParticleHolder : MonoBehaviour
{
    public static int neutrons;
    public static int protons;
    
    /*NEED TO ADD* --> Saving/Loading feature
     */
    void Start()
    {
        neutrons = 0;
        protons = 0;
    }

}
