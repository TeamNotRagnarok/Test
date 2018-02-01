using UnityEngine;
using System.Collections;

public class BaseRogue : BaseCharacter {

    public BaseRogue()
    {
        CharacterClassName = "Rogue";
        CharacterClassDescription = "Quick melee fighter.";
        Strength = 12;
        Intelligence = 9;
        Dexterity = 14;
        Speed = 12;
        Vitality = 12;
    }

}
