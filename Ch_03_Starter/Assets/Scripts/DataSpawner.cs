using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSpawner : MonoBehaviour
{
    void Start()
    {
        Enemy ogre = new Enemy(10, "RAWR", "Ogre");
        ogre.Print();
        IPrototype clonedPrototype = ogre.ShallowClone();

        if (clonedPrototype is Enemy clonedEnemy)
        {
            clonedEnemy.Print();
            ogre.Name = "Monstrous Ogre";
            ogre.Damage = 30;
            ogre.Print();
            clonedEnemy.Print();
        }
        else
        {
            Debug.Log("Failed to clone ogre. Cloned object is not an Enemy...");
        }
    }
}