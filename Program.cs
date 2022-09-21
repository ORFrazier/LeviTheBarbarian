using System;

namespace LevitheBarbarian
{
    class Program
    {
        public Weapon chosenWeapon = new Weapon();

        public static void Main(string[] args)
        {            
            Program program = new Program();
            program.gameTitle();
            program.first();
            
           
        }
        
        public void AssignStarterWeapon()
        {
            chosenWeapon.name = "club";
            chosenWeapon.weapon = 0;

        }

        public void gameTitle()
        {
            //This project is really important to me. I hope I can refine and optimize it to improve my skills!

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                                                                                                                                        ");
            Console.WriteLine("                         ██▓    ▓█████ ██▒   █▓ ██▓   ▄▄▄█████▓ ██░ ██ ▓█████     ▄▄▄▄    ▄▄▄       ██▀███   ▄▄▄▄    ▄▄▄       ██▀███   ██▓ ▄▄▄       ███▄    █ ");
            Console.WriteLine("                         ▓██▒    ▓█   ▀▓██░   █▒▓██▒   ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓█████▄ ▒████▄    ▓██ ▒ ██▒▓█████▄ ▒████▄    ▓██ ▒ ██▒▓██▒▒████▄     ██ ▀█   █ ");
            Console.WriteLine("                         ▒██░    ▒███   ▓██  █▒░▒██▒   ▒ ▓██░ ▒░▒██▀▀██░▒███      ▒██▒ ▄██▒██  ▀█▄  ▓██ ░▄█ ▒▒██▒ ▄██▒██  ▀█▄  ▓██ ░▄█ ▒▒██▒▒██  ▀█▄  ▓██  ▀█ ██▒");
            Console.WriteLine("                         ▒██░    ▒▓█  ▄  ▒██ █░░░██░   ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ▒██░█▀  ░██▄▄▄▄██ ▒██▀▀█▄  ▒██░█▀  ░██▄▄▄▄██ ▒██▀▀█▄  ░██░░██▄▄▄▄██ ▓██▒  ▐▌██▒");
            Console.WriteLine("                         ░██████▒░▒████▒  ▒▀█░  ░██░     ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▓█  ▀█▓ ▓█   ▓██▒░██▓ ▒██▒░▓█  ▀█▓ ▓█   ▓██▒░██▓ ▒██▒░██░ ▓█   ▓██▒▒██░   ▓██░");
            Console.WriteLine("                         ░ ▒░▓  ░░░ ▒░ ░  ░ ▐░  ░▓       ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░   ░▒▓███▀▒ ▒▒   ▓▒█░░ ▒▓ ░▒▓░░▒▓███▀▒ ▒▒   ▓▒█░░ ▒▓ ░▒▓░░▓   ▒▒   ▓▒█░░ ▒░   ▒ ▒ ");
            Console.WriteLine("                         ░ ░ ▒  ░ ░ ░  ░  ░ ░░   ▒ ░       ░     ▒ ░▒░ ░ ░ ░  ░   ▒░▒   ░   ▒   ▒▒ ░  ░▒ ░ ▒░▒░▒   ░   ▒   ▒▒ ░  ░▒ ░ ▒░ ▒ ░  ▒   ▒▒ ░░ ░░   ░ ▒░");
            Console.WriteLine("                             ░ ░      ░       ░░   ▒ ░     ░       ░  ░░ ░   ░       ░    ░   ░   ▒     ░░   ░  ░    ░   ░   ▒     ░░   ░  ▒ ░  ░   ▒      ░   ░ ░ ");
            Console.WriteLine("                             ░  ░   ░  ░     ░   ░               ░  ░  ░   ░  ░    ░            ░  ░   ░      ░            ░  ░   ░      ░        ░  ░         ░ ");
            string s = "Press ENTER to begin";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.ReadLine();
            Console.Clear();

        }

        public void first()
        {
            

            string gameOverText = " How unfortunate. You've already failed before leaving the village!";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string choice;

            

            Console.WriteLine("You are Levi the Barbarian, savage warrior from the small village of Normia. After an evening of mild debauchery and howling at the gods, you awaken to panicked knocks on your hut's door.\n What will you do?");
            Console.WriteLine("1. Go back to bed. I'ts probably nothing.");
            Console.WriteLine("2. Go to the door and see what's going on.");
            Console.WriteLine("3. Cautiously approach the door. It could be anyone!");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choice)
            {
                case "1":
                case "Go back to bed.":
                case "bed":
                case "Go back to bed":
                case "back to bed":
                case "Back to bed":
                    {
                        Console.WriteLine("Ignoring the calls of the panicked villagers, you roll back into the prickly warmth of your straw bed.\n Unfortunately, in your deep, deserved slumber, you meet an undeserved fate.\n Unaware of the fires comsuming your village, you become part of the kindling. Your legend ends here.\n Press ENTER to continue.");
                        Console.ReadLine();
                        gameOver(gameOverText);
                        break;
                    }
                case "2":
                case "Go to door":
                case "Go to the door.":
                case "Go to the door":
                case "see what's going on":
                    {
                        Console.WriteLine("Clumisly rushing to the door, you trip over your favorite collection of skulls, falling headfirst into your weapons.\n Normally a weapons cache is a good thing for barbarians.\n However, your clumsiness has sent your favorite axe right through your face. You die immediately, and the village burns.\n Press ENTER to continue.");
                        Console.ReadLine();
                        gameOver(gameOverText);
                        break;
                    }
                case "3":
                case "Cautiously approach the door.":
                case "cautiously approach the door":
                case "Cautiously approach the door":
                case "Use caution":
                case "Cautiously approach":
                case "Cautiously approach.":
                    {
                        Console.WriteLine("Using your wits, you approach your door quietly, dodging some disheveled skulls on the ground.\n Making a mental note to organize them later, you reach your wooden door with ease.\n 'Who goes there!'you demand.    'Tis I, little Pat from the butcher's shop!', calls a meek voice from the other side of the door.\n 'Bandits are attacking the village!', he yells. 'Won't you save us, mighty Levi?'\n Ever seeking glory, you eagerly agree, grabbing your favorite axe before swinging the door open, charging to meet your foes head on!\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;

                    }
                default:
                    {
                        Console.WriteLine("What sort of command is that? Try again!");
                        Console.WriteLine("Press ENTER to try again.");
                        first();
                        break;
                    }
            }
        }
        public void second()
        {
            Random rnd = new Random();
            string[] secOptions = { "Masked bandits covered in furs and leather are stealing horses! They appear to have bows.",
                "Masked bandits, wearing nothing but bear furs and brandishing short swords, are attacking the village tavern!",
                "Masked bandits, wearing wolf pelts and carrying spears, are attacking old man Timmy's hut!"};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Your village is in chaos! Do you choose to attack?; Yes or No?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "y" || secChoice == "yes")
            {
                third();
            }
            else if (secChoice == "n" || secChoice == "no")
            {
                Console.WriteLine("Choosing a strategic withdrawl, you reposition youself away from the fighting and chaos.\n Noticing your actions, the very gods you curse punish you for your actions, turning you into a small rodent.\n Promptly devoured by a stray cat, your legend ends in a whimper as the village is destroyed.\n Press ENTER to continue.");
                Console.ReadLine();
                Console.Clear();
                gameOver("Looks like you lost the rat race.");



            }
            else
            {
                Console.WriteLine("Bandits are attacking and you type that? Try again!\n Press ENTER to try again.");
                second();

            }
        }
        public void third()
        {
            int age;

            Console.Clear();
            Console.WriteLine("With a mighty yell, you charge your foes, who don't see you coming.\n Axe raised, you slaughter the bandits who stand before you, easily overcoming their weak combat skills.\n However, during the slaughter, your weapon is damaged!\n Though it be the middle of the night, you appraoch the village blacksmith, who is tossing the still warm bodies of bandits into a wagon.\n Seeing you approach, he nods in your direction, taking a swig of foul smelling ale\n 'We're lucky to have you here, Levi' he states. 'There's no way I could've handled that many alone.\n Before you get a chance to speak, he moves his torch closer, eyeing your splintered weapon\n 'Shame about your axe. You must've had it for years. How many years, if you don't mind telling me?' he inquires.\n Considering this for a moment, you think of how to answer.");
            Console.Write("Number of years you've had your axe: ");


            int.TryParse(Console.ReadLine(), out age);

            if (age > 11)
            {
                Console.Clear();
                Console.WriteLine("The smith is unamused with your lies, as are the gods. However, you never get a chance to lie again.\n The smithy drops the torch by accident, where it bounces towards the horses attached to the wagon full of bandit bodies!\n Uttery terrified, the horses neigh in terror.\n Catching you unprepared, the wagon, improperly attached to the beasts, topples over on you.\n The weight of the wagon and bodies crushes your ribs, and you suffocate in your own blood.\n Though not a legend, the village will remember your deeds fondly for a couple weeks, naming a bad drink after you.\n Press ENTER to continue");
                Console.ReadLine();
                Console.Clear();
                gameOver(" How unfortunate. You've already failed before leaving the village!");

            }
            else
            {
                Console.Clear();
                string choicetwo;
                Console.WriteLine("'Impressive! I rarely have seen such craftsmanship in these parts'.\n Taking the weapon from you, he eyes the broken item all over.\n 'Yeah, I can fix it. But you'll need to wait a few days.'\n Begrudgingly, you have no choice but to accept. However, with a collection of fine blades and clubs still at home, you don't fret.\n On your walk home, you are stopped by the local shaman, who's very much in a panic. Walking up to you and poking your chisled chest with his long, bony finger, he scowls.\n 'You! Barbarian! You must help me, else this village and all who live here will face certain doom!'\n This seems pretty serious! Will you help?");
                choicetwo = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choicetwo)
                {
                    case "yes":
                    case "y":
                    case "Yes":
                        {
                            Console.WriteLine("The shaman grins, his mouth devoid of teeth. 'I knew you were the right man for the job!\n 'The time of harvest approaches, but without a proper tribute to the gods, we are surely doomed to starve.\n I need you to travel through the Forest of Many Paths and find the ancient stronghold, for within is the Golden Skull!\n Bring this skull back to me, so I may bless our village's crops and ensure the harvest.'\n You consider this for a moment.\n As a barbarian, you can appreciate a man wanting more skulls for their collection. Also liking the idea of a bigger harvest, you agree to bring back this golden skull.\n Your adventure is about to begin!\n Press ENTER to continue");
                            Console.ReadLine();
                            Console.Clear();
                            gototheforest();
                            break;
                        }
                    case "no":
                    case "No":
                    case "n":
                        {
                            Console.WriteLine("The shaman scowls, cursing you in more languages than you care to count. However, you care little for the puny words of a smelly old man.\n After a few days, you retrive your axe, now good as new! You also learn the shaman has left the village.\n Days turn into weeks, and weeks to months, and nothing of importance happens. However, more and more villagers begin leaving as the crops continue to fail.\n Eventually, even you are forced to leave your home. With no food, you turn to living off the land. Within five minutes of entering the forest, you are bitten on the ankle by a venomous snake.\n With no shaman to remove the poison, and no villagers to tend to your needs, you die a slow death undeserving of a mighty barbarian.\n Press ENTER to continue");
                            Console.ReadLine();
                            Console.Clear();
                            gameOver(" Well...at least no one was around to see your shameful demise.");
                            break;
                        }
                }


            }
        }

        public void youWin()
        {

        }
        public void gototheforest()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.WriteLine("                                              Will you survive                                              ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("     ▄▄▄█████▓ ██░ ██ ▓█████      █████▒▒█████   ██▀███  ▓█████   ██████ ▄▄▄█████▓          ");
            Console.WriteLine("     ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓██   ▒▒██▒  ██▒▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒          ");
            Console.WriteLine("     ▒ ▓██░ ▒░▒██▀▀██░▒███      ▒████ ░▒██░  ██▒▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░          ");
            Console.WriteLine("     ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ░▓█▒  ░▒██   ██░▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░           ");
            Console.WriteLine("       ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▒█░   ░ ████▓▒░░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░           ");
            Console.WriteLine("       ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░    ▒ ░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░             ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("      ▒█████    █████▒                                                                      ");
            Console.WriteLine("     ▒██▒  ██▒▓██   ▒                                                                       ");
            Console.WriteLine("     ▒██░  ██▒▒████ ░                                                                       ");
            Console.WriteLine("     ▒██   ██░░▓█▒  ░                                                                       ");
            Console.WriteLine("     ░ ████▓▒░░▒█░                                                                          ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("      ███▄ ▄███▓ ▄▄▄       ███▄    █▓██   ██▓    ██▓███   ▄▄▄     ▄▄▄█████▓ ██░ ██   ██████ ");
            Console.WriteLine("     ▓██▒▀█▀ ██▒▒████▄     ██ ▀█   █ ▒██  ██▒   ▓██░  ██▒▒████▄   ▓  ██▒ ▓▒▓██░ ██▒▒██    ▒ ");
            Console.WriteLine("     ▓██    ▓██░▒██  ▀█▄  ▓██  ▀█ ██▒ ▒██ ██░   ▓██░ ██▓▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▀▀██░░ ▓██▄   ");
            Console.WriteLine("     ▒██    ▒██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒ ░ ▐██▓░   ▒██▄█▓▒ ▒░██▄▄▄▄██░ ▓██▓ ░ ░▓█ ░██   ▒   ██");
            Console.WriteLine("     ▒██▒   ░██▒ ▓█   ▓██▒▒██░   ▓██░ ░ ██▒▓░   ▒██▒ ░  ░ ▓█   ▓██▒ ▒██▒ ░ ░▓█▒░██▓▒██████▒▒");
            Console.WriteLine("     ░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒░   ▒ ▒   ██▒▒▒    ▒▓▒░ ░  ░ ▒▒   ▓▒█░ ▒ ░░    ▒ ░░▒░▒▒ ▒▓▒ ▒ ░");
            Console.WriteLine("     ░  ░      ░  ▒   ▒▒ ░░ ░░   ░ ▒░▓██ ░▒░    ░▒ ░       ▒   ▒▒ ░   ░     ▒ ░▒░ ░░ ░▒  ░ ░");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            forestpartone();


        }
        public void forestpartone()
        {
            Console.WriteLine("After a quick rest, you grab your finest wooden "+chosenWeapon.name+" from your hut and venture forward, deep into the forest.\n Knowing little of which direction to go, you rely on your keen instincts. Discovering a path, you follow it.\n This works for a time. However, soon the path diverges into four trails. Which one will you choose?");

            string choicethree;

            Console.WriteLine("1: The path forward. It looks steady and well-traveled.\n 2: The path to your left. It appears to follow a nearby stream.\n 3: The path to your right. It goes up a muddy, mossy hill and dissappears.\n 4: A barely visable game trail. This could lead you to a tasty brekfast!");
            Console.Write("Choice: ");
            choicethree = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choicethree)
            {
                case "1":
                case "The path forward":
                case "the path forward":
                case "path forward":
                case "Path forward":
                    {
                        string choicefour;

                        Console.WriteLine("What were you thinking? The best path is the one forward. You press on without a second thought to the diverging paths.\n Soon, it becomes clear that this path has been used very recently, as a neat pile of delicious, roasted meat lays in the center of the dirt road.\n Another man's lost, steaming meat is another man's breakfast!\n Do you wish to take the meat? Yes or No");
                        Console.Write("Choice: ");
                        choicefour = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choicefour)

                        {
                            case "yes":
                            case "Yes":
                            case "y":
                            case "Y":
                                {
                                    //pork eaten!
                                    Console.WriteLine("Throwing caution to the wind, you grab the slab of roasted meat from the road. What luck! It's pork.\n Delighted, you lean your "+chosenWeapon.name+" next to the nearest tree and happily devour the free meal.\n What a great decision you've made! You feel refreshed and ready for battle!\n Press ENTER to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    forestpathporkeaten();
                                    break;
                                }
                            case "no":
                            case "No":
                            case "n":
                            case "N":
                                {
                                    //pork not eaten
                                    Console.WriteLine("Suspicion gets the better of you. Who would leave a delicious piece of meat out in the open?\n Avoiding the delicious smelling slab, you press onward deeper into the forest.\n Press ENTER to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    forestpathporknoteaten();
                                    break;

                                }

                        }

                    }
                    break;
                case "2":
                case "The path to your left":
                case "left path":
                case "the path to your left":
                    {
                        //This paladin character is rather interesting
                        Console.WriteLine("Following a stream seems like the best choice. Carefully working your way down the rocky slope, you begin following the gentle stream deeper into the forest.\n However, it soon becomes apparent that you're not alone.\n Not so far off in the distance, you hear the sounds of clanking metal against stone, swiftly heading in your direction!\n Someone seems to be following you.\n With plenty of time to prepare, you begin to set a trap.\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        paladinOfthecreekfirstencounter();
                        break;
                    }
                case "3":
                case "Path to your right":
                case "right path":
                case "Right path":
                    {
                        //the camp encounter has so many pathways going towards it that I need to remember to make it as ambigious as possible before entering stage 3.
                        Console.WriteLine("A wise man once said the right path is always the hardest to take. In this case, quite literally.\n Tossing your "+chosenWeapon.name+" up the steep, muddy hill, you use both hands to dig into the moss and exposed roots of the trees to pull yourself upward.\n Sure, your chisled chest is now layered in mud, but who cares? Your job is to retrieve a golden skull, not look pretty.\n After some effort, you manage to pull yourself up the hill. But what's that? There's a small camp nearby!\n Finding your "+chosenWeapon.name+", you approach from the treeline.\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        forestrightpathtakencampencounter();
                        break;

                    }
                case "4":
                case "game trail":
                case "barely visible game trail":
                case "Barely visible game trail":
                    {
                        string choicefive;

                        Console.WriteLine("Your keen senses, mainly your stomach, have alerted you to a barely visible game trail zig-zagging through the foliage.\n Considering yourself a master tracker, you consider following the trail. Surely there must be something delicious to hunt!\n You travel deeper into the forest, following the trail until it leads you to a cave.\n What luck! Now your prey is trapped.Will you wait for it to exit the cave, or attack right away?\n Attack or Wait?");
                        Console.Write("Choice: ");
                        choicefive = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choicefive)
                        {
                            case "Attack":
                            case "attack":
                                {
                                    //death by cave
                                    Console.WriteLine("What sort of barbarian waits? With a mighty roar, you charge into the dark cave.\n Unaware of the slippery rocks inside, you fall flat on your back as your "+chosenWeapon.name+" goes flying into the air.\n The dense weapon slams into a particularly pointy stalactite, which falls directly into your chest.\n You die, never knowing what meal you could've eaten.\n Press ENTER to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    gameOver("Barbarians were never known for their spelunking prowess.");
                                    break;
                                }
                            case "Wait":
                            case "wait":
                                {
                                    //mooseboar battle begins here!
                                    Console.WriteLine("You choose to wait patiently for your quarry, eagerly preparing to attack. But what sort of beast are you hunting?\n Your patience pays off as a large mooseboar lumbers out of the foliage near the game trail.\n Such a mighty beast would feed you for an entire day! Though with its sharp tusks and giant antlers, this beast could easily maul you.\n This will be a mighty battle!\n Seeing an opportunity, you leap out and attack the mooseboar! The battle has begun!\n Press ENTER to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    forestmooseboarbattle();
                                    break;

                                }

                        }

                        break;
                    }

            }
        }
        public void forestpathporknoteaten()
        {
            //I don't think many people will die this way. Who knows though?
            Console.WriteLine("You planned to go deeper into the forest. However, you soon feel that you're being watched! Using your keen survival skills, you set a trap, hiding behind a tree with your "+chosenWeapon.name+" raised.\n After some time, a hooded figure appears along the path you took. With a roar, you bring down your "+chosenWeapon.name+" on the figure's head, killing them instantly.\n You step out to loot the body, figuring it could have some food or riches. The moment you do, three figures appear from the foliage, armed with bows!\n Realizing you've killed their comrade, you have no choice but to fight. Charging the bowmen, they cut you down with ease before you ever reach them, your body filled with arrows.\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            gameOver(" Well...at least no one was around to see your shameful demise.");
        }
        public void forestpathporkeaten()
        {
            //the easy way to stage 3
            Console.WriteLine("'What in the gods' name are you doing?' says a confused voice from behind the nearest tree.\n Mouth still full of food, you raise your "+chosenWeapon.name+" in a clumsy manner, unsure if this voice is friend or foe.\n Chuckles and laughter emanate from the nearby trees, and a hunting party appears around you. 'You're not what we expected to find,' says the closest hunter to you.\n 'The boys over there almost shot you, you know.' A large man traipsing through the forest from out of nowhere was quite a surprise.'\n You nod, still eating.\n 'We've been searching for a local beast, a Mooseboar. We heard it likes to eat meat with its usual grassy fare, and set this trap. Have you seen one?'\n Mouth still full of food, you shake your head.\n 'Shame. Well, what brings a mighty warrior such as yourself out this far?'\n Mouth finally free of food, you explain your quest to the huntsmen.\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            huntsMenhelpyou();
           
        }
        public void huntsMenhelpyou()
        {
            //I wonder how many people will take the easy route with the huntsmen helping?
            //hihi
            Console.WriteLine("You tell the story of the attack on your village, how you single-handedly slaughtered three dozen bandits, and how the feelble village shaman asked you for help.\n The huntsmen have formed a circle around you, listening intently to your every word.\n When you tale finally ends, they are left in awe of your strength.\n 'Mighty warrior, we would be happy to help you save your village. However, we must soon return to our own kingdom across the mountains.\n However, I can personally lead you to this stronghold you speak of. We set up camp there not two nights ago!'\n With your poor sense of direction, you happily agree to the escort to the stronghold. Looks like you're making better time than you ever imagined!\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            gotoAncientstronghold();


        }
        public void forestrightpathtakencampencounter()
        {
            //This one will be used for most endings leading to stage 3

            Console.WriteLine("You've come across a camp of three tents in an opening deep within the forest./n The campfire at the center of these three tents is still smoldering, but there appears to be no one here. Quietly, you approach to get a closer look, and to check for any spare loot left behind.");
            Console.ReadLine();
            Console.Clear();
            forestrightpathtakencampencounterTwo();
        }
        public void forestrightpathtakencampencounterTwo()
        {
            //Leading to the Stronghold!

            Console.WriteLine("Unfortunately, whoever was here made sure to leave nothing of value behind. However, a trail leads away from the camp and towards something massive just beyone the trees.\n Weapon in hand, you follow the trail, which leads to a clearing, revealing a massive structure!\n An imposingly tall stronghold stands before you, its drawbridge already lowered and massive gate opened. You won't be alone, it seems.\n Gathering your courage, you charge into the unknown, prepared to face your final challenges.");
            Console.ReadLine();
            Console.Clear();
            gotoAncientstronghold();
        }
        public void forestmooseboarbattle()
        {
            string choicesix;
            //choosing how to fight the mooseboar
            Console.WriteLine("Thanks to your patience, the Mooseboar is unable to make the first attack. Turning to face you, the hulking beast is caught completely by surprise!\n The first strike is yours. How will you proceed?\n Attack 1: Swing your "+chosenWeapon.name+" at its nose.\n Attack 2: Attempt to jump on its back.\n Attack 3: Swing your "+chosenWeapon.name+" at the side of its head.\n Attack 4: Throw your "+chosenWeapon.name+" on the ground and taunt the beast.");
            Console.Write("Choice: ");
            choicesix = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choicesix)
            {
                case "1":
                case "attack 1":
                case "Attack 1":
                    {
                        Console.WriteLine("With a mighty yell, you swing your wooden "+chosenWeapon.name+" downwards, directly at the beast's snout.\n However, the Mooseboar's antlers deflect the attack. Agitated, the beast immediately charges!\n Still off balance, you can do little as the giant beast grabs you with its mouth and slings you to the entrance of the cave.\n Dazed, you are barely on your feet before getting impaled by the beast's tusks and merciless antlers!\n You take some pleasure knowing that it will be days before the Mooseboar can remove your body from its face.\n Press ENTER to continue.");
                        Console.ReadLine();
                        gameOver(" Well...at least no one was around to see your shameful demise.");
                        break;
                    }
                case "2":
                case "Attack 2":
                case "attack 2":
                    {
                        string choiceseven;

                        Console.WriteLine("Sensing the danger of the Mooseboar's tusks and antlers, you sidestep the turning beast and leap onto its back!\n Bellowing in panic, the beast tries to knock you off its broad back, but your hand grabs its fur tightly as you position yourself to attack.\n In the moment, you think of two attacks. Will you swing your "+chosenWeapon.name+" at the soft spot of its neck, or slam the "+chosenWeapon.name+" into its side?\n Attack Side, or Attack Neck?");
                        Console.Write("Choice: ");
                        choiceseven = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choiceseven)
                        {
                            case "Attack Side":
                            case "attack side":
                            case "Attack side":
                            case "attack Side":
                            case "Side":
                            case "side":
                                {
                                    string choiceeight;
                                    
                                    //this part is where you collect the tusk for a weapon. Ideally, it's going to work like a variable. I'll figure this out soon.

                                    Console.WriteLine("You swing your "+chosenWeapon.name+" with all your might, slamming it into the side of the Mooseboar. You hear ribs snap.\n The beast squeals in pain, trying its best to throw you from its back. In its panic, it charges towards the cave!\n Sensing the danger, you leap from the Mooseboar's back, rolling to the ground as it slams full force into the rocks.\n There is a deep rumbling noise emanating from the cave as cracks form in the stones. The cavern collapses, burying the beast.\n Only the Mooseboar's tusk is visible from the collapsed cave. Dissappointed in the lack of meal, you consider taking it for a trophy.\n Will you take the large tusk? Yes or No?");
                                    Console.Write("Choice: ");
                                    choiceeight = Console.ReadLine().ToLower();
                                    chosenWeapon.name = "mooseboar tusk";
                                    chosenWeapon.weapon = 1;
                                    Console.Clear();
                                    switch (choiceeight)
                                    {
                                        case "Yes":
                                        case "yes":
                                            {
                                                    //back to the camp encounter
                                                Console.WriteLine("Wanting some sort of trophy for your wasted time, you pry a the tusk from the crushed Mooseboar. An easy task for someone with your strength.\n Though dissappointed at the loss of all that protein, you tie the meter long tusk to the side of your belt and press onward, back into the forest\n Not too long into your trek, you notice a small camp set in a small clearing between the trees! Cautiously, you approach.\n Press ENTER to continue");
                                                Console.ReadLine();
                                                Console.Clear();
                                                forestrightpathtakencampencounter();
                                                break;
                                            }

                                        case "No":
                                        case "no":
                                            {

                                                Boolean hasMooseboarTusk = false;
                                                if (hasMooseboarTusk)
                                                    //guess they didn't want the tusk? It's an option.Back to the forest camp to stage 3

                                                Console.WriteLine("Choosing a more valorous approach than usual, you leave the beast in its rocky tomb. Grabbing your "+chosenWeapon.name+", you prepare to move on.\n Besides! There's more glory to be had in saving the village! Who know how they'll express their gratitude to the hero of Normia?\n Caught up in your own fantasies as you stroll through the forest, you suddenly stumble into a clearing, where you find a recently used camp!\n Pulling out your "+chosenWeapon.name+", you prepare for whatever challenge you may face next.\n Press ENTER to continue");
                                                Console.ReadLine();
                                                Console.Clear();
                                                forestrightpathtakencampencounter();
                                                break;
                                            }

                                    }      
                                   break; 
                                }

                         
                        }

                        break;
                    }
                case "Attack 3":
                case "attack 3":
                case "3":
                    {
                        //this is probably the longest path possible, giving you nearly 2 paths of dialogue. Still, it's an interesting option if anyone takes it.
                        Console.WriteLine("Confident that wood is harder than the moist bones of a Mooseboar, you swing your "+chosenWeapon.name+" sideways towards the beast's head with all your might.\n Your attack works better than expected! As the creature turns, your strike hits between the antlers and the tusks, blinding it in one eye.\n Squealing in terror, the Mooseboar goes into a frenzy, knocking over nearby trees and upheaving large stones, which are sent flying through the air.\n Managing to dodge the boulders, you chase after your foe with a mighty battle shout, charging deeper into the forest!\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        boarLeadstopaladinquest();
                        break;
                    }
                case "Attack 4":
                case "attack 4":
                case "4":
                    {
                        //the funny ending. I don't care what anyone says.
                        Console.WriteLine("Let no one ever say that you weren't overconfident. Throwing your "+chosenWeapon.name+" to the ground, you puff our your chest and yell profanely at the Mooseboar.\n 'Your mother was a guinea pig! Your father was a whitetail deer!' you exclaim.\n Sensitive about its ancestral lineage, the Mooseboar becomes unnaturally aggressive and, with tears in its eyes, charges you at full speed!\n You realize the mistake you've made far too late, as you're gored to death before you even have a chance to apologize.\n Press ENTER to continue.");
                        Console.ReadLine();
                        gameOvermooseboarfunny();
                        break;


                    }

                  
            }   
        }
        public void paladinOfthecreekfirstencounter()
        {
            string choicenine;
            //begins the paladin of the exposition. Lucky you.
            Console.WriteLine("You've decided to set a trap for whoever is clanking towards you. Finding a large boulder near the creek, you expertly hide your large frame, "+chosenWeapon.name+" raised.\n Soon, the loud footsteps approach, and out from the corner appears an exhausted man covered in shining armor! He's breathing heavily, and appears not to notice you.\n Will you attack the man? Or confront him?");
            Console.Write("Choice: ");
            choicenine = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choicenine)
            { 
                case "Attack":
                case "attack":
                    {
                        string choiceten;
                        //ngl, choices within choices can get a little sticky.
                        Console.WriteLine("Choosing violence is the barbarian way. With a yell, you swing your "+chosenWeapon.name+" at his helmet. Caught completely unaware, the man falls face first into the creek, likely dead.\n Ha! What a fool. Thinking that all his armor would save him from your mighty strength!\n Standing over his corpse, you consider looting the body. Who knows what treasures a man in knightly armor could have!\n Will you choose to loot him, or leave? You are on a quest, after all.");
                        Console.Write("Loot? or Leave?: ");
                        choiceten = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choiceten)
                        {
                            case "loot":
                            case "Loot":
                                {
                                    //getting your head bashed in isn't too dignified. Call it karma for the greed.
                                    Console.WriteLine("Greed gets the better of you. Turning the body over, you begin searching for anything of value.\n However, while cursing loudly, trying to take off the man's chestplate, you don't hear the approaching, cumbling footsteps of a towering Rock Golem!\n Caught completely unaware, it bashes you across the back of your head. Dying instantly,your body falls on top of your victim.\n Press ENTER to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    gameOver("Greed is good, but death is always bad!");
                                    break;
                                }
                            case "Leave":
                            case "leave":
                                {
                                    //another path to the camp encounter!
                                    Console.WriteLine("The urge to loot the dead knight is strong, but your suspicious gets the better of you. What was a fully armored man doing in a creek?\n You decide to leave the body alone. He didn't appear to have a visible sack of loot anyways.\n Unsure of why the man was running around in a creek, or if he was even after you, you decide to leave the rocky creek and return to the forest.\n After pushing through the dense trees aimlessly for some time, you come across a camp in a clearing! Cautiously, you approach.\n Press ENTER to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    forestrightpathtakencampencounter();
                                    break;

                                }
                                
                        }
                     break;
                    }
                case "confront":
                case "Confront":
                    {
                        //paladin encounter! So sorry you've went this direction.
                        Console.WriteLine("As the armored figure approaches, you consider just why there's an armored man chasing you. Could the smelly shaman have sold you out?\n You want answers!\n To hell with this hiding business. A barbarian faces their problems head on! Leaping around the corner, you confront the armored man head on!\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        confrontingThepaladin();
                        break;

                    }



             
            }

        }
        public void gameOvermooseboarfunny()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.Clear();
            Console.WriteLine(" After killing you, the Mooseboar decides to call his Dad.It's been awhile.");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  ");
            Console.WriteLine(" ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒");
            Console.WriteLine("▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒");
            Console.WriteLine("░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  ");
            Console.WriteLine("░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒");
            Console.WriteLine(" ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Console.WriteLine("  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░");
            Console.WriteLine("Press ENTER to try again");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
        public void boarLeadstopaladinquest()
        {
            //give up on chasing the boar and stumble into the paladin scenario.
            Console.WriteLine("Soon, the Mooseboar gains quite a distance on you. Who knew that a four-legged animal could move so fast!\n Making a mental note to smash legs and not eyes next time, you continue your pursuit, but it's apparent your quarry is getting away.\n The beast has managed the impossible and escaped you. Now you find yourself at the bank of a wide, rocky creek between the tall trees.\n You soon realize you're not alone! There's an armored man staring at you. Why is a knight in the middle of a creek in the woods?\n A cunning barbarian such as yourself will find the answer. What were you doing before?\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            confrontingThepaladin();
        }
        public void paladinExposition()
        {
            //it begins...you may regret this.
            Console.WriteLine("You decided to listen to the Guffin's words. You may grow to regret this.\n 'As I mentioned, I am the great Ser Guffin, great paladin of The Holy Exposition, the glorious order of the realm. THIS realm, in fact.\n I bet you're wondering what someone as well-equipped as I am doing out here? Well, let me spin you a great yarn.\n A grand tale of adventure, betrayal, love, tragedy, comedey, and intrigue!'\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            expositionOne();

        }
        public void expositionOne()
        {
            //I actually started getting sleepy writing this whole bit. That is how I knew it was perfect.
            Console.WriteLine("'Precisely one month and two days ago, I awoke in a panic. My superior, Ser Exposi had barged into my chambers!\n 'He began recanting a lovely tale about his wife and fourteen children, and after two hours, he told me just why he decided to visit.\n The King himself had given him a most sensitive quest, and time was of the essence! We had to act fast, else the King's bastard child would be in danger!\n I know what you're thinking. Our great King has a bastard child? Well, it's actually a great story. Allow me to fill you in.'\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            expositionTwo();



        }
        public void expositionTwo()
        {
            //think this is over? Not quite, love.
            Console.WriteLine("'The King was not always the infallible being you know in the present. Eleven years ago, he was quite the wild one, spreading his...influence in many places.\n In this case, his influence was most appreciated. In a village not too far from here, one of his mistresses went and had a child!\n And that child was the King's first bastard. First, I hear you say? Well, there's actually four more. Allow me to elaborate.\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            expositionThree();





        }
        public void expositionThree()
        {
            //still awake?
            Console.WriteLine("'As I mentioned, there are four more bastard offspring of the King. Yes, there are five in total. As a paladin of The Holy Exposition, it's my duty to keep them all in check.\n The first of the other four was a girl, and members of my order were tasked with keeping her from becoming a witch. An easy task, surely. However!\n It was one which become monumentally more challenging once you consider the lineage of her mother, a witch from the bogwoods! Now, I bet you're wondering,\n why did our King find the time to spread his seed that far out of the way of the kingdom? And why a witch? Well, let me tell you a story.\n Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            expositionFour();




        }
        public void expositionFour()
        {
            //you know the funny thing? None of this matters at all to this game.
            Console.WriteLine("'It all began when our King was still a prince, under the heel of his cruel father.'\n For a blessed moment, the paladin finally stops talking. You begin to say somehting but are promptly cut off.\n 'A tragedy of love never realized! At least, not spiritually. Our King, the Prince at the time, grew fond of the witch, and vowed to return someday!\n And though his father kept them apart until his death, the two eventually rejoined, rejoiced in each other's company for at least one night, and boom!\n A daughter was born. Now, the King has been quite clear with his wishes, and demands we keep her away from the dark arts of her mother. However!\n Her story has nothing to do with why I ended up in this creek, talking to you, my fine shirtless friend. For that tale starts somewhere else!\n Allow me to explain.'\n Better press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            expositionFive();


        }
        public void expositionFive()
        {
            //you're almost there!
            Console.WriteLine("Your brain feels fuzzy. The paladin continues to talk at you.\n 'Friend! As I was saying before, if you remember from before the tale of the King's witch mistress, I was awoken by the great Ser Esposi.\n And he had a mission for me, as no other paladin could be tasked with such a harrowing mission. His first bastard had been kidnapped by a merciless mage!\n This fiend was once a mighty spellcaster who served the King, but after a lengthy plot to assassinate him failed, he fled deep into these woods,\n possibly taking the bastard child hostage! Now, I know what you're thinking. Possibly? Well you see, there's a good reason we beleive the fiendish\n fire thrower has taken the boy. It all began when...'\n Press ENTER to...hey, what's that?");
            Console.ReadLine();
            Console.Clear();
            expositionEnds();

        }
        public void expositionEnds()
        {
            //it finally ends and the golem fight begins.
            Console.WriteLine("The paladin's many words are like a curse on your mind. His stories bleeding into each other and meaning nothing to you.\n However, staring blankly behind the paladin has paid off, as you see a massive, monstrous creature approaching!\n 'Quiet, Paladin!' you yell, waving your "+chosenWeapon.name+" towards the approaching monster. 'There's a golem coming!'\n The paladin turns and sees the approaching foe. Finally shutting up, he draws the sword from his side.\n 'the mage has sent a golem to kill us!' he yells. 'Prepare youself, friend!'\n Finally, something is happening! You prepare for the battle!\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            golemCreekbattle();

        }
        public void golemCreekbattle()
        {
            string choiceeleven;
            //so begins the golem fight
            Console.WriteLine("A monstrous golem, appearing to be made of the very rock and smooth stones of the creek, towers above you and the paladin. Its body is double your height.\n Dripping wet, it would be difficult to scale the construct by normal means and attack its small head.\n You cannot predict how the paladin will act. How will you proceed?\n 1: Charge ahead of the paladin and swing your "+chosenWeapon.name+" at the golem's legs.\n 2: Wait for the paladin to make the first move.\n 3: Flee. There's no glory in fighting rocks!");
            Console.Write("Choice: ");
            choiceeleven = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choiceeleven)
            {
                case "1":
                case "Charge":
                case "Charge ahead":
                case "charge":
                case "charge ahead":
                    {
                        //a confident choice, charging towards danger.
                        Console.WriteLine("Shoving the paladin out of your way, you charge forward towards the large golem.\n Confidently, you swing your "+chosenWeapon.name+" at full force towards the golem's right leg. Pebbles go flying!\n You knew it! Wood beats rock! For a breif moment, you're filled with confidence!\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        golemFightchoiceone();

                        break;
                    }
                case "2":
                case "wait":
                case "Wait":
                case "wait for paladin":
                    {
                        //waiting for the paladin, was it good decision?
                        Console.WriteLine("Unsure of how to smash a creature made of stones, you wait for the paladin to make the first move.\n The paladin, gaze fixed on the towering construct, speaks to you. 'Aim for its head. We'll have to topple it!\n Break its rocky legs. Smash its head. Easy enough, right?\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        golemFightchoiceTwo();

                        break;

                    }

            }

        }
        public void golemFightchoiceone()
        {
            //path followed if you chose to charge the golem
            Console.WriteLine("Your tenacious strike has unfortunately did the damage you first thought it would.\n The emotionless golem looks down at you, grabbing your "+chosenWeapon.name+" and crushing it, leaving you weaponless!\n It punches you so hard that it knocks the breath out of you, sending you flying out of the creek and crashing into a nearby tree.\n However, before it can pursue you and finish you off, the paladin intercepts it, gaining its attention with his own attack!\n 'Your fight is with me, golem!' he yells.\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            golemFightchoiceonetwo();



        }
        public void golemFightchoiceonetwo()
        {
            string choicetwelve;
            //path followed if you chose to wait for the paladin. Choose the next step wisely!
            Console.WriteLine("As you regain your footing, you notice how the paladin fights the golem, dodging its powerful stone punches and chipping away at its frame with his sword.\n If only you had a giant hammer to smash this foe! This gives you an idea. Looking back at the leaning tree behind you, your barbarian brain goes into overtime.\n Will you:\n 1: Rip off a large branch and rejoin the fight\n 2: Get behind the tree and push the entire thing down");
            Console.Write("Choice: ");
            choicetwelve = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choicetwelve)
            {

                case "1":
                    {
                        //this is the path to failure!
                        Console.WriteLine("Reaching up into the leaning tree, you use your barbarian strength to rip out a thick, sturdy branch. It's like a giant "+chosenWeapon.name+"!\n Charging back into battle with your two-handed weapon, you yell 'Duck!' to the paladin as you prepare to swing the large branch.\n However, the paladin doesn't hear you, focusing too much on the monstrous golem swinging devastating punches his way.\n Unable to halt your massive swing, you hit the paladin across the head, taking most of the impact of your attack.\n The paladin slams into the golem, and bounces off its leg. The golem now focuses on you.\n Mistakes have been made.\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        golemFightchoiceonefail();

                        break;


                    }
               case "2":
                    {
                        //path to success!
                        Console.WriteLine("Why take a branch to smash when you can use the entire tree? It only makes sense.\n Taking a few steps behind the tree, you run full force into its trunk, shaking the entire trunk and snapping some roots.\n Keep at it! A few more tackles and it will fall! You yell at the paladin, who's noticed the cracking and shaking tree already.\n 'Move it to position!' you shout. Nodding, the paladin refocuses on the golem swinging heavy punches at him, moving it slowly into position.\n You run full force into the tree again. One more time and it will fall!\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        golemFightchoiceonewin();

                        break;

                    }



            }



        }
        public void golemFightchoiceonefail()
        {
            //the golem pummels you into a fleshy paste here
            Console.WriteLine("Without the paladin to help you, the golem's focus is entirely on you. Emotionless, it moves forward, intent on crushing you.\n With a furious roar, you launch yourself at the stone golem, swinging the large branch at its small head. Unfortunately, the branch is intercepted by its massive hands.\n With ease, it crushes your new "+chosenWeapon.name+", and immedately throws a punch at you once again. You try to block, but your bones are shattered.\n You learn the hard way that wood and flesh are not as hard as stone. Pummeled into a fleshy pile, your story ends here.\n Press ENTER to continue.");
            Console.ReadLine();
            gameOver(" Maybe you should have went with a bigger "+chosenWeapon.name+".");
            
        }
        public void golemFightchoiceonewin()
        {
            //victory over the golem, but you don't get the sword!
            Console.WriteLine("You can see that the paladin has moved the mindless golem into position. Now's your chance!\n Ignoring your bruises and pain, you charge full force once more into the tree. The last of its large roots snap. It's coming down!\n Seeing this, the paladin rolls out of the way, just as the mighty trunk lands directly on top of the golem, knocking it to the ground!\n Quickly, the paladin takes up his sword, rushes over to the struggling golem, and drives his blade through one of its glowing eyes. Shuddering, the golem crumbles.\n It becomes nothing but a pile of inert rocks and pebbles. You've won!");
            Console.ReadLine();
            Console.Clear();
            golemFightchoiceTwoWinaftermath();
        }
        public void golemFightchoiceoneaftermath()
        {
            //No sword or tusk, but at least you get a free trip to the stronghold
            Console.WriteLine("The paladin is pleased with your strength. 'Great Barbarian!,' he declares, 'I could never have defeated such a foe without your aid. For this, I shall help you with one task before I return to my duties!'\n You consider what to ask the shiny, loud man, before deciding to ask him the location of the Ancient Stronghold.\n 'Ah! I know of such a place. You are close to it actually! Let me explain the path.'\n You now know the location of the stronghold! Saying a very quick goodbye, you hurry up the creekside and away from the chatty paladin.");
            Console.ReadLine();
            Console.Clear();
            forestrightpathtakencampencounterTwo();
        }
        public void golemFightchoiceTwo()
        {
            //a bit longer path to possible victory
            Console.WriteLine("The golem makes the first move, slamming its giant stone fist downwards towards you. Prepared, you dodge the attack just in time.\n The paladin makes his move. Taking up his sword, he slashes the golems upper leg, sending pebbles flying.\n You also go on the attack. While the golem is raising its stone fists, you swing your wood "+chosenWeapon.name+" at its arm, testing your foe's durability.\n Some pebbles fly, but not many. Your "+chosenWeapon.name+" is dented.\n You wonder just how you're going to smash this foe.\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            golemFightchoiceTwocontinued();
        }
        public void golemFightchoiceTwocontinued()
        {
            //fight with golem continues
            Console.WriteLine("The paladin barely dodges the golem's slow, powerful fist, bringing down his blade into the construct's arm. It goes clean through the joint!\n If the golem can feel pain, it's impossible to tell. However, the paladin sure does.\n Grabbing the knight by his leg, the golem slams him to the ground before tossing him against a nearby leaning tree.\n Groaning as he struggles to find his footing, it's amazing he's alive at all. Now it's just you and your foe. No one to get in the way!\n The Golem slowly turns to you. You remind yourself that you wanted this fight.\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            golemFightchoiceTwoBigMoment();

        }
        public void golemFightchoiceTwoBigMoment()
        {
            string choicethirteen;
            //only one way to progress here
            Console.WriteLine("The golem's attacks are slow, but punishing. One wrong move will cost you your life. You notice the sword still hanging in its upper arm.\n The paladin is shouting something near the leaning tree on the bank above, but you cannot make it out.\n What will you do?\n 1: Run closer to the paladin, bringing the fight towards him.\n 2: Wait for the golem to attack, then use the sword in its arm to your advantage.\n 3: Wait for the golem to attack, then strike at its legs with your "+chosenWeapon.name+". That was the plan, right?");
            Console.Write("Choice: ");
            choicethirteen = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choicethirteen)
            {

                case "1":
                case "Run closer":
                case "run closer":
                    {
                        //the only path forward
                        Console.WriteLine("What is that damned paladin yelling about? He already got beaten! Deciding that it must be something useful, you move towards him.\n The large golem is in pursuit, determined to destroy the both of you.\n You also demand to know why the knight is throwing himself against the tree! Is his paladin brain broken? Then it dawns on you.\n The paladin is going to smash the golem with a giant "+chosenWeapon.name+": An entire tree! And you're the bait! His brain is really smart after all!\n Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        golemFightchoiceTwoBigMomentWin();

                        break;
                    }
                case "2":
                case "Wait":
                case "wait":
                    {
                        //paste
                        Console.WriteLine("Believing that you're fast enough to grab a small blade stuck in a massive golem's arm, you wait for it to swing its massive fist.\n As its fist comes crashing down, you manage to dodge the crushing blow, only to realize it attacked with the wrong arm!\n Cursing, you rush over to its other arm, hoping that it will attack. However, you fail to realize that fists are made of fingers.\n The golem catches you in its rocky grasp, and squeezes you into two, fleshy piles.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver("Barbarians make a terrible paste.");
                        break;
                    }
                case "3":
                    {
                        //pasty pancake
                        Console.WriteLine("Waiting for the golem to attack, you dodge its massive fists as they crash into the rocky creek. Spinning around its fist, you swing your mighty "+chosenWeapon.name+" at its leg!\n Your stike is true, hitting the golem directly on its lower leg, cracking your "+chosenWeapon.name+" and sending pebbles flying.\n Angry at the golem for not falling down, you continue swinging your weapon madly at its leg as it slowly turns to respond.\n You soon learn that wood isn't as strong as stone, as your "+chosenWeapon.name+" shatters!\n Too distracted by your rage and revelation, you fail to react in time as the golem's fist pounds you into the ground, killing you instantly.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver("Barbarians make a terrible paste.");
                        break;
                    }
                   
            }

        }
        public void golemFightchoiceTwoBigMomentWin()
        {
            //smashing the golem with a really big "+chosenWeapon.name+" is a genious idea
            Console.WriteLine("The golem has caught up to you.\n Oblivious of the paladin's plan, its focus is entirely on you. Raising its massive fist for an attack, you know you cannot let it move from its current spot.\n If you dodge, the golem will continue its mindless pursuit and move out of the way. Confidently, you raise your "+chosenWeapon.name+", hoping it will absorb enough of the incoming attack.\n You might just survive! Before you have time to think it over, a massive stone fist crashes down on you. The "+chosenWeapon.name+" shatters, and you're sent flying into the bank.\n Before the construct has a chance to move, the final roots holding the nearby tree snap, and it comes crashing down on the golem!\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            golemFightchoiceTwoBigMomentWinDetails();


        }
        public void golemFightchoiceTwoBigMomentWinDetails()
        {
            //probably back to the forst camp with all the other paths lol
            Console.WriteLine("The golem has been knocked flat on the ground, struggling against the massive trunk of the fallen tree. The paladin is too tired to act.\n He calls out to you. 'Now! Destroy its head!'\n Shaken and in pain, you still find the energy to get back on your feet. Quickly, you notice the blade in the golem's flailing arm. This is your chance!\n Ignoring your shattered ribs, you call on all your barbarian stamina and strength as you grab the hilt lodged in the construct's arm, pulling it free.\n You don't bother checking the blade's condition. With a mighty roar, you remind the golem who shall slay it on this day as you drive the sword deep into one of its eyes.\n Shuddering, the glowing lights fade from its eyeholes. The stone golem crumbles into nothing but rubble.\n You've won!");
            Console.ReadLine();
            Console.Clear();
            golemFightchoiceTwoWinaftermath();

        }
        public void golemFightchoiceTwoWinaftermath()
        {

            //HERE IS WHERE YOU GET THE SWORD. FIGURE OUT HOW TO WORK THE VARIABLES TO YOUR FAVOR
            chosenWeapon.name = "sword";
            chosenWeapon.weapon = 2;

            Console.WriteLine("'You did it. We did it!' calls the wounded Paladin from the side of the creek. Nodding, you raise his sword in a heroic fashion, which inspires the injured man.\n 'You've proven yourself worthy in the eyes of my order. Please, keep my blade as a reward. I'm heading back home to rest...once I rest here.'\n The paladin passes out. What sort of weak man passes out from broken bones? Oh well. With your new weapon, a shining blade of great craftsmanship, you continue your quest.\n Climbing the steep sides of the creek, you wander back into the forest, swinging your new weapon about, when you catch the scent of smoke. A camp?\n You decide to investigate.");
            Console.ReadLine();
            Console.Clear();
            forestrightpathtakencampencounter();

        }
        public void blurg()
        {

        }
        public void confrontingThepaladin()
        {
            Console.WriteLine("'Who are you!?' you demand loudly. Aggressively, you raise your "+chosenWeapon.name+" in a battle stance.\n The armored man bows to you, making you uneasy. 'I am Ser Guffin, paladin of this realm. Please, lower your weapon. I need your help!'\n Help this man? You begin to wonder what could be in it for you.\n Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            paladinExposition();

        }
        public void gotoAncientstronghold()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("                                                                                            ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("                                What awaits you in the"                                    );
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("     ▄▄▄█████▓ ██░ ██ ▓█████     ▄▄▄       ███▄    █  ▄████▄   ██▓▓█████  ███▄    █ ▄▄▄█████▓");
            Console.WriteLine("     ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▒████▄     ██ ▀█   █ ▒██▀ ▀█  ▓██▒▓█   ▀  ██ ▀█   █ ▓  ██▒ ▓▒");
            Console.WriteLine("     ▒ ▓██░ ▒░▒██▀▀██░▒███      ▒██  ▀█▄  ▓██  ▀█ ██▒▒▓█    ▄ ▒██▒▒███   ▓██  ▀█ ██▒▒ ▓██░ ▒░");
            Console.WriteLine("     ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ░██▄▄▄▄██ ▓██▒  ▐▌██▒▒▓▓▄ ▄██▒░██░▒▓█  ▄ ▓██▒  ▐▌██▒░ ▓██▓ ░ ");
            Console.WriteLine("       ▒██▒ ░ ░▓█▒░██▓░▒████▒    ▓█   ▓██▒▒██░   ▓██░▒ ▓███▀ ░░██░░▒████▒▒██░   ▓██░  ▒██▒ ░ ");
            Console.WriteLine("       ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░    ▒▒   ▓▒█░░ ▒░   ▒ ▒ ░ ░▒ ▒  ░░▓  ░░ ▒░ ░░ ▒░   ▒ ▒   ▒ ░░   ");
            Console.WriteLine("         ░     ▒ ░▒░ ░ ░ ░  ░     ▒   ▒▒ ░░ ░░   ░ ▒░  ░  ▒    ▒ ░ ░ ░  ░░ ░░   ░ ▒░    ░    ");
            Console.WriteLine("      ░                                                    ░                                       ");
            Console.WriteLine("       ██████ ▄▄▄█████▓ ██▀███   ▒█████   ███▄    █   ▄████  ██░ ██  ▒█████   ██▓    ▓█████▄ ");
            Console.WriteLine("     ▒██    ▒ ▓  ██▒ ▓▒▓██ ▒ ██▒▒██▒  ██▒ ██ ▀█   █  ██▒ ▀█▒▓██░ ██▒▒██▒  ██▒▓██▒    ▒██▀ ██▌");
            Console.WriteLine("     ░ ▓██▄   ▒ ▓██░ ▒░▓██ ░▄█ ▒▒██░  ██▒▓██  ▀█ ██▒▒██░▄▄▄░▒██▀▀██░▒██░  ██▒▒██░    ░██   █▌");
            Console.WriteLine("       ▒   ██▒░ ▓██▓ ░ ▒██▀▀█▄  ▒██   ██░▓██▒  ▐▌██▒░▓█  ██▓░▓█ ░██ ▒██   ██░▒██░    ░▓█▄   ▌");
            Console.WriteLine("     ▒██████▒▒  ▒██▒ ░ ░██▓ ▒██▒░ ████▓▒░▒██░   ▓██░░▒▓███▀▒░▓█▒░██▓░ ████▓▒░░██████▒░▒████▓ ");
            Console.WriteLine("     ▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░   ▒ ▒  ░▒   ▒  ▒ ░░▒░▒░ ▒░▒░▒░ ░ ▒░▓  ░ ▒▒▓  ▒ ");
            Console.WriteLine("     ░ ░▒  ░ ░    ░      ░▒ ░ ▒░  ░ ▒ ▒░ ░ ░░   ░ ▒░  ░   ░  ▒ ░▒░ ░  ░ ▒ ▒░ ░ ░ ▒  ░ ░ ▒  ▒ ");
            Console.WriteLine("     ░  ░  ░    ░        ░░   ░ ░ ░ ░ ▒     ░   ░ ░ ░ ░   ░  ░  ░░ ░░ ░ ░ ▒    ░ ░    ░ ░  ░ ");
            Console.WriteLine("                                 Press ENTER to continue"                                     );
            Console.ReadLine();
            Console.Clear();
            strongholdPartone();
        }
        public void strongholdPartone()
        {
            Console.WriteLine("With your " +chosenWeapon.name+" at your side, you venture forth into the imposing structure. ");



        }

        public void gameOver(string deathText)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.Clear();
            Console.WriteLine(deathText);
          
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  ");
            Console.WriteLine(" ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒");
            Console.WriteLine("▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒");
            Console.WriteLine("░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  ");
            Console.WriteLine("░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒");
            Console.WriteLine(" ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Console.WriteLine("  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░");
            Console.WriteLine("Press ENTER to restart");
            Console.ReadLine();
            Console.Clear();
            gameTitle();





        }
    }
}


