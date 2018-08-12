using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDialogueAtLine : MonoBehaviour {

    public TextAsset theText;
    public int startLine;
    public int endLine;
    public DialogueWindowManager theDialogueBox;
    public bool destroyWhenActivated;

	// Use this for initialization
	void Start ()
    {
        theDialogueBox = FindObjectOfType<DialogueWindowManager>();
	}
	
	// Update is called once per frame
	void Update (){}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                theDialogueBox.ReloadScript(theText);
                theDialogueBox.currentLine = startLine;
                theDialogueBox.endAtLine = endLine;
                theDialogueBox.EnableTextBox();
            }

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }

        }
    }
}
