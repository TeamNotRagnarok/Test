using UnityEngine;
using System.Collections;

public class BaseWarrior : BaseCharacter {

    public BaseWarrior()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "Strong Melee Fighter.";
        Strength = 15;
        Intelligence = 7;
        Dexterity = 10;
        Speed = 10;
        Vitality = 13;
    }
}
