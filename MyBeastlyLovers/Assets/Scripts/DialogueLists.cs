using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueLists : MonoBehaviour
{
    //Iterator for going through the lists
    public int i;
    //Tells the other script how many lines the current conversation has;
    public int currentConversationLength;
    //Example list
    public List<string> example = new List<string>();
    //Grandma's list
    public List<string> grandma = new List<string>();
    //Guard's list
    public List<string> guard = new List<string>();
    //Eldritch horror's list
    public List<string> horror = new List<string>();
    //Pope's lists
    public List<string> pope_greeting = new List<string>();
    public List<string> pope_tutorial = new List<string>();
    public List<string> pope_flirt = new List<string>();
    //Shopkeeper's lists
    public List<string> shopkeeper_greeting = new List<string>();
    public List<string> shopkeeper_buy = new List<string>();
    public List<string> shopkeeper_flirt = new List<string>();
    //Innkeeper's lists
    public List<string> innkeeper_greeting = new List<string>();
    public List<string> innkeeper_tutorial = new List<string>();
    public List<string> innkeeper_flirt = new List<string>();
    //Yola's lists
    public List<string> yola_first = new List<string>();
    public List<string> yola_greetings = new List<string>();
    public List<string> yola_byes = new List<string>();
    public List<string> yola_hay = new List<string>();
    public List<string> yola_levelup1 = new List<string>();
    public List<string> yola_levelup2 = new List<string>();
    public List<string> yola_levelup3 = new List<string>();
    public List<string> yola_levelup4 = new List<string>();
    public List<string> yola_levelup5 = new List<string>();
    public List<string> yola_gifts = new List<string>();
    public List<string> yola_badgifts = new List<string>();
    public List<string> yola_nothingtosay = new List<string>();
    public List<string> yola_flirts = new List<string>();
    public List<string> yola_wronganswers = new List<string>();
    public List<string> yola_choices = new List<string>();
    public List<string> yola_question1 = new List<string>();
    public List<string> yola_question2 = new List<string>();
    public List<string> yola_question3 = new List<string>();
    public List<string> yola_question4 = new List<string>();
    public List<string> yola_question5 = new List<string>();
    public List<string> yola_question6 = new List<string>();
    public List<string> yola_question7 = new List<string>();
    public List<string> yola_question8 = new List<string>();
    public List<string> yola_question9 = new List<string>();
    public List<string> yola_question10 = new List<string>();
    public List<string> yola_question11 = new List<string>();
    public List<string> yola_question12 = new List<string>();
    public List<string> yola_question13 = new List<string>();
    public List<string> yola_question14 = new List<string>();
    public List<string> yola_question15 = new List<string>();
    public List<string> yola_question16 = new List<string>();
    public List<int> yola_correct = new List<int>();
    //Catherine's lists
    public List<string> catherine_first = new List<string>();
    public List<string> catherine_greetings = new List<string>();
    public List<string> catherine_byes = new List<string>();
    public List<string> catherine_hay = new List<string>();
    //Gru's lists
    public List<string> gru_first = new List<string>();
    public List<string> gru_greetings = new List<string>();
    public List<string> gru_byes = new List<string>();
    public List<string> gru_hay = new List<string>();
    //Bobo's lists
    public List<string> bobo_first = new List<string>();
    public List<string> bobo_greetings = new List<string>();
    public List<string> bobo_byes = new List<string>();
    public List<string> bobo_hay = new List<string>();
    //Therion's lists
    public List<string> therion_first = new List<string>();
    public List<string> therion_greetings = new List<string>();
    public List<string> therion_byes = new List<string>();
    public List<string> therion_hay = new List<string>();
    //Fenris' lists
    public List<string> fenris_first = new List<string>();
    public List<string> fenris_greetings = new List<string>();
    public List<string> fenris_byes = new List<string>();
    public List<string> fenris_hay = new List<string>();

    //LINES ARE ADDED TO THEIR RESPECTIVE LISTS
    //
    void Start()
    {
        i = -1;
        currentConversationLength = 1;
        //Example lines
        example.Add("Get out of my house!");
        example.Add("Take pity on my kitty!");
        example.Add("The Jumping Plague is approaching. I FEEL IT IN MAH BONES!");
        //Grandma's lines
        grandma.Add("Grandma: Geeeet out of my house!");
        grandma.Add("Grandma: Take pity on the kitty.");
        grandma.Add("Grandma: The Jumping Plague approaches, I feel it in my bones!");
        //Guards's lines
        guard.Add("Guard: You can’t leave the town due to the recent outbreak of the Jumping Plague. Watch out for mutants.");
        guard.Add("Guard: Can’t you see I am busy guarding…? Very… bus-zzz….. (He’s fast asleep.)");
        guard.Add("(The guard is snoring.)");
        //Eldritch horror's lines
        horror.Add("???: Mwabbgrgrlrr! (You cannot understand a word it says.)");
        horror.Add("???: Aaaaaughibbrgubugbugrguburgle! (You cannot understand a word it says.)");
        horror.Add("???: Gwwahhrrlgghhbbrr! (You cannot understand a word it says.)");
        //Pope's greeting lines
        pope_greeting.Add("Example of a greeting from pope");
        //Pope's tutorial lines
        pope_tutorial.Add("Example of a tutorial");
        //Pope's answers to flirting lines
        pope_flirt.Add("Example of an answer to flirting");
        //Shopkeeper's greeting lines
        shopkeeper_greeting.Add("Example of a greeting from shopkeeper");
        //Shopkeeper's buying lines
        shopkeeper_buy.Add("Example of a transaction");
        //Shopkeeper's answers to flirting lines
        shopkeeper_flirt.Add("Example of an answer to flirting");
        //Innkeeper's greeting lines
        innkeeper_greeting.Add("Example of a greeting from innkeeper");
        //Innkeeper's tutorial lines
        innkeeper_tutorial.Add("Example of a transaction");
        //Innkeeper's answers to flirting lines
        innkeeper_flirt.Add("Example of an answer to flirting");
        //Yola's First lines
        yola_first.Add("Yola: Ooh! Who approaches little Yola?");
        yola_first.Add("Ghoul: Don’t be afraid, I am friendly.");
        yola_first.Add("Yola: Yola is not afraid, Yola is the one to be afraid of.");
        yola_first.Add("Ghoul: Wha-?");
        yola_first.Add("Yola: Yola! That’s me!");
        //Yola's Greetings
        yola_greetings.Add("Yola: Hi.");
        yola_greetings.Add("Yola: Hello!");
        yola_greetings.Add("Yola: Oh, you came back already!");
        yola_greetings.Add("Yola: Yola greets you, friend!");
        yola_greetings.Add("Yola: Just as Yola started to miss you!");
        yola_greetings.Add("Yola: Hello, Yola’s treasure!");
        //Yola's Goodbyes
        yola_byes.Add("Yola: Bye.");
        yola_byes.Add("Yola: See you.");
        yola_byes.Add("Yola: Bye, friend!");
        yola_byes.Add("Yola: Yola awaits your return.");
        yola_byes.Add("Yola: Yola will miss you.");
        yola_byes.Add("Yola: Don’t leave Yola for too long!");
        //Yola's How Are Yous
        yola_hay.Add("Yola: Yola didn’t think you could speak.");
        yola_hay.Add("Yola: Yola likes the swamp. It is easy to get forever lost here.");
        yola_hay.Add("Yola: Yola doesn’t mind the drowned ones in the swamp, they keep Yola company forever!");
        yola_hay.Add("Yola: Yola found treasures from pockets of the drowned ones. They are gifts for Yola!");
        yola_hay.Add("Yola: Yola knows many secrets of the townsfolk… But Yola won’t tell you any!");
        yola_hay.Add("Yola: Yola doesn’t want you to drown, you are a lot nicer alive!");
        //Yola's Level Up 1
        yola_levelup1.Add("Yola: Yola thinks you are not a complete failure.");
        //Yola's Level Up 2
        yola_levelup2.Add("Ghoul: It was nice to get known with you.");
        yola_levelup2.Add("Yola: But you don’t know who Yola is.");
        yola_levelup2.Add("Ghoul: Yola is you?");
        yola_levelup2.Add("Yola: Yola is me, yes. But who Yola really is, is the secret!");
        yola_levelup2.Add("Ghoul: I’ll keep that in mind.");
        //Yola's Level Up 3
        yola_levelup3.Add("Ghoul: I think you are cute! Cute as a fey can be!");
        yola_levelup3.Add("Yola: Are you suggesting that feys cannot be cute? Is Yola really an ugly creature?");
        yola_levelup3.Add("Ghoul: I didn’t mean it like that! You truly are cute. And I’d like to know you better!");
        yola_levelup3.Add("Yola: Oh? Well, Yola thinks you’re kinda cute too. But Yola will keep an eye on you when you wander around the swamp!");
        yola_levelup3.Add("Ghoul: Have I done something wrong? Don’t you trust me?");
        yola_levelup3.Add("Yola: Yola trusts you, yes. Yola doesn’t want to give you to the swamp yet, so Yola keeps an eye on you!");
        yola_levelup3.Add("Ghoul: Oh, thank you Yola!");
        //Yola's Level Up 4
        yola_levelup4.Add("Yola: Hey! Yola needs to tell you something!");
        yola_levelup4.Add("Ghoul: Has something happened? Are you alright?");
        yola_levelup4.Add("Yola: No, Yola is fine. Better than fine! Yola has been smiling today for all day!");
        yola_levelup4.Add("Ghoul: Oh, is there a particular reason?");
        yola_levelup4.Add("Yola: Yes, there is! You, Yola’s friend! You made Yola’s day by coming here! Yola thinks you’re the best person in this town!");
        yola_levelup4.Add("Ghoul: That is nice to hear, Yola. I think you are cool friend too!");
        yola_levelup4.Add("Yola: Yola wants you to stay a bit longer.Don’t leave right away, please.");
        yola_levelup4.Add("Ghoul: You want to do something special?");
        yola_levelup4.Add("Yola: Hush! Just stand there for a moment.");
        yola_levelup4.Add("Ghoul: …?");
        yola_levelup4.Add("Yola: ... Thanks! Now you can go!");
        yola_levelup4.Add("Ghoul: Well, I’ll be going then. See you again sometime soon!");
        yola_levelup4.Add("Yola: Yola waits for your return, friend!");
        //Yola's Level Up 5
        yola_levelup5.Add("Yola: Listen! Yola has important stuff to say!");
        yola_levelup5.Add("Ghoul: Okay, I am listening. What is it?");
        yola_levelup5.Add("Yola: Yola wants you to know that Yola doesn’t want you to become a drowned… Yola will never let the swamp take you.");
        yola_levelup5.Add("Ghoul: That is nice to hear, Yola. Is there any specific reason for you to not want me to drown in the swamp?");
        yola_levelup5.Add("Yola: You mean a lot for Yola. More than any treasure. Yola likes everything shiny but you… You are the one Yola truly loves!");
        yola_levelup5.Add("Ghoul: What are you saying? Are you sure?");
        yola_levelup5.Add("Yola: Yola is sure! Yola loves you at least the same amount as Yola loves crowns! Yola loves you!");
        yola_levelup5.Add("Ghoul: I must tell that I love you too, Yola");
        yola_levelup5.Add("Yola: Are you kidding Yola?");
        yola_levelup5.Add("Ghoul: There is no reason to! You are one of the most wonderful persons I know!");
        yola_levelup5.Add("Yola: Yola is happy! Yola wants to spend all Yola’s life with you! Yola is yours forever!");
        //Yola's Gifts (positive)
        yola_gifts.Add("Yola: Hmm? What’s this?");
        yola_gifts.Add("Yola: You think that Yola likes something like this?");
        yola_gifts.Add("Yola: Yola thanks you but next time bring something shinier!");
        yola_gifts.Add("Yola: Yola likes this!");
        yola_gifts.Add("Yola: This is a lovely gift for Yola! Thank you!");
        yola_gifts.Add("Yola: Yola likes you more than anything! Yola likes your gifts even more!");
        yola_gifts.Add("Yola: Thank you! Yola is now forever happy! Yola will never be sad again! Never! Yola can smile every day from now on!");
        //Yola's Gifts (negative)
        yola_badgifts.Add("Yola: Ewwww. No thanks!");
        yola_badgifts.Add("Yola: Please take that away from Yola.");
        yola_badgifts.Add("Yola: Yola doesn’t want that.");
        yola_badgifts.Add("Yola: A good friend would never give that to Yola.");
        yola_badgifts.Add("Yola: Yola thinks you are cute but Yola thinks that isn’t.");
        yola_badgifts.Add("Yola: Thanks, but no thanks!");
        //Yola has nothing to say
        yola_nothingtosay.Add("Yola: Yes?");
        yola_nothingtosay.Add("Yola: Bees go “Bzzz” and Yola goes “Zzzz”.");
        yola_nothingtosay.Add("Yola: Yola doesn’t have anything more to say.");
        //Yola's flirts
        yola_flirts.Add("Ghoul: Are your pants a compressed file? Because I'd like to unzip them.");
        yola_flirts.Add("Yola: You are weird. Do you know who you are talking to?");
        yola_flirts.Add("Ghoul: You are so pretty that I forgot my best pick-up line!");
        yola_flirts.Add("Yola: What’s that…? Do you remember what Yola told you about the swamp?");
        yola_flirts.Add("Ghoul: Do you believe in love at first sight or should I walk past you again?");
        yola_flirts.Add("Yola: Yola thinks that you are funny! Can you tell what Yola does to the drowned?");
        yola_flirts.Add("Ghoul: What would you like to have for breakfast at my place?");
        yola_flirts.Add("Yola: You make Yola smile. Tell me, what Yola is?");
        yola_flirts.Add("Ghoul: You want to share something else than just opinions?");
        yola_flirts.Add("Yola: Yola will share you something: a fist in your eye socket. You remember who puts up the lights in the swamp?");
        yola_flirts.Add("Ghoul: Hi, what's a girl like you doing in a lovely place like this?");
        yola_flirts.Add("Yola: The swamp is nice! Tell me, what do townsfolk think about the swamp?");
        yola_flirts.Add("Ghoul: Pardon me, but what pickup line works best with you?");
        yola_flirts.Add("Yola: Teehee! Yola is amused. Do you remember what Yola told you about Yola’s family?");
        yola_flirts.Add("Ghoul: Yola, do y-.");
        yola_flirts.Add("Yola: Hush! Can you remember what you were told about family members?");
        yola_flirts.Add("Ghoul: I miss my teddy bear. Would you sleep with me?");
        yola_flirts.Add("Yola: You are amusing little thing! Yola told you something about Yola’s way of living, remember?");
        yola_flirts.Add("Ghoul: Hey, somebody farted. Let's get out of here.");
        yola_flirts.Add("Yola: Don’t worry, it’s just gas from the swamp. What do Yola’s sisters do for living?");
        yola_flirts.Add("Ghoul: I looked up the word 'beautiful' in the dictionary today, and your name was included.");
        yola_flirts.Add("Yola: Really ? !Can you remember what Yola fears?");
        yola_flirts.Add("Ghoul: Your daddy must have been a baker, 'cause you've got a nice set of buns.");
        yola_flirts.Add("Yola: Giggle!Do you know what Yola thinks about moving into the town?");
        yola_flirts.Add("Ghoul: Can I check your shirt label to see if you are made in heaven?");
        yola_flirts.Add("Yola: Shirt label…? Do you remember what Yola wants to find?");
        yola_flirts.Add("Ghoul: If I could rearrange the alphabet, I'd put U and I together.");
        yola_flirts.Add("Yola: Yola doesn’t know what an alphabet is! But do you know what Yola knows?");
        yola_flirts.Add("Ghoul: If I told you had a beautiful body, would you hold it against me?");
        yola_flirts.Add("Yola: Yola likes your funny questions! Yola told you what Yola wants from the townsfolk, remember?");
        //Yola's flirt choices
        /*2*/ yola_choices.Add("Yoda"); yola_choices.Add("Yola"); yola_choices.Add("Yolandi");
        /*2*/ yola_choices.Add("People come here for picnics") ; yola_choices.Add("People drown here after following floating lights"); yola_choices.Add("You don’t like the swamp");
        /*1*/ yola_choices.Add("You take stuff from their pockets."); yola_choices.Add("You drag them out of the swamp"); yola_choices.Add("You try to stay as far as possible from them");
        /*1*/ yola_choices.Add("You are a fey"); yola_choices.Add("You are a pixie"); yola_choices.Add("You are a sprite");
        /*2*/ yola_choices.Add("Orcs"); yola_choices.Add("You"); yola_choices.Add("Townsfolk");
        /*2*/ yola_choices.Add("That the swamp is lovely"); yola_choices.Add("That the swamp is dangerous"); yola_choices.Add("That there is no swamp");
        /*3*/ yola_choices.Add("You and your mother are really close"); yola_choices.Add("You and your brother are the only ones in your family"); yola_choices.Add("You don’t remember having parents but you have lots of sisters");
        /*1*/ yola_choices.Add("You want your sisters to stay away"); yola_choices.Add("You want to find your sisters"); yola_choices.Add("You didn’t tell me anything about them?");
        /*2*/ yola_choices.Add("You work as a waiter in the tavern"); yola_choices.Add("You loot pockets of the drowned"); yola_choices.Add("You work as a waiter in the tavern");
        /*1*/ yola_choices.Add("They lure people into swamps and then they loot their pockets"); yola_choices.Add("They have a restaurant in the capital"); yola_choices.Add("There are no sisters");
        /*3*/ yola_choices.Add("Nothing"); yola_choices.Add("The Drowned"); yola_choices.Add("Dragons");
        /*2*/ yola_choices.Add("You want to move there as soon as possible"); yola_choices.Add("You would never move there"); yola_choices.Add("Ummmm…?");
        /*2*/ yola_choices.Add("More coins"); yola_choices.Add("A crown"); yola_choices.Add("A diamond");
        /*1*/ yola_choices.Add("You know a lot of secrets about townsfolk"); yola_choices.Add("You know how to bake a cake"); yola_choices.Add("You know where to find the best meals around the town");
        /*3*/ yola_choices.Add("You want them to give you gifts"); yola_choices.Add("You want them to stop coming here"); yola_choices.Add("You want them to see how beautiful the swamp is");
        //Yola's flirt correct answers
        yola_correct.Add(2); yola_correct.Add(2); yola_correct.Add(1); yola_correct.Add(1); yola_correct.Add(2);
        yola_correct.Add(2); yola_correct.Add(3); yola_correct.Add(1); yola_correct.Add(2); yola_correct.Add(1);
        yola_correct.Add(3); yola_correct.Add(2); yola_correct.Add(2); yola_correct.Add(1); yola_correct.Add(2);
        //Yola's flirt wrong answers
        yola_wronganswers.Add("Yola: Yola doesn’t like you at all.");
        yola_wronganswers.Add("Yola: Yola thinks you are stupid.");
        yola_wronganswers.Add("Yola: Sigh... Yola must be the only smart person in this world.");
        yola_wronganswers.Add("Yola: Silly little friend, Yola thinks you are not listening a word Yola says!");
        yola_wronganswers.Add("Yola: Yola thinks that you should know Yola better by now.");
        //Yola's questions and answers
        //1
        yola_question1.Add("Ghoul: Who are you ?");
        yola_question1.Add("Yola: Don’t you already know who Yola is? Yola is me! I am Yola!");
        //2
        yola_question2.Add("Ghoul: You live here all alone?");
        yola_question2.Add("Yola: Yola lives here yes but not alone! Yola has drowned ones under the water!");
        //3
        yola_question3.Add("Ghoul: Can you tell me anything about this place?");
        yola_question3.Add("Yola: Swamp takes the drowned. Yola takes treasures from the drowned. Circle of life: it all ends at Yola’s pocket.");
        //4
        yola_question4.Add("Ghoul: So, you killed all those people to take their riches?");
        yola_question4.Add("Yola: Yola is not a killer, no! They came here themselves. They saw the tiny lights hovering around the swamp and followed them.");
        yola_question4.Add("Yola: Then the swamp took them. And Yola took treasures!");
        //5
        yola_question5.Add("Ghoul: But why you haven’t been taken by the swamp?");
        yola_question5.Add("Yola: Yola is not some simple townsfolk. Yola and the swamp are like best friends.");
        yola_question5.Add("Yola: They help each other out! The swamp doesn’t want to hurt Yola!");
        //6
        yola_question6.Add("Ghoul: What are you exactly?");
        yola_question6.Add("Yola: Aren’t you a silly little thing! Can’t you see that Yola is a fey!");
        //7
        yola_question7.Add("Ghoul: So, it is you who leads people into the swamp during nights by putting up those lights that people follow?");
        yola_question7.Add("Yola: Oh, you figured it out! That is what Yola does! That is how Yola has always been doing!");
        //8
        yola_question8.Add("Ghoul: Isn’t that wrong? I mean, you are killing people!");
        yola_question8.Add("Yola: Yola is not a killer no! Stupid townsfolk should listen to their mothers and not wander around here during night!");
        yola_question8.Add("Yola: Or at least they should learn how to swim… Or not carry such heavy treasures in their pockets…");
        yola_question8.Add("Anyway, Yola doesn’t think it is wrong! Yola too needs a way to live!");
        //9
        yola_question9.Add("Ghoul: Q: What about the townsfolk? They might not like the idea that you are killing them…");
        yola_question9.Add("Yola: Yola never tells them, it is a secret. They only know that the swamp has taken them.");
        yola_question9.Add("Yola: They blame the swamp and think that Yola is cute.");
        //10
        yola_question10.Add("Ghoul: Tell me: who taught you to lure people into the swamp?");
        yola_question10.Add("Yola: Yola doesn’t remember being born. Yola doesn’t remember a mother. Yola has always just been here…");
        yola_question10.Add("Yola: Yola noticed that people like shiny things and are afraid of the dark so they go towards the light during night.");
        yola_question10.Add("Yola: Yola started to put up the lights so that people would come here. Then they started to drown and Yola started to find treasures.");
        yola_question10.Add("Yola: It has always been so and it will forever be so.");
        //11
        yola_question11.Add("Ghoul: So, no parents at all? How about siblings or other family?");
        yola_question11.Add("Yola: Yola doesn’t remember parents but Yola remembers sisters. A lot of sisters. ");
        yola_question11.Add("Yola: Hundreds too many.");
        yola_question11.Add("Yola: Yola is glad that they are not here!");
        yola_question11.Add("Yola: Yola doesn’t want them to take Yola’s treasures!");
        yola_question11.Add("Yola: Yola wants that they stay away!");
        //12
        yola_question12.Add("Ghoul: So, all of you are killers and thieves?");
        yola_question12.Add("Yola: Shut your little noisy mouth! Yola is not a killer! Yola has told that already!");
        yola_question12.Add("Yola: But yes, sisters live around Lagicam’s swamp areas and live the same way Yola does.");
        yola_question12.Add("Yola: They take treasures that no one needs anymore. But they are not killers either! Killing is a no-no!");
        //13
        yola_question13.Add("Ghoul: Will you stop luring people into the swamp at some point? Like when you have enough treasures?");
        yola_question13.Add("Yola: Hmm, Yola has thought about that few times…");
        yola_question13.Add("Yola: Yola thinks that maybe someday Yola has too many treasures and a huge dragon might swoop down and take all of them away from Yola.");
        yola_question13.Add("Yola: So, maybe Yola should stop at some point… ");
        yola_question13.Add("Yola: Yola really doesn’t know but Yola is a bit scared of the dragons… ");
        yola_question13.Add("Yola: But only dragons! Nothing else is scary!");
        //14
        yola_question14.Add("Ghoul: Don’t you think that you already have enough treasures?");
        yola_question14.Add("Ghoul: You cannot even wear all the jewelry and I haven’t seen you use coins at all…");
        yola_question14.Add("Yola: Yola tells you something…");
        yola_question14.Add("Yola: Yola has many lesser trinkets and golden coins but those are not what Yola is looking for!");
        yola_question14.Add("Yola: Yola wants to wear a crown!");
        yola_question14.Add("Yola: Yola must look like a princess so that townsfolk stop thinking that Yola is a dirty creature living in a dirty hole!");
        yola_question14.Add("Yola: Yola is not dirty and the hole is home!");
        //15
        yola_question15.Add("Ghoul: Do you ever think about moving into the town?");
        yola_question15.Add("Yola: No, never!");
        yola_question15.Add("Yola: Hole is home and Yola is happy with all the frogs and the drowned.");
        yola_question15.Add("Yola: Yola just wants others to see the beauty of the swamp. It is not dirty, it is peaceful.");
        //16
        yola_question16.Add("Ghoul: What is your biggest secret?");
        yola_question16.Add("Yola: You already know what Yola does with the lights…");
        yola_question16.Add("Yola: But you don’t know secrets about townsfolk! The innkeeper is not only a pretty face and bountiful bust.");
        yola_question16.Add("Yola: She has been a great hunter before she established the tavern. ");
        yola_question16.Add("Yola: I heard that she even killed the hairless bear with her bare hands.");
        yola_question16.Add("Yola: The pope used to be a dancer and he used to perform to all the rich people before he found the Potato.");
        yola_question16.Add("Yola: Shopkeeper has a secret stash of magical dust you inhale to get a funny feeling of happiness.");

    }

    //LINE GETTERS
    //
    //Returns lines for minor NPC's
    public string GetLinesMinor(string name, int no)
    {
        if(name == "example")
        {
            return example[no];
        }
        else if (name == "Grandma")
        {
            return grandma[no];
        }
        else if (name == "Guard")
        {
            return guard[no];
        }
        else if (name == "Horror")
        {
            return horror[no];
        }
        else
        {
            return "This is an error from GetLinesMinor. You shouldn't be able to see me"; 
        }
    }
    //Return's lines for major NPC's
    public string GetLinesMajor(string name, int no)
    {
        if (name == "Pope")
        {
            return pope_greeting[no];
        }
        else if (name == "Innkeeper")
        {
            return innkeeper_greeting[no];
        }
        else if (name == "Shopkeeper")
        {
            return shopkeeper_greeting[no];
        }
        else
        {
            return "This an error from GetLinesMajor. You shouldn't see me.";
        }
    }
    //Return's lines for lovers
    public string GetLinesLover(string name, int no, int lovelevel, bool first, bool talkedToPope)
    {
        i++;
        if (name == "Bobo")
        {
            return "I am called Bobo for short. You really don't want to try remember the real one.";
        }
        else if (name == "Fenris")
        {
            return "My parent's named me Fenris. I am very proud of that name.";
        }
        else if (name == "Therion")
        {
            return "Therion's mah neem, what of it?";
        }
        else if (name == "Gru")
        {
            return "ME! GRU! HELLO!";
        }
        else if (name == "Yola")
        {
            return YolaLogic(no, lovelevel, first, talkedToPope);
        }
        else if (name == "Catherine")
        {
            return "Pleased to meet you, I am Catherine.";
        }
        else
        {
            return "This an error from GetLinesLover. You shouldn't see me.";
        }
    }

    //FUNCTIONS FOR EACH CHARACTER
    //
    //Yola
    string YolaLogic(int no, int lovelevel, bool first, bool talkedToPope)
    {
        //Happens if first conversation
        if (first && talkedToPope)
        {
            currentConversationLength = yola_first.Count-1;
            return yola_first[i];
        }
        else if (talkedToPope)
        {
            currentConversationLength = 0;
            return yola_greetings[lovelevel];
        }
        else
        {
            return "What are you doing in the swamp?! Go see the pope you silly little thing!";
        }
    }
    //
    //Bobo
    //
    //Therion
    //
    //Catherine
    //
    //Fenris
    //
    //Gru


    //OTHER FUNCTIONS
    //
    //Returns the list iterator back to the beginnig once conversation ends;
    public void ReturnIteratorToTheBeginning()
    {
        i = -1;
    }
}
