using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compound
{
      private string name;
      private Element[] atoms;
      private int[] numberOfAtoms;
      private string[] prefixes = {"mono","di","tri","tetra","penta","hexa","hepta","oct","nona","deca"};
      private string[] romanNumerals = {"I","II","III","IV"};

        public Compound(Element[] atoms, int[] numberOfAtoms)
        {
            this.atoms = atoms;
            this.numberOfAtoms = numberOfAtoms;
        }

        public string getName()
        {
            return name;
        }

        public Element[] getAtoms()
        {
            return atoms;
        }

        public int[] getNumberOfAtoms()
        {
           return numberOfAtoms;
        }

        public int getCompoundMass(){
            int massSum = 0;

            for(int i = 0; i < atoms.Length; i++)
            {
                massSum += atoms[i].getMass() * numberOfAtoms[i];
            }

            return massSum;
        }

        //create name
        // so do we need to declare the metals and nonmetals.
        //the metal is written first and then the non-metal the suffix ide is added to the non metal.
        // to get the charge make a class with charges
        //only use numeric prefixes on covalent, molecular compounds


        //ionic
        public string getCompoundName(){
            int numberOfA = numberOfAtoms[0];
            int numberOfA2 = numberOfAtoms[1];

            if(atoms[0].getType() == 0 && atoms[1].getType() == 1){
                 string firstPre = prefixes[numberOfA - 1];
                 string secondPre = prefixes[numberOfA2 - 1];
                 return firstPre + atoms[0].getName() + " " + secondPre + atoms[1].getName() + "ide";

            }
            //molecular:covalent with a fix charge. 1,2,3, 13-18
             if(atoms[1].getType() == 0 && atoms[1].getType() == 1){

            return atoms[0].getName() +  atoms[1].getName() ;
            }
            return "not a compound";
        }





}

