﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCConversation : MonoBehaviour {

    //Is true if player is next to an NPC.
    bool nextToNPC;
    //Is true if a conversation is playing.
    bool conversationPlaying;
    //Indicates whether or not this is the first conversation with lover. Initialized to true.
    bool firstConversation;
    //Indicates whether or not player has seen the tutorial from pope. Initialized to false.
    bool tutorialCompleted;
    //Test iterator to demonstrate changing text.
    int i;
    //There are 3 types of NPC's. Lovers, Major NPC's and Minor NPC's.
    //Depending on the type, a different type of conversation is needed.
    public int NPCType;
    //A random number that determines the dialogue spoken by the minor NPC;
    int rand;
    //Lover-NPC's have a love level variable that determines their familiarity with the main character an thus their lines;
    int lovelevel;
    //Every NPC has a name that is used to get their own lines from the script file.
    public string NPCName;
    //Button that plays the role of a textbox.
    Button TextBox;
    //Text in the button.
    Text myText;
    //Script where all the dialogue is located.
    DialogueLists dialogues;
    //Accesses the script Textbox to turn on and off the textbox
    Textbox myTextbox;

	void Start () {
        nextToNPC = false;
        conversationPlaying = false;
        firstConversation = true;
        tutorialCompleted = true;
        i = 1;
        TextBox = GameObject.Find("TextBox").GetComponent<Button>();
        myTextbox = GameObject.Find("TextBox").GetComponent<Textbox>();
        if (NPCType == 1)
        {
            TextBox.onClick.AddListener(() => NextTextMinor());
        }
        else if(NPCType == 2)
        {
            TextBox.onClick.AddListener(() => NextTextMajor());
        }
        else
        {
            TextBox.onClick.AddListener(() => NextTextLover());
        }
        myText = GameObject.Find("Text").GetComponent<Text>();
        dialogues = GameObject.Find("Gameplay").GetComponent<DialogueLists>();
        lovelevel = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //If conversation is playing and player presses E, the next textbox is loaded;
        if (Input.GetKeyDown(KeyCode.E) && conversationPlaying)
        {
            if (NPCType == 1)
            {
                NextTextMinor();

            }
            else if (NPCType == 2)
            {
                NextTextMajor();
                myTextbox.SetTextBoxActive();
                conversationPlaying = false;
            }
            else
            {
                NextTextLover();
            }
        }
        //Checks every frame if player is next to an npc and E is pressed.
        if (Input.GetKeyDown(KeyCode.E)&&nextToNPC&&!conversationPlaying)
        {
            Debug.Log("Conversation started");
            conversationPlaying = true;
            //Textbox is set active when conversation starts.
            myTextbox.SetTextBoxActive();
            //NPC's type determines the flow of conversation;
            if (NPCType == 1)
            {
                //A random interer is created to take a random line from a minor NPC's dialogue list.
                rand = Random.Range(0, 3);
                myText.text = dialogues.GetLinesMinor(NPCName,rand);

            }
            else if (NPCType == 2)
            {
                myText.text = dialogues.GetLinesMajor(NPCName, 0);
               // myTextbox.SetTextBoxInactive();
                conversationPlaying = false;
            }
            else
            {
                myText.text = dialogues.GetLinesLover(NPCName, 0, lovelevel, firstConversation, tutorialCompleted);
            }
        }

    }
    //Is executed when trigger is activated.
    void OnTriggerEnter2D(Collider2D col)
    {
        nextToNPC = true;
    }
    //Is executed when trigger is deactivated.
    void OnTriggerExit2D(Collider2D col)
    {
        nextToNPC = false;
    }
    //Is executed every frame trigger is active.
    //For some reason only works when player is moving.
    void OnTriggerStay2D(Collider2D other)
    {
        
    }
    //Is executed when button (textbox) or USE button is pressed.
    void NextTextMinor()
    {
        //Minor NPC's only speak one line of dialogue every time you speak to them, therefore the textbox closes after one line.
        myTextbox.SetTextBoxInactive();
        //Conversation is over.
        conversationPlaying = false;
    }
    void NextTextMajor()
    {
        myText.text = "This is text number " + i;
        i++;
        //Conversation is over.
        conversationPlaying = false;
    }
    void NextTextLover()
    {
        if (dialogues.currentConversationLength == dialogues.i)
        {
            //Conversation is over. Textbox is deactivated. Dialogue iterator returned to beginning.
            myTextbox.SetTextBoxInactive();
            conversationPlaying = false;
            dialogues.ReturnIteratorToTheBeginning();
            firstConversation = false;
        }
        else
        {
            //Next line from conversaion is shown.
            myText.text = dialogues.GetLinesLover(NPCName, 0, lovelevel, firstConversation, tutorialCompleted);
        }
        
    }
}
