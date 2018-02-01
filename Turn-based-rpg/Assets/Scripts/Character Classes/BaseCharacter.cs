using UnityEngine;
using System.Collections;

public class BaseCharacter : MonoBehaviour {

    private string characterClassName;
    private string characterClassDescription;
    //Stats
    private int strength;
    private int intelligence;
    private int dexterity;
    private int speed;
    private int vitality;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int Vitality
    {
        get { return vitality; }
        set { vitality = value; }
    }
}
