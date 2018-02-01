using UnityEngine;
using System.Collections;

public class BaseMage : BaseCharacter {

    public BaseMage()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "Strong Magic User.";
        Strength = 7;
        Intelligence = 15;
        Dexterity = 10;
        Speed = 10;
        Vitality = 9;
    }

}
