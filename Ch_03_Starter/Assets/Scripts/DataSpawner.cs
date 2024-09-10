using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSpawner : MonoBehaviour
{
    void Start()
    {
        Factory<IPrototype> factory = new Factory<IPrototype>();
        //2
        factory["Ogre"] = new Enemy(10,"RAWR", "Ogre", new Item("Poison dart"));
        factory["Knight"] = new Enemy(15, "To Arms!", "Ash Knight", new Item("Shuriken"));
        
        //3
        IPrototype ogrePrototype = (Enemy) factory["Ogre"].DeepClone();
        IPrototype knightPrototype = (Enemy) factory["Knight"].DeepClone();
        
        //4
        if (ogrePrototype is Enemy ogreEnemy)
        {
            ogreEnemy.Print();
        }

        if (knightPrototype is Enemy knightEnemy)
        {
            knightEnemy.Print();
        }
    }
}