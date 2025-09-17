using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int health;
    int power;
    string name;

    public Player(int health, int power, string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;
    }

    public void info()
    {

        Debug.Log("Player health is: " + health);
        Debug.Log("Player power is: " + power);
        Debug.Log("Player name is: " + name);
    }

}
