using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Game
    {
        public static List<Item> Inventory = new List<Item>();

        static string Place = "";
        static string Act = "";
        static string Input = "";

        //Been to Places
        static bool BeenToDiner = false;
        static bool BeenToLibrary = false;
        static bool BeenToDocks = false;

        //Gotten Clue
        static bool GotWholesaleTrouble = false;
        static bool GotNewShampoo = false;
        static bool GotDocks = false;
        static bool GotAngryMal = false;
        static bool GotMurderWeapon = false;
        static bool GotPlantMatter = false;
        static bool GotRobbiePie = false;
        static bool GotPineappleVoid = false;
        static bool GotDeweyCake = false;
        static bool GotDeweyCompany = false;
        static bool GotPieArticle = false;
        static bool GotWageArticle = false;
        static bool GotPineappleArticle = false;
        static bool GotDriscollArticle = false;
        static bool GotCompanyInfo = false;
        static bool GotSmuggling = false;

        //Locked Places
        static bool kitchen = false;
        static bool docks = false;

        //Locked Topics
        static bool pineappleShakes = false;
        static bool pineapplesPolice = false;
        static bool pineappleLibrary = false;
        static bool drSillCo = false;
        static bool payCut = false;
        static bool pieContest = false;
        static bool pineappleBan = false;
        static bool driscoll = false;

        //Character Name
        static string Title = "Ms.";
        static string FirstName = "Tenacity";
        static string LastName = "Flatfoot";

        //Print out game title and overview
        public static void StartGame()
        {
            //statements
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("The Case of the Purloined Pineapple");
            NameCharacter();
        }
        //Ask player for name and save it
        static void NameCharacter()
        {
            Console.WriteLine("Please give your detective a first name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Please give your detective a last name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Does your detective use Ms, Mr, Mx, or something else?");
            Title = Console.ReadLine();
            Console.Title = $"{FirstName} {LastName} and the Case of the Purloined Pineapple";
            Console.WriteLine($"Great! You will play as {Title} {FirstName} {LastName}, teen detective.");
            Console.WriteLine("Press enter to continue, press x to check your clue book");
            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            Intro();
        }

        static void Intro()
        {
            Console.Clear();
            Console.WriteLine($"You are at the kitchen table drinking hot cocoa and eating eggs and toast when your mother looks up \n" +
                $"from her newspaper. \n" +
                $"'Oh, good Lord. You know Blanche Branson, the cook over at Copse Diner?' \n" +
                $"You nod. Copse has the best milkshakes in town, and Blanche knows you by name. \n" +
                $"'Oh honey, I'm sorry to break it to you, but... She's dead. They found her in the kitchen.' \n" +
                $"A pit seems to form in your stomach. \n" +
                $"'Do they have any leads?' you ask. \n" +
                $"'I don't know. The paper doesn't say.' \n" +
                $"You wolf down the rest of your breakfast, then grab your bag and head for the door. \n" +
                $"'Wait, {FirstName}, where are you going?' your mother calls after you. \n" +
                $"'I'm going to figure this out,' you reply, then step out the door into the foggy morning air.");
            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            Move();
        }

        static void Move()
        {
            Console.Clear();
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine("1. The Diner");
            Console.WriteLine("2. The Library");
            Console.WriteLine("3. The Police Station");
            if (docks == true)
            {
                Console.WriteLine("4. The Docks");
            }

            Place = Console.ReadLine();
            if (Place == "1")
            {
                if (BeenToDiner == false)
                {
                    Diner();
                }
                else
                {
                    DinerAct();
                }
            }
            else if (Place == "2")
            {
                if (BeenToLibrary == false)
                {
                    Library();
                }
                else
                {
                    LibraryAct();
                }
            }
            else if (Place == "3")
            {
                PoliceStation();
            }
            else if (Place == "4" && docks == true)
            {
                if (BeenToDocks == false)
                {
                    Docks();
                }
                else
                {
                    DocksAct();
                }
            }
            else if (Place.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
                Move();
            }
            else
            {
                Console.WriteLine("That is not a valid place.");
                Input = Console.ReadLine();
                if (Input.ToLower() == "x")
                {
                    Menu();
                    Console.ReadLine();
                }
                Move();
            }

        }

        static void Diner()
        {
            Console.Clear();
            BeenToDiner = true;
            Console.WriteLine($"Copse Diner is a round building with a statue of a cow on the roof and an electric sign that \n" +
                $"usually displays the day's specials out front. Today, however, the sign is cycling through four lines: \n" +
                $"'Rest in Peace Blanche \n" +
                $"You will be missed \n" +
                $"We are closed for the \n" +
                $"forseeable future' \n" +
                $"Through the windows that cover the front of the building, you can see three figures inside. Two of them seem to \n" +
                $"be police officers. The bell of the door jingles as you enter and you hear a familiar but forlorn voice say, \n" +
                $"'Sorry, we're clo-- Oh, {FirstName}!' \n" +
                $"Your best friend, Mallory McCarthy runs over from where she was conversing with the policemen and wraps you in a \n" +
                $"big hug. Her soft, curly red hair brushes your nose and you notice that she smells like pineapples. \n" +
                $"'{FirstName}, it's horrible! You heard what happened, right?' she asks, and you nod. \n" +
                $"'Yeah, I heard. Don't worry, Mal. I'm going to get to the bottom of this.' \n" +
                $"Mallory pulls away. 'Don't you think that's a bit out of your pay grade? I mean, it's one thing when we're \n" +
                $"running around, figuring out who sabotaged the school play, but this is an actual murder!' \n" +
                $"'That may be,' you say. 'But I want to know who did this, and I absolutely refuse to just sit by and let the \n" +
                $"police try to figure it out themselves.' You drop your voice to a whisper and adopt a slight mischievous smile. \n" +
                $"'You know they're not the most competent bunch.' \n" +
                $"This makes Mallory smile a little. 'Well, good luck. Oh, and here-- take this.' She pulls a scrap of paper out of \n" +
                $"her pocket and gives it to you. 'I found it on the fridge. Blanche must have written it last night and left it for \n" +
                $"me to see this morning. Maybe it'll help with your investigation.'\n");
            var Note = new Item("Note from Blanche", "A note from Blanche to Mallory, stuck on the diner fridge. Reads, 'M, don't \n" +
                "forget to set the sign to pineapple shakes -B'. It is written in red pen.");
            Note.AddClue(Inventory);
            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            DinerAct();
        }

        static void DinerAct()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Talk to Mallory");
            Console.WriteLine("2. Talk to the police");
            Console.WriteLine("3. Leave");
            if (kitchen == true)
            {
                Console.WriteLine("4. Go into the kitchen");
            }

            Act = Console.ReadLine();
            if (Act == "1")
            {
                DinerTalkMal();
            }
            else if (Act == "2")
            {
                DinerTalkPolice();
            }
            else if (Act == "3")
            {
                Move();
            }
            else if (Act == "4" && kitchen == true)
            {
                DinerKitchen();
            }
            else if (Act.ToLower() == "x")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("That is not a valid action.");
                DinerAct();
            }

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            DinerAct();
        }

        static void DinerTalkMal()
        {
            Console.Clear();
            Console.WriteLine("The tables at Copse are standing tables, with tall stools around them. Mallory sits at the table \n" +
                "closest to the door, still (understandably) looking shaken. You walk over and sit down next to her. 'Is there \n" +
                "anything you can tell me about what happened? I take it you weren't here at the time,' you say. Mallory nods. \n" +
                "'I don't know how helpful I can be, but I'll tell you what I know,' she says.");

            Console.WriteLine("What do you want to ask Mallory about?");
            Console.WriteLine("1. When did you see her last?");
            Console.WriteLine("2. Did she have any enemies?");
            Console.WriteLine("3. Why do you smell like pineapples?");
            Console.WriteLine("4. Nevermind.");
            if (pineappleShakes == true)
            {
                Console.WriteLine("5. Why aren't there any pineapples in the kitchen?");
            }

            if (payCut == true)
            {
                Console.WriteLine("6. How did you feel about the pay cut?");
            }

            Act = Console.ReadLine();
            Console.Clear();
            if (Act == "1")
            {
                Console.WriteLine("Mallory closes her eyes to focus. 'I last saw Blanche yesterday when I left work. I remember that \n" +
                     "she seemed smug about something at the time, but all she would say about it was that she had negotiated with \n" +
                     "the produce guys and gotten a really good fruit deal. Then I went home. I didn't know anything was wrong until \n" +
                     "I came in today and.... found her.' Tears have begun rolling down her face, and she wipes her eyes with her \n" +
                     "sleeve. You give her a hug. After a moment, she looks up. 'Oh, right. I found the note before that. It was \n" +
                     "stuck up on the fridge.'");
            }
            else if (Act == "2")
            {
                Console.WriteLine("'Oh gosh,' she says, frowning. 'I don't really know. I don't think so. I mean, who actually has \n" +
                     "enemies? I guess the only thing would be that she was always arguing with the wholesale people about prices \n" +
                     "and amounts.");
                if (GotWholesaleTrouble == false)
                {
                    var WholesaleTrouble = new Item("Wholesale Trouble", "Blanche argued with her suppliers often.");
                    WholesaleTrouble.AddClue(Inventory);
                    GotWholesaleTrouble = true;
                }
            }
            else if(Act == "3")
            {
                Console.WriteLine("Mallory frowns. 'I got a new shampoo. Why do you ask?' \n" +
                    "'No reason,' you say.");
                if (GotNewShampoo == false)
                {
                    var NewShampoo = new Item("New Shampoo", "Mallory says that she smells like pineapples because of a new shampoo.");
                    NewShampoo.AddClue(Inventory);
                    GotNewShampoo = true;
                }
            }
            else if (Act == "4")
            {
                DinerAct();
            }
            else if (Act == "5" && pineappleShakes == true)
            {
                Console.WriteLine("Mallory's brow wrinkles in consfusion. \n" +
                    "'Huh? Why do you ask?' she says, and you explain that the note mentions pineapple shakes, but there were no \n" +
                    "pineapples in the kitchen. \n" +
                    "'Oh. That is weird, I guess. We aren't scheduled for any deliveries today, either.' She looks down for a few \n" +
                    "moments, genuinely puzzled. 'I honestly don't know what to tell you about that, other than I'm pretty sure the \n" +
                    "stuff we get imported comes in at the docks, and I think that covers pineapples. That's all I know.'");
                docks = true;
                if (GotDocks == false)
                {
                    var Docks = new Item("Docks", "Blanche's pineapples come in at the docks.");
                    Docks.AddClue(Inventory);
                    GotDocks = true;
                }
            }
            else if (Act == "6" && payCut == true)
            {
                Console.WriteLine("'I mean, not great, I guess,' says Mallory. 'Why do you ask?' \n" +
                    "You open your mouth to speak, but before you can, a look of horror passes over Mallory's face. 'Oh my God. I'm \n" +
                    $"not a suspect, am I?! {FirstName} G. {LastName}, I should hope that after fifteen years of friendship you \n" +
                    $"don't think I'm capable of murder!' \n" +
                    $"You put your hands up placatingly. 'Oh come on, Mal, you know I don't really think that. But this is a murder \n" +
                    $"investigation, and everyone has to be a suspect.' \n" +
                    $"She narrows her eyes at you. 'Well, you're on thin ice, buddy. And if you must know, I was pretty upset about \n" +
                    $"the pay cut at the time. I even applied for some other jobs when it happened, but, uh.' She looks \n" +
                    $"sheepish. 'They all turned me down. So here I am. Happy now?' \n" +
                    $"You nod. She sticks her tongue out at you.");
                if (GotAngryMal == false)
                {
                    var AngryMal = new Item("Angry Mallory", "Mallory was angry about the pay cut, but couldn't find another job.");
                    AngryMal.AddClue(Inventory);
                    GotAngryMal = true;
                }
            }
            else if (Act.ToLower() == "x")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
                Console.ReadLine();
                DinerTalkMal();
            }

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            DinerTalkMal();
        }

        static void DinerTalkPolice()
        {
            Console.Clear();
            Console.WriteLine("Two men are standing near the door to the kitchen; one is in a police uniform, and the other is in a \n" +
                "cheap pair of pants, Hawaiian shirt (tucked in and buttoned all the way) and trenchcoat. As you approach, their \n" +
                "conversation drops off and they turn to look at you. You recognize the one on the right as Robert Riddle, who \n" +
                "you've met on several cases. Seeing you, his expression changes from serious to exhausted. The officer on the \n" +
                "left, whom you don't know, speaks first. \n" +
                $"'Can we help you, {Title}..?' \n" +
                $"'{FirstName} {LastName},' you say. 'I have some questions, if that's alright, Robbie.' \n" +
                $"'We really aren't allowed--' the other officer starts, but Riddle interrupts him. 'No. Just let {Title} \n" +
                $"{LastName} ask. It's just easier that way. But--' He bends down to your height as if speaking to a small child \n" +
                $"and you notice that in his breast pocket is a red pen-- 'This one's not like your other cases, you know. I mean, \n" +
                $"it could have been an accident. She could have slipped and hit her  head. You sure you want to get involved in \n" +
                $"this one?' You nod determinedly. The other officer gives him a skeptical expression, but Riddle nods at you to \n" +
                $"ask away.");

            Console.WriteLine("What do you want to ask the police about?");
            Console.WriteLine("1. What was the cause of death?");
            Console.WriteLine("2. What leads do you have?");
            Console.WriteLine("3. Can I see the crime scene?");
            Console.WriteLine("4. Nevermind.");
            if (pineapplesPolice == true)
            {
                Console.WriteLine("5. Did you find any pineapples in the kitchen?");
            }

            if (pieContest == true)
            {
                Console.WriteLine("6. Tell me about the pie contest.");
            }

            Act = Console.ReadLine();
            Console.Clear();
            if (Act == "1")
            {
                Console.WriteLine("'Hit on the back of the head,' Riddle says, shaking his head. 'Real shame. Blanche was a nice \n" +
                    "lady. We don't have a murder weapon yet, but there was some kind of plant matter in the wound that \n" +
                    "we're analyzing at the lab.");
                if (GotMurderWeapon == false)
                {
                    var MurderWeapon = new Item("Cause of Death", "The cause of death was blunt-force trauma to the back of the \n" +
                        "head. There is unidentified plant matter in the wound. The police have not found a murder weapon.");
                    MurderWeapon.AddClue(Inventory);
                    GotMurderWeapon = true;
                }
            }
            else if (Act == "2")
            {
                Console.WriteLine("Riddle looks grim. 'Well, there's not much to go on. As far as we can figure so far, nobody \n" +
                    "has a motive. The scene's clean as well-- no unusual fingerprints or footprints, no sign of a struggle, \n" +
                    "nothing. It's just a kitchen. Other than, uh, the corpse of course,' he adds sheepishly.");
            }
            else if (Act == "3")
            {
                kitchen = true;
                Console.WriteLine("The officer on the left frowns. 'No way, kid. You don't want to go in there and we definitely \n" +
                    "can't let you in.' You look at Riddle, but he nods in agreement. 'We can't have a kid running around in \n" +
                    "there messing up our crime scene,' the officer continues. Riddle looks up sharply." +
                    $"'Hey now, that's not it. I'd trust {Title} {LastName} not to touch anything. But a woman was murdered in \n" +
                    $"there. It's not a place you want to be.' \n" +
                    $"'Hold up,' says the other man. 'You're saying that if this were a bank robbery or something, you'd just let \n" +
                    $"this kid wander around the crime scene?' \n" +
                    $"'There'd be no stopping that. And I take issue with your tone, Officer. {Title} {LastName}'s solved plenty \n" +
                    $"of cases for the department that even I didn't have a clue on.' \n" +
                    $"'What are you, an imbecile?' \n" +
                    $"The officers are now completely wrapped up in their argument, apparently having forgotten that you're there. \n" +
                    $"You could take this opportunity to get into the kitchen.");
            }
            else if (Act == "4")
            {
                DinerAct();
            }
            else if (Act == "5" && pineapplesPolice == true)
            {
                Console.WriteLine("'What?' asks Riddle. You repeat yourself. 'No, I heard you,' he says. 'But why do you ask?' \n" +
                    "'Blanche had planned for today's special to be pineapple shakes, but there are no pineapples in the kitchen.' \n" +
                    "'Oh. I guess that is weird.' Riddle stops to think for a minute, and then his eyes light up. 'Hey, maybe \n" +
                    "that's the plant matter we found in the kitchen!' The other officer adopts an expression which is somehow even \n" +
                    "more skeptical than before. Riddle doesn't seem to notice. \n" +
                    "'That's exactly what I was thinking,' you say.");
                if (GotPlantMatter == false)
                {
                    var PlantMatter = new Item("Plant Matter", "The plant matter in Blanche's wound may be from a pineapple.");
                    PlantMatter.AddClue(Inventory);
                    GotPlantMatter = true;
                }
            }
            else if (Act == "6" && pieContest == true)
            {
                Console.WriteLine("'Oh, that,' says Riddle. 'Yeah, that was a real shame. My pumpkin pie recipe is my pride and \n" +
                    "joy! I couldn't believe when Blanche won.' He looks away. 'That's all in the past now, of course.' \n" +
                    "If you didn't know better, you'd think Officer Riddle was about to cry. The other officer looks \n" +
                    "uncomfortable. You give Riddle a pat on the back. \n" +
                    "'It's alright Robbie, you'll get it next year,' you say. The other officer looks offended. \n" +
                    "'You're just going to let this kid call you Robbie? Not even your husband calls you Robbie!'");
                if (GotRobbiePie == false)
                {
                    var RobbiePie = new Item("Robbie's Pie", "Robbie was upset that his pie didn't win the contest.");
                    RobbiePie.AddClue(Inventory);
                    GotRobbiePie = true;
                }
            }
            else if (Act.ToLower() == "x")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
                Console.ReadLine();
                DinerTalkPolice();
            }

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            DinerTalkPolice();
        }

        static void DinerKitchen()
        {
            Console.Clear();
            Console.WriteLine("You slip past the arguing officers and through the double swinging doors that lead into the kitchen. \n" +
                "You've been in this kitchen before, when you stopped by to say hello to Mallory on her shift, but it's never been \n" +
                "this quiet or this clean. The island counters in the middle of the wide space are bare, nothing is on the stoves, \n" +
                "and there are no dishes in the sinks. What is there, is the chalk outline of a body on the floor near the outside \n" +
                "door, and a bloodstain. Based on the outline, it seems that Blanche was hit as she was coming into the kitchen \n" +
                "from the outside. The blood must have come from her head wound, and wove its way through the grout between the \n" +
                "tiles like a spiderweb until it hit the walls or counter. It seems that forensics has already come and gone, but \n" +
                "you pull out a pair of woolen gloves anyway, to avoid leaving or disturbing fingerprints. The cabinets, drawers, \n" +
                "and refrigerator all contain what you had expected-- pots, pans, utensils, and ingredients-- other than one \n" +
                "thing. The refrigerator has several kinds of fruit, but no pineapples. You look everywhere, but there's not a \n" +
                "pineapple to be found.");
            if (GotPineappleVoid == false)
            {
                var Pineapple = new Item("Lack of Pineapple", "Despite pineapple shakes being today's special, there are no \n" +
                    "pineapples in the kitchen.");
                Pineapple.AddClue(Inventory);
                GotPineappleVoid = true;
            }
            pineappleShakes = true;
            pineapplesPolice = true;
            pineappleLibrary = true;

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            DinerAct();
        }

        static void Library()
        {
            Console.Clear();
            BeenToLibrary = true;
            Console.WriteLine("Your local library is only a few blocks away from your house, and the tree-filled park across the \n" +
                "street, along with the many trees that line the sidewalks of your neighborhood, give it the impression of being \n" +
                "nestled under a canopy of leaves. The front of the building is full of tall windows, and as you slow your bike and \n" +
                "walk it to the bike rack, you can see the kids' area, where small children are cozily reading in bean-bag chairs. \n" +
                "Inside, you are greeted by Dewey Driscoll, your local librarian. He is a small man whose appearance always reminds \n" +
                "you of a hobbit. He seems to be eating breakfast at his desk. \n" +
                $"'{LastName}! How've ya been? Here to return that Agatha Christie already? That was a fast read!' \n" +
                $"'Unfortunately not,' you respond. 'I'm here on a case. Did you hear about Blanche Branson?' \n" +
                $"'Why, no. What happened to her?' \n" +
                $"'She's been murdered.' \n" +
                $"Dewey stares at you for a few seconds, then says, 'Are you kidding me?' \n" +
                $"'No,' you say. 'But I'm going to get to the bottom of it.' \n" +
                $"Dewey sighs and takes a bite of his breakfast. 'Well, if you need to do any research, the library's always \n" +
                $"open to you. During standard business hours, of course,' he adds.");
            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            LibraryAct();
        }

        static void LibraryAct()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Talk to Dewey");
            Console.WriteLine("2. Check the newspaper archives");
            Console.WriteLine("3. Leave");


            Act = Console.ReadLine();
            if (Act == "1")
            {
                LibraryTalkDewey();
            }
            else if (Act == "2")
            {
                LibraryArchives();
            }
            else if (Act == "3")
            {
                Move();
            }
            else if (Act.ToLower() == "x")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("That is not a valid action.");
                LibraryAct();
            }

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            LibraryAct();
        }

        static void LibraryTalkDewey()
        {
            Console.Clear();
            Console.WriteLine("What do you want to ask Dewey about?");
            Console.WriteLine("1. Did she have any enemies?");
            Console.WriteLine("2. What are you eating?");
            Console.WriteLine("3. Nevermind.");
            if (driscoll == true)
            {
                Console.WriteLine("4. Know anything about Dr Sill & Co?");
            }

            Act = Console.ReadLine();
            Console.Clear();
            if (Act == "1")
            {
                Console.WriteLine("'Hmm,' says Dewey, munching on his breakfast. 'I don't know. I remember that Copse lowered its \n" +
                    "wages a little while ago, but I'm not sure if that was even up to her. I guess there's the pie contest, too, \n" +
                    "but who kills someone over a pie?'");
            }
            else if (Act == "2")
            {
                Console.WriteLine("'This? It's a pineapple upside-down cake. Not the healthiest breakfast, I know, but it's really \n" +
                    "good!' he says. \n" +
                    "You ask if he bought it or made it himself. He hesitates a moment before answering. \n" +
                    "'I bought it. I'm not that good a baker.'");
                if (GotDeweyCake == false)
                {
                    var DeweyCake = new Item("Dewey's Breakfast", "Dewey is eating a pineapple upside-down cake. He claims it is \n" +
                    "store-bought because he is not a good baker.");
                    DeweyCake.AddClue(Inventory);
                    GotDeweyCake = true;
                }
            }
            else if (Act == "3")
            {
                LibraryAct();
            }
            else if (Act == "4" && driscoll == true)
            {
                Console.WriteLine("'Why, yes, actually!' says Dewey. 'Dr. Silas Driscoll was an ancestor of mine. He founded the \n" +
                    "company.' \n" +
                    "'Are you a part of the company?' you ask. \n" +
                    "'Not especially. I've got some.... minor duties I take care of on the shipping end.'");
                if (GotDeweyCompany == false)
                {
                    var DeweyCompany = new Item("Dewey's Ancestor", "Dewey's ancestor founded Dr Sill & Co. He has 'minor duties' for the \n" +
                    "company.");
                    DeweyCompany.AddClue(Inventory);
                    GotDeweyCompany = true;
                }
            }
            else if (Act.ToLower() == "x")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
                Console.ReadLine();
                LibraryTalkDewey();
            }

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            LibraryTalkDewey();
        }

        static void LibraryArchives()
        {
            Console.Clear();
            Console.WriteLine("The library keeps archives of the town newspaper, The Investigator, dating all the way back to its \n" +
                "founding in 1892. They are working on digitizing the entire archive, but what isn't yet in the database can be \n" +
                "found in the Records Room, a dusty, flourescently lit back room of the Library.");

            Console.WriteLine("What do you want to look up?");
            Console.WriteLine("1. Blanche Branson");
            Console.WriteLine("2. Copse Diner");
            Console.WriteLine("3. Leave");
            if (pineappleLibrary == true)
            {
                Console.WriteLine("4. Pineapple imports");
            }

            if (drSillCo == true)
            {
                Console.WriteLine("5. Dr Sill & Co");
            }

            Act = Console.ReadLine();
            Console.Clear();
            if (Act == "1")
            {
                Console.WriteLine("You find an article about the pumpkin pie contest from this year's Oktoberfest in town. The two \n" +
                    "contestants favored to win were Blanche Branson and Robert Riddle; it was close, but Branson got the trophy. \n" +
                    "Second place was Riddle, and third was Dewey Driscoll.");
                if (GotPieArticle == false)
                {
                    var PieArticle = new Item("Article about Pie Contest", "An article about this year's Oktoberfest pie contest, \n" +
                        "won by Blanche Branson, with Robert Riddle as runner-up.");
                    PieArticle.AddClue(Inventory);
                    GotPieArticle = true;
                }
                pieContest = true;
            }
            else if (Act == "2")
            {
                Console.WriteLine("You find an article from last year about Copse's controversial decision to lower their servers' \n" +
                    "pay to minimum wage.");
                if (GotWageArticle == false)
                {
                    var WageArticle = new Item("Article about Pay Cut", "An article from last year about Copse lowering its \n" +
                        "servers' wage.");
                    WageArticle.AddClue(Inventory);
                    GotWageArticle = true;
                }
                payCut = true;
            }
            else if (Act == "3")
            {
                LibraryAct();
            }
            else if (Act == "4" && pineappleLibrary == true)
            {
                Console.WriteLine("You find an article about a recent law: due to a recently discovered breed of fish in the \n" +
                    "Mississippi River, pineapples are no longer allowed to be shipped over the Mississippi; the fish are allergic \n" +
                    "to them.");
                if (GotPineappleArticle == false)
                {
                    var PineappleArticle = new Item("Article about Pineapple Shipping", "An article about the ban of pineapple \n" +
                        "shipping via the Mississippi River.");
                    PineappleArticle.AddClue(Inventory);
                    GotPineappleArticle = true;
                }
                pineappleBan = true;
            }
            else if (Act == "5" && drSillCo == true)
            {
                Console.WriteLine("You find an old article from the 1920s about the founding of Dr Sill & Co by Doctor Silas \n" +
                    "Driscoll, a former resident of this very town.");
                if (GotDriscollArticle == false)
                {
                    var DriscollArticle = new Item("Article about Dr Silas Driscoll", "Dr Sill & Co was founded by Dr Silas Driscoll.");
                    DriscollArticle.AddClue(Inventory);
                    GotDriscollArticle = true;
                }
                driscoll = true;
            }
            else if (Act.ToLower() == "x")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
                Console.ReadLine();
                LibraryArchives();
            }

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            LibraryArchives();
        }

        static void Docks()
        {
            Console.Clear();
            BeenToDocks = true;
            Console.WriteLine("The docks on your town's stretch of the Mississippi River are bustling with activity; people are \n" +
                "loading and unloading crates from the long shipping carriers in the water, yelling instructions back and forth, \n" +
                "and the huge cranes that pepper the pier add an ambient, mechanical hum to the scene. You've been here once \n" +
                "before, on a school trip, but you don't know where to start looking. \n" +
                "As you stand off to the side, looking around for any clue as to what ship has supplies for Copse, you are spotted \n" +
                "by a short-haired woman in a thick knit sweater, scarf, and beanie. She frowns and walks over to you. \n" +
                "'Hey kid, do you need help looking for something? You look lost.' \n" +
                "You ask her if she knows what ship delivers produce for Copse Diner and she smiles proudly. \n" +
                "'That'd be my ship, the SS Buhdey.' She extends her hand, and you shake it. 'I'm Captain Ailani Acosta, at your \n" +
                "service. How can I help you?' \n" +
                $"'{FirstName} {LastName},' you say, and explain the situation. She nods grimly. 'I heard. It's a real shame. I \n" +
                $"didn't always get along with Ms. Branson, but she certainly didn't deserve this. But what do you have to do with \n" +
                $"it?' \n" +
                "'I'm investigating her murder.' \n" +
                "Captain Acosta laughs hardily. 'Are you now? Well isn't that something! Just let me know if you need any help, \n" +
                "kid.");

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            DocksAct();
        }

        static void DocksAct()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Talk to Captain Acosta");
            Console.WriteLine("2. Leave");


            Act = Console.ReadLine();
            if (Act == "1")
            {
                DocksTalkCaptain();
            }
            else if (Act == "2")
            {
                Move();
            }
            else if (Act.ToLower() == "x")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("That is not a valid action.");
                DocksAct();
            }

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            DocksAct();
        }

        static void DocksTalkCaptain()
        {
            Console.Clear();

            Console.WriteLine("What do you want to ask Captain Acosta about?");
            Console.WriteLine("1. What did you argue with Blanche about?");
            Console.WriteLine("2. Nevermind.");
            if (pineappleBan == true)
            {
                Console.WriteLine("3. Are you delivering pineapples?");
            }

            Act = Console.ReadLine();
            Console.Clear();
            if (Act == "1")
            {
                Console.WriteLine("'Oh, she was always trying to haggle-- as if I even have the authority to change prices! It's \n" +
                    "not like I'm the owner of the company or anything, I just ship the stuff!' \n" +
                    "'Who does have that authority?' you ask. \n" +
                    "Captain Acosta shrugs. 'The CEO or something, I guess.' \n" +
                    "'The CEO of what?' \n" +
                    "'Of Dr Sill & Co. Oh, sorry, I guess you wouldn't know what company Blanche got her deliveries from. Yeah, \n" +
                    "it's Dr Sill & Co.'");
                if (GotCompanyInfo == false)
                {
                    var CompanyInfo = new Item("Dr Sill & Co", "Blanche got her deliveries from Dr Sill & Co.");
                    CompanyInfo.AddClue(Inventory);
                    GotCompanyInfo = true;
                }
                drSillCo = true;
            }
            else if (Act == "2")
            {
                DocksAct();
            }
            else if (Act == "3" && pineappleBan == true)
            {
                Console.WriteLine("Captain Acosta tilts her head slightly. 'No. Now why would you want to know about that?' \n" +
                    "You pull out the note from Blanche to Mallory. 'Blanche had to get pineapple from somewhere,' you say. Captain \n" +
                    "Acosta thinks for a moment. \n" +
                    "'Is this important to the case? Like, actually important to help solve this murder?' \n" +
                    "You nod. She thinks for another moment. \n" +
                    $"'Alright, to hell with it. If it's for the sake of justice, I guess I'll spill the beans. But listen, \n" +
                    $"{LastName}, I don't want this getting out. I could lose my job over this, so don't tell anyone unless you \n" +
                    $"really have to, okay?' You nod and zip your lips. 'Good kid,' she says. 'Now listen: you know about the ban \n" +
                    $"on shipping pineapples over the Mississippi? Well, some orders came down from the higher ups at Dr Sill & Co \n" +
                    $"that aren't exactly.... compliant with that law, you understand? Only the thing is, it seems like Blanche \n" +
                    $"found out about this. We're only selling to black market contacts right now, but somehow Blanche made a deal \n" +
                    $"with the higher ups to get a piece of the pineapple pie. Now that's all I know, okay? Keep your lips zipped.'");
                if (GotSmuggling == false)
                {
                    var Smuggling = new Item("Smuggling", "Dr Sill & Co is smuggling pineapples over the Mississippi River.");
                    Smuggling.AddClue(Inventory);
                    GotSmuggling = true;
                }
            }
            else if (Act.ToLower() == "x")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
                Console.ReadLine();
                DocksTalkCaptain();
            }

            Input = Console.ReadLine();
            if (Input.ToLower() == "x")
            {
                Menu();
                Console.ReadLine();
            }
            DocksTalkCaptain();
        }

        static void PoliceStation()
        {
            Console.Clear();
            bool killer = false;
            bool weapon = false;
            bool disposed = false;
            bool motive = false;
            Console.WriteLine("Before you go to the police with your findings, are you sure you are ready to solve the mystery? (Enter \n" +
                "yes or no)");
            Input = Console.ReadLine();
            if (Input.ToLower().Contains("n"))
            {
                Console.WriteLine("Then keep investigating. Good luck!");
                Console.ReadLine();
                Move();
            }
            else
            {
                Console.WriteLine("Please fill in the details of the case: \n" +
                    "Who is the murderer?");
                Input = Console.ReadLine();

                if (Input.ToLower().Contains("dewey") || Input.ToLower().Contains("driscoll") || Input.ToLower().Contains("dewey driscoll"))
                {
                    killer = true;
                }

                Console.WriteLine("What was the murder weapon?");
                Input = Console.ReadLine();

                if (Input.ToLower().Contains("pineapple"))
                {
                    weapon = true;
                }

                Console.WriteLine("How was the murder weapon disposed of? \n" +
                    "1. Burned \n" +
                    "2. Eaten \n" +
                    "3. Thrown away \n" +
                    "4. It wasn't");
                Input = Console.ReadLine();
                Input.ToLower();

                if (Input == "2")
                {
                    disposed = true;
                }

                Console.WriteLine("What was the motive? \n" +
                    "1. Jealousy \n" +
                    "2. Revenge \n" +
                    "3. Rage \n" +
                    "4. Blackmail");
                Input = Console.ReadLine();
                Input.ToLower();

                if (Input == "4")
                {
                    motive = true;
                }

                //Check if the answers are correct
                if (killer == true && weapon == true && disposed == true && motive == true)
                {
                    WinGame();
                }
                else
                {
                    LoseGame();
                }
            }
        }

        static void WinGame()
        {
            Console.Clear();
            Console.WriteLine("You go to the police with the information you've uncovered. Dewey Driscoll is brought in for \n" +
                "questioning. Eventually, he makes a full confession. \n" +
                "'Yes, I killed her! She had figured out that we were smuggling pineapples across the Mississippi, and wanted a \n" +
                "piece of the pie. Or should I say, pineapple. Hehe. She tried to get me to agree to provide her with pineapples free \n" +
                "of charge! I couldn't let that happen. In this economy? So I agreed to her terms when she came to me. Later that \n" +
                " day, though, I went to Copse, pretending to deliver her precious pineapples myself. Then, when her back was \n" +
                "turned-- whack! She never saw it coming. Waste of a good pineapple, though, so I figured I'd kill two birds with \n" +
                "one stone and make a cake out of it; hide the evidence and have myself a snack. And I would have gotten away with \n" +
                "it, too, if it weren't for that meddling kid!' \n" +
                "In the aftermath, Mallory decides she no longer wants to work at Copse Diner. She is able to find a new job, as a \n" +
                "librarian-in-training, thanks to the void Dewey left at the library. At next year's Oktoberfest, Officer Riddle \n" +
                "wins the pie contest with his delicious pumpkin pie. He gets his picture in the newspaper with his pie, in which he \n" +
                "is weeping with joy. You've never seen him happier. Captain Acosta sends you a letter a few months after Dewey's \n" +
                "arrest. She understands why you had to tell the police about the smuggling, and luckily she didn't suffer legal \n" +
                "repurcussion from the trial of the higher-ups at Dr Sill & Co who authorized the smuggling, since the court \n" +
                "foucsed on the company executives. With the letter, she enclosed a coupon for 20% off a fruit delivery, and now \n" +
                "a crate of bananas sits in your kitchen. After the case, you were off of pineapples for a long time.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congratulations on solving {FirstName} {LastName} and the case of the Purloined Pineapple! You are \n" +
                $"a Super Sleuth!");
            Console.ReadLine();
            System.Environment.Exit(1);
        }

        static void LoseGame()
        {
            Console.Clear();
            Console.WriteLine("Unfortunately, one or more of your answers are wrong. Keep investigating and see if you can \n" +
                "correctly solve the mystery.");
            Console.ReadLine();
            Move();
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("You have the following clues:");
            foreach (Item i in Inventory)
            {
                Console.WriteLine(i.Name + ": " + i.Description);
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
