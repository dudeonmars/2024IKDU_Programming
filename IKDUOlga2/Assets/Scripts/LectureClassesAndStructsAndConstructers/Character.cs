using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character {
    public string name; 
    public int exp; 

    public Character() {
        this.name = "Name not given";
        this.exp = 0;
    }

    public Character(string name) {
        this.name = name;
    }

    public Character(string name, int exp) {
        this.name = name;
        this.exp = exp;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.Log($"Name: {name}, Exp: {exp}");
    }

    public string GetCharacterName() {
        return this.name;
    }
}
