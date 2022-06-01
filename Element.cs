using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * The element class contains all information regarding any element.
 * This will help us store information in a more compact way (Who wants to write a thousand lines of code for all the elements?)
 */
public class Element
{
    private string name;
    private string symbol;
    private int atomNum;
    private int neutrons;
    private int metalType; //0 is Metal, 1 is Non-Metal, 2 is Metalloid, 3 is Synthetic
    private int column; //Represents the group

    public Element(string name, string symbol, int atomNum, int neutrons, int metalType, int column)
    {
        this.name = name;
        this.symbol = symbol;
        this.atomNum = atomNum;
        this.neutrons = neutrons;
        this.metalType = metalType;
        this.column = column;
    }

    public string getName()
    {
        return name;
    }

    public int getType()
    {
        return metalType;
    }

    public string getSymbol()
    {
        return symbol;
    }

    public int getAtomicNumber()
    {
        return atomNum;
    }

    public int getNeutrons()
    {
        return neutrons;
    }

    public int getGroup()
    {
        return column;
    }

    /*
     * Useful method for calculating charge of an ion, returns -6 if its a non-fixed element
     */
    public int getCharge()
    {
        //First check for the metals that have fixed charges
        if (symbol.Equals("Zn") || symbol.Equals("Ni"))
        {
            return 2;
        }

        if (symbol.Equals("Ag"))
        {
            return 1;
        }

        //Deal with the Alkali/Alkali Earth Metals
        if(column <= 2)
        {
            return column;
        }

        if (metalType == 0) //Is a metal
        {
            if (column == 13)
            {
                return 3;
            }else
            {
                return -6;
            }
        }

        if (metalType == 1 || metalType == 2) //Is a non-metal/metalloid
        {
            return 18 - column;
        }

        return -6;
    }

    public int getMass()
    {
        return neutrons + atomNum;
    }
}