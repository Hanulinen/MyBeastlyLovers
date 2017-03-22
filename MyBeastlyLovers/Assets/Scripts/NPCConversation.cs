using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCConversation : MonoBehaviour {

    //Is true if player is next to an NPC.
    bool nextToNPC;
    //Is true if a conversation is playing.
    bool conversationPlaying;
    //Test iterator to demonstrate changing text.
    int i;
    //There are 3 types of NPC's. Lovers, Major NPC's and Minor NPC's.
    //Depending on the type, a different type of conversation is needed.
    public int NPCType;
    //A random number that determines the dialogue spoken by the minor NPC;
    int rand;
    //Button that plays the role of a textbox.
    Button TextBox;
    //Text in the button.
    Text myText;
    //Script where all the dialogue is located.
    DialogueLists dialogues;

	void Start () {
        nextToNPC = false;
        conversationPlaying = false;
        i = 1;
        TextBox = GameObject.Find("TextBox").GetComponent<Button>();
        if (NPCType == 1)
        {
            TextBox.onClick.AddListener(() => NextTextOne());
        }
        else if(NPCType == 2)
        {
            TextBox.onClick.AddListener(() => NextTextTwo());
        }
        else
        {
            TextBox.onClick.AddListener(() => NextTextThree());
        }
        myText = GameObject.Find("Text").GetComponent<Text>();
        TextBox.gameObject.SetActive(false);
        dialogues = GameObject.Find("Gameplay").GetComponent<DialogueLists>();
	}
	
	// Update is called once per frame
	void Update () {
        //If conversation is playing and player presses E, the next textbox is loaded;
        if (Input.GetKeyDown(KeyCode.E) && conversationPlaying)
        {
            if (NPCType == 1)
            {
                NextTextOne();

            }
            else if (NPCType == 2)
            {
                NextTextTwo();
            }
            else
            {
                NextTextThree();
            }
        }
        //Checks every frame if player is next to an npc and E is pressed.
        if (Input.GetKeyDown(KeyCode.E)&&nextToNPC)
        {
            Debug.Log("Conversation started");
            conversationPlaying = true;
            //Textbox is set active when conversation starts.
            TextBox.gameObject.SetActive(true);
            //NPC's type determines the flow of conversation;
            if (NPCType == 1)
            {
                //A random interer is created to take a random line from a minor NPC's dialogue list.
                rand = Random.Range(0, 3);
                myText.text = dialogues.example[rand];

            }
            else if (NPCType == 2)
            {
                //Example text.
                myText.text = "This is example dialogue.";
            }
            else
            {
                //Example text.
                myText.text = "This is example dialogue.";
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
    //Is executed when button (textbox) is pressed.
    void NextTextOne()
    {
        //Minor NPC's only speak one line of dialogue every time you speak to them, therefore the textbox closes after one line.
        TextBox.gameObject.SetActive(false);
        //Conversation is over.
        conversationPlaying = false;
    }
    void NextTextTwo()
    {
        myText.text = "This is text number " + i;
        i++;
        //Conversation is over.
        conversationPlaying = false;
    }
    void NextTextThree()
    {
        myText.text = "This is text number " + i;
        i++;
        //Conversation is over.
        conversationPlaying = false;
    }
}
