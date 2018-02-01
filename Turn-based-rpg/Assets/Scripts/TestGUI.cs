using UnityEngine;
using System.Collections;

public class TestGUI : BaseCharacter {

    private BaseCharacter class1 = new BaseWarrior();
    private BaseCharacter class2 = new BaseMage();
    private BaseCharacter class3 = new BaseRogue();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label(class3.CharacterClassName);
        GUILayout.Label(class3.CharacterClassDescription);
    }
}
