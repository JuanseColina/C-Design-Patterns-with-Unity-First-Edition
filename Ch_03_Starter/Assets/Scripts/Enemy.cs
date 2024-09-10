using System;
using UnityEngine;

public interface IPrototype
{
    IPrototype ShallowClone();
    IPrototype DeepClone();
}

public class Enemy : IPrototype
{
    public int Damage;
    public string Message;
    public string Name;

    public Item Item;

    public Enemy(int dmg, string msg, string name, Item item)
    {
        Damage = dmg;
        Message = msg;
        Name = name;
        Item = item;
    }

    public void Print()
    {
        Debug.LogFormat($"{Message}! {Name} has a {Item.Name}" +
                        $" and can hit for {Damage} HP.");
    }

    public IPrototype ShallowClone()
    {
        //1
        IPrototype newPrototype;
        //2
        try
        {
            //3
            newPrototype = (IPrototype) this.MemberwiseClone();
        }
        //4
        catch (Exception e)
        {
            Console.WriteLine("Error cloning: " + e);
            throw;
        }
        return newPrototype;
    }

    public IPrototype DeepClone()
    {
        Enemy newPrototype = (Enemy) ShallowClone();

        newPrototype.Item = new Item(this.Item.Name);

        return newPrototype;
    }
}