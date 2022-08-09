using System;

namespace LevitheBarbarian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }
        public static void gameTitle()
        {
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
            first();
        }
        public static void first()
        {
            string gameOverText = " How unfortunate. You've already failed before leaving the village!";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string choice;

            Console.WriteLine("You are Levi the Barbarian, savage warrior from the small village of Normia. After an evening of mild debauchery and howling at the gods, you awaken to panicked knocks on your hut's door.");
            Console.WriteLine("What will you do?");
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
                        Console.WriteLine("Ignoring the calls of the panicked villagers, you roll back into the prickly warmth of your straw bed.");
                        Console.WriteLine("Unfortunately, in your deep, deserved slumber, you meet an undeserved fate.");
                        Console.WriteLine("Unaware of the fires comsuming your village, you become part of the kindling. Your legend ends here.");
                        Console.WriteLine("Press ENTER to continue.");
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
                        Console.WriteLine("Clumisly rushing to the door, you trip over your favorite collection of skulls, falling headfirst into your weapons.");
                        Console.WriteLine("Normally a weapons cache is a good thing for barbarians.");
                        Console.WriteLine("However, your clumsiness has sent your favorite axe right through your face. You die immediately, and the village burns.");
                        Console.WriteLine("Press ENTER to continue.");
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
                        Console.WriteLine("Using your wits, you approach your door quietly, dodging some disheveled skulls on the ground.");
                        Console.WriteLine("Making a mental note to organize them later, you reach your wooden door with ease.");
                        Console.WriteLine("'Who goes there!'you demand. 'Tis I, little Pat from the butcher's shop!', calls a meek voice from the other side of the door.");
                        Console.WriteLine("'Bandits are attacking the village!', he yells. 'Won't you save us, mighty Levi?'");
                        Console.WriteLine("Ever seeking glory, you eagerly agree, grabbing your favorite axe before swinging the door open, charging to meet your foes head on!");
                        Console.WriteLine("Press ENTER to continue");
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
        public static void second()
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
                Console.WriteLine("Choosing a strategic withdrawl, you reposition youself away from the fighting and chaos.");
                Console.WriteLine("Noticing your actions, the very gods you curse punish you for your actions, turning you into a small rodent.");
                Console.WriteLine("Promptly devoured by a stray cat, your legend ends in a whimper as the village is destroyed.");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
                Console.Clear();
                gameOver("Your actions, or incredible lack thereof, has led to your village being pillaged and burned by the bandits.");



            }
            else
            {
                Console.WriteLine("Bandits are attacking and you type that? Try again!");
                Console.WriteLine("Press ENTER to try again.");
                second();

            }
        }
        public static void third()
        {
            int age;

            Console.Clear();
            Console.WriteLine("With a mighty yell, you charge your foes, who don't see you coming.");
            Console.WriteLine("Axe raised, you slaughter the bandits who stand before you, easily overcoming their weak combat skills.");
            Console.WriteLine("However, during the slaughter, your weapon is damaged!");
            Console.WriteLine("Though it be the middle of the night, you appraoch the village blacksmith, who is tossing the still warm bodies of bandits into a wagon.");
            Console.WriteLine("Seeing you approach, he nods in your direction, taking a swig of foul smelling ale");
            Console.WriteLine("'We're lucky to have you here, Levi' he states. 'There's no way I could've handled that many alone.");
            Console.WriteLine("Before you get a chance to speak, he moves his torch closer, eyeing your splintered weapon");
            Console.WriteLine("'Shame about your axe. You must've had it for years. How many years, if you don't mind telling me?' he inquires.");
            Console.WriteLine("Considering this for a moment, you think of how to answer.");
            Console.Write("Number of years you've had your axe: ");


            int.TryParse(Console.ReadLine(), out age);

            if (age > 11)
            {
                Console.Clear();
                Console.WriteLine("The smith is unamused with your lies, as are the gods. However, you never get a chance to lie again.");
                Console.WriteLine("The smithy drops the torch by accident, where it bounces towards the horses attached to the wagon full of bandit bodies!");
                Console.WriteLine("Uttery terrified, the horses neigh in terror.");
                Console.WriteLine("Catching you unprepared, the wagon, improperly attached to the beasts, topples over on you.");
                Console.WriteLine("The weight of the wagon and bodies crushes your ribs, and you suffocate in your own blood.");
                Console.WriteLine("Though not a legend, the village will remember your deeds fondly for a couple weeks, naming a bad drink after you.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.Clear();
                gameOver(" How unfortunate. You've already failed before leaving the village!");

            }
            else
            {
                Console.Clear();
                string choicetwo;
                Console.WriteLine("'Impressive! I rarely have seen such craftsmanship in these parts'.");
                Console.WriteLine("Taking the weapon from you, he eyes the broken item all over.");
                Console.WriteLine("'Yeah, I can fix it. But you'll need to wait a few days.'");
                Console.WriteLine("Begrudgingly, you have no choice but to accept. However, with a collection of fine blades and clubs still at home, you don't fret.");
                Console.WriteLine("On your walk home, you are stopped by the local shaman, who's very much in a panic. Walking up to you and poking your chisled chest with his long, bony finger, he scowls.");
                Console.WriteLine("'You! Barbarian! You must help me, else this village and all who live here will face certain doom!'");
                Console.WriteLine("This seems pretty serious! Will you help?");
                choicetwo = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choicetwo)
                {
                    case "yes":
                    case "y":
                    case "Yes":
                        {
                            Console.WriteLine("The shaman grins, his mouth devoid of teeth. 'I knew you were the right man for the job!");
                            Console.WriteLine("'The time of harvest approaches, but without a proper tribute to the gods, we are surely doomed to starve.");
                            Console.WriteLine("I need you to travel through the Forest of Many Paths and find the ancient stronghold, for within is the Golden Skull!");
                            Console.WriteLine("Bring this skull back to me, so I may bless our village's crops and ensure the harvest!'");
                            Console.WriteLine("You consider this for a moment.");
                            Console.WriteLine("As a barbarian, you can appreciate a man wanting more skulls for their collection. Also liking the idea of a bigger harvest, you agree to bring back this golden skull.");
                            Console.WriteLine("Your adventure is about to begin!");
                            Console.WriteLine("Press ENTER to continue");
                            Console.ReadLine();
                            Console.Clear();
                            gototheforest();
                            break;
                        }
                    case "no":
                    case "No":
                    case "n":
                        {
                            Console.WriteLine("The shaman scowls, cursing you in more languages than you care to count. However, you care little for the puny words of a smelly old man.");
                            Console.WriteLine("After a few days, you retrive your axe, now good as new! You also learn the shaman has left the village.");
                            Console.WriteLine("Days turn into weeks, and weeks to months, and nothing of importance happens. However, more and more villagers begin leaving as the crops continue to fail.");
                            Console.WriteLine("Eventually, even you are forced to leave your home. With no food, you turn to living off the land. Within five minutes of entering the forest, you are bitten on the ankle by a venomous snake.");
                            Console.WriteLine("With no shaman to remove the poison, and no villagers to tend to your needs, you die a slow death undeserving of a mighty barbarian");
                            Console.WriteLine("Press ENTER to continue");
                            Console.ReadLine();
                            Console.Clear();
                            gameOver(" Well...at least no one was around to see your shameful demise.");
                            break;
                        }
                }


            }
        }

        public static void youWin()
        {

        }
        public static void gototheforest()
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
        public static void forestpartone()
        {
            Console.WriteLine("After a quick rest, you grab your finest wooden club from your hut and venture forward, deep into the forest.");
            Console.WriteLine("Knowing little of which direction to go, you rely on your keen instincts. Discovering a path, you follow it.");
            Console.WriteLine("This works for a time. However, soon the path diverges into four trails. Which one will you choose?");

            string choicethree;

            Console.WriteLine("1: The path forward. It looks steady and well-traveled.");
            Console.WriteLine("2: The path to your left. It appears to follow a nearby stream.");
            Console.WriteLine("3: The path to your right. It goes up a muddy, mossy hill and dissappears.");
            Console.WriteLine("4: A barely visable game trail. This could lead you to a tasty brekfast!");
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

                        Console.WriteLine("What were you thinking? The best path is the one forward. You press on without a second thought to the diverging paths.");
                        Console.WriteLine("Soon, it becomes clear that this path has been used very recently, as a neat pile of delicious, roasted meat lays in the center of the dirt road.");
                        Console.WriteLine("Another man's lost, steaming meat is another man's breakfast!");
                        Console.WriteLine("Do you wish to take the meat? Yes or No");
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
                                    Console.WriteLine("Throwing caution to the wind, you grab the slab of roasted meat from the road. What luck! It's pork.");
                                    Console.WriteLine("Delighted, you lean your club next to the nearest tree and happily devour the free meal.");
                                    Console.WriteLine("What a great decision you've made! You feel refreshed and ready for battle!");
                                    Console.WriteLine("Press ENTER to continue");
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
                                    Console.WriteLine("Suspicion gets the better of you. Who would leave a delicious piece of meat out in the open?");
                                    Console.WriteLine("Avoiding the delicious smelling slab, you press onward deeper into the forest.");
                                    Console.WriteLine("Press ENTER to continue");
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
                        Console.WriteLine("Following a stream seems like the best choice. Carefully working your way down the rocky slope, you begin following the gentle stream deeper into the forest.");
                        Console.WriteLine("However, it soon becomes apparent that you're not alone.");
                        Console.WriteLine("Not so far off in the distance, you hear the sounds of clanking metal against stone, swiftly heading in your direction!");
                        Console.WriteLine("Someone seems to be following you.");
                        Console.WriteLine("With plenty of time to prepare, you begin to set a trap.");
                        Console.WriteLine("Press ENTER to continue");
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
                        Console.WriteLine("A wise man once said the right path is always the hardest to take. In this case, quite literally.");
                        Console.WriteLine("Tossing your club up the steep, muddy hill, you use both hands to dig into the moss and exposed roots of the trees to pull yourself upward.");
                        Console.WriteLine("Sure, your chisled chest is now layered in mud, but who cares? Your job is to retrieve a golden skull, not look pretty.");
                        Console.WriteLine("After some effort, you manage to pull yourself up the hill. But what's that? There's a small camp nearby!");
                        Console.WriteLine("Finding your club, you approach from the treeline.");
                        Console.WriteLine("Press ENTER to continue");
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

                        Console.WriteLine("Your keen senses, mainly your stomach, have alerted you to a barely visible game trail zig-zagging through the foliage.");
                        Console.WriteLine("Considering yourself a master tracker, you consider following the trail. Surely there must be something delicious to hunt!");
                        Console.WriteLine("You travel deeper into the forest, following the trail until it leads you to a cave.");
                        Console.WriteLine("What luck! Now your prey is trapped.Will you wait for it to exit the cave, or attack right away?");
                        Console.WriteLine("Attack or Wait?");
                        Console.Write("Choice: ");
                        choicefive = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choicefive)
                        {
                            case "Attack":
                            case "attack":
                                {
                                    Console.WriteLine("What sort of barbarian waits? With a mighty roar, you charge into the dark cave.");
                                    Console.WriteLine("Unaware of the slippery rocks inside, you fall flat on your back as your club goes flying into the air. ");
                                    Console.WriteLine("The dense weapon slams into a particularly pointy stalactite, which falls directly into your chest.");
                                    Console.WriteLine("You die, never knowing what meal you could've eaten.");
                                    Console.WriteLine("Press ENTER to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    gameOver(" Well...at least no one was around to see your shameful demise.");
                                    break;
                                }
                            case "Wait":
                            case "wait":
                                {
                                    Console.WriteLine("You choose to wait patiently for your quarry, eagerly preparing to attack. But what sort of beast are you hunting?");
                                    Console.WriteLine("Your patience pays off as a large mooseboar lumbers out of the foliage near the game trail.");
                                    Console.WriteLine("Such a mighty beast would feed you for an entire day! Though with its sharp tusks and giant antlers, this beast could easily maul you.");
                                    Console.WriteLine("This will be a mighty battle!");
                                    Console.WriteLine("Seeing an opportunity, you leap out and attack the mooseboar! The battle has begun!");
                                    Console.WriteLine("Press ENTER to continue");
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
        public static void forestpathporknoteaten()
        {
            Console.WriteLine("You planned to go deeper into the forest. However, you soon feel that you're being watched! Using your keen survival skills, you set a trap, hiding behind a tree with your club raised.");
            Console.WriteLine("After some time, a hooded figure appears along the path you took. With a roar, you bring down your club on the figure's head, killing them instantly.");
            Console.WriteLine("You step out to loot the body, figuring it could have some food or riches. The moment you do, three figures appear from the foliage, armed with bows!");
            Console.WriteLine("Realizing you've killed their comrade, you have no choice but to fight. Charging the bowmen, they cut you down with ease before you ever reach them, your body filled with arrows.");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            gameOver(" Well...at least no one was around to see your shameful demise.");
        }
        public static void forestpathporkeaten()
        {

            Console.WriteLine("'What in the gods' name are you doing?' says a confused voice from behind the nearest tree.");
            Console.WriteLine("Mouth still full of food, you raise your club in a clumsy manner, unsure if this voice is friend or foe.");
            Console.WriteLine("Chuckles and laughter emanate from the nearby trees, and a hunting party appears around you. 'You're not what we expected to find,' says the closest hunter to you.");
            Console.WriteLine("'The boys over there almost shot you, you know.' A large man traipsing through the forest from out of nowhere was quite a surprise.' ");
            Console.WriteLine("You nod, still eating.");
            Console.WriteLine("'We've been searching for a local beast, a Mooseboar. We heard it likes to eat meat with its usual grassy fare, and set this trap. Have you seen one?'");
            Console.WriteLine("Mouth still full of food, you shake your head.");
            Console.WriteLine("'Shame. Well, what brings a mighty warrior such as yourself out this far?'");
            Console.WriteLine("Mouth finally free of food, you explain your quest to the huntsmen.");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            huntsMenhelpyou();
           
        }
        public static void huntsMenhelpyou()
        {
            Console.WriteLine("You tell the story of the attack on your village, how you single-handedly slaughtered three dozen bandits, and how the feelble village shaman asked you for help.");
            Console.WriteLine("The huntsmen have formed a circle around you, listening intently to your every word.");
            Console.WriteLine("When you tale finally ends, they are left in awe of your strength.");
            Console.WriteLine("'Mighty warrior, we would be happy to help you save your village. However, we must soon return to our own kingdom across the mountains.");
            Console.WriteLine("However, I can personally lead you to this stronghold you speak of. We set up camp there not two nights ago!'");
            Console.WriteLine("With your poor sense of direction, you happily agree to the escort to the stronghold. Looks like you're making better time than you ever imagined!");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            gotoAncientstronghold();


        }
        public static void forestrightpathtakencampencounter()
        {

        }
        public static void forestmooseboarbattle()
        {
            string choicesix;

            Console.WriteLine("Thanks to your patience, the Mooseboar is unable to make the first attack. Turning to face you, the hulking beast is caught completely by surprise!");
            Console.WriteLine(" The first strike is yours. How will you proceed?");
            Console.WriteLine("Attack 1: Swing your club at its nose.");
            Console.WriteLine("Attack 2: Attempt to jump on its back.");
            Console.WriteLine("Attack 3: Swing your club at the side of its head.");
            Console.WriteLine("Attack 4: Throw your club on the ground and taunt the beast.");
            Console.Write("Choice: ");
            choicesix = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choicesix)
            {
                case "1":
                case "attack 1":
                case "Attack 1":
                    {
                        Console.WriteLine("With a mighty yell, you swing your wooden club downwards, directly at the beast's snout.");
                        Console.WriteLine("However, the Mooseboar's antlers deflect the attack. Agitated, the beast immediately charges!");
                        Console.WriteLine("Still off balance, you can do little as the giant beast grabs you with its mouth and slings you to the entrance of the cave.");
                        Console.WriteLine("Dazed, you are barely on your feet before getting impaled by the beast's tusks and merciless antlers!");
                        Console.WriteLine("You take some pleasure knowing that it will be days before the Mooseboar can remove your body from its face.");
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                        gameOver(" Well...at least no one was around to see your shameful demise.");
                        break;
                    }
                case "2":
                case "Attack 2":
                case "attack 2":
                    {
                        string choiceseven;

                        Console.WriteLine("Sensing the danger of the Mooseboar's tusks and antlers, you sidestep the turning beast and leap onto its back!");
                        Console.WriteLine("Bellowing in panic, the beast tries to knock you off its broad back, but your hand grabs its fur tightly as you position yourself to attack.");
                        Console.WriteLine("In the moment, you think of two attacks. Will you swing your club at the soft spot of its neck, or slam the club into its side?");
                        Console.WriteLine("Attack Side, or Attack Neck?");
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

                                    Console.WriteLine("You swing your club with all your might, slamming it into the side of the Mooseboar. You hear ribs snap.");
                                    Console.WriteLine("The beast squeals in pain, trying its best to throw you from its back. In its panic, it charges towards the cave!");
                                    Console.WriteLine("Sensing the danger, you leap from the Mooseboar's back, rolling to the ground as it slams full force into the rocks.");
                                    Console.WriteLine("There is a deep rumbling noise emanating from the cave as cracks form in the stones. The cavern collapses, burying the beast.");
                                    Console.WriteLine("Only the Mooseboar's tusk is visible from the collapsed cave. Dissappointed in the lack of meal, you consider taking it for a trophy.");
                                    Console.WriteLine("Will you take the large tusk? Yes or No?");
                                    Console.Write("Choice: ");
                                    choiceeight = Console.ReadLine().ToLower();
                                    Console.Clear();
                                    switch (choiceeight)
                                    {
                                        case "Yes":
                                        case "yes":
                                            {

                                                Boolean hasMooseboarTusk = true;

                                                if (hasMooseboarTusk)

                                                    Console.WriteLine(" Wanting some sort of trophy for your wasted time, you pry a the tusk from the crushed Mooseboar. An easy task for someone with your strength.");
                                                Console.WriteLine("Though dissappointed at the loss of all that protein, you tie the meter long tusk to the side of your belt and press onward, back into the forest");
                                                Console.WriteLine("Not too long into your trek, you notice a small camp set in a small clearing between the trees! Cautiously, you approach.");
                                                Console.WriteLine("Press ENTER to continue");
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


                                                Console.WriteLine("Choosing a more valorous approach than usual, you leave the beast in its rocky tomb. Grabbing your club, you prepare to move on.");
                                                Console.WriteLine("Besides! There's more glory to be had in saving the village! Who know how they'll express their gratitude to the hero of Normia?");
                                                Console.WriteLine("Caught up in your own fantasies as you stroll through the forest, you suddenly stumble into a clearing, where you find a recently used camp!");
                                                Console.WriteLine("Pulling out your club, you prepare for whatever challenge you may face next.");
                                                Console.WriteLine("Press ENTER to continue");
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

                        Console.WriteLine("Confident that wood is harder than the moist bones of a Mooseboar, you swing your club sideways towards the beast's head with all your might.");
                        Console.WriteLine("Your attack works better than expected! As the creature turns, your strike hits between the antlers and the tusks, blinding it in one eye.");
                        Console.WriteLine("Squealing in terror, the Mooseboar goes into a frenzy, knocking over nearby trees and upheaving large stones, which are sent flying through the air.");
                        Console.WriteLine("Managing to dodge the boulders, you chase after your foe with a mighty battle shout, charging deeper into the forest!");
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        boarLeadstopaladinquest();
                        break;
                    }
                case "Attack 4":
                case "attack 4":
                case "4":
                    {
                        Console.WriteLine("Let no one ever say that you weren't overconfident. Throwing your club to the ground, you puff our your chest and yell profanely at the Mooseboar.");
                        Console.WriteLine("'Your mother was a guinea pig! Your father was a whitetail deer!' you exclaim.");
                        Console.WriteLine("Sensitive about its ancestral lineage, the Mooseboar becomes unnaturally aggressive and, with tears in its eyes, charges you at full speed!");
                        Console.WriteLine("You realize the mistake you've made far too late, as you're gored to death before you even have a chance to apologize.");
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                        gameOvermooseboarfunny();
                        break;


                    }

                  
            }   
        }
        public static void paladinOfthecreekfirstencounter()
        {
            string choicenine;

            Console.WriteLine("You've decided to set a trap for whoever is clanking towards you. Finding a large boulder near the creek, you expertly hide your large frame, club raised.");
            Console.WriteLine("Soon, the loud footsteps approach, and out from the corner appears an exhausted man covered in shining armor! He's breathing heavily, and appears not to notice you.");
            Console.WriteLine("Will you attack the man? Or confront him?");
            Console.Write("Choice: ");
            choicenine = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choicenine)
            { 
                case "Attack":
                case "attack":
                    {
                        string choiceten;

                        Console.WriteLine("Choosing violence is the barbarian way. With a yell, you swing your club at his helmet. Caught completely unaware, the man falls face first into the creek, likely dead.");
                        Console.WriteLine("Ha! What a fool. Thinking that all his armor would save him from your mighty strength!");
                        Console.WriteLine("Standing over his corpse, you consider looting the body. Who knows what treasures a man in knightly armor could have!");
                        Console.WriteLine("Will you choose to loot him, or leave? You are on a quest, after all.");
                        Console.Write("Loot? or Leave?: ");
                        choiceten = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choiceten)
                        {
                            case "loot":
                            case "Loot":
                                {
                                    Console.WriteLine("Greed gets the better of you. Turning the body over, you begin searching for anything of value.");
                                    Console.WriteLine("However, while cursing loudly, trying to take off the man's chestplate, you don't hear the approaching, cumbling footsteps of a towering Rock Golem!");
                                    Console.WriteLine("Caught completely unaware, it bashes you across the back of your head. Dying instantly,your body falls on top of your victim.");
                                    Console.WriteLine("Press ENTER to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    gameOver("Greed is good, but death is always bad!");
                                    break;
                                }
                            case "Leave":
                            case "leave":
                                {
                                    Console.WriteLine("The urge to loot the dead knight is strong, but your suspicious gets the better of you. What was a fully armored man doing in a creek?");
                                    Console.WriteLine("You decide to leave the body alone. He didn't appear to have a visible sack of loot anyways.");
                                    Console.WriteLine("Unsure of why the man was running around in a creek, or if he was even after you, you decide to leave the rocky creek and return to the forest.");
                                    Console.WriteLine("After pushing through the dense trees aimlessly for some time, you come across a camp in a clearing! Cautiously, you approach.");
                                    Console.WriteLine("Press ENTER to continue");
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
                        Console.WriteLine("As the armored figure approaches, you consider just why there's an armored man chasing you. Could the smelly shaman have sold you out?");
                        Console.WriteLine("You want answers!");
                        Console.WriteLine("To hell with this hiding business. A barbarian faces their problems head on! Leaping around the corner, you confront the armored man head on!");
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        confrontingThepaladin();
                        break;

                    }



             
            }

        }
        public static void gameOvermooseboarfunny()
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
        public static void boarLeadstopaladinquest()
        {
            Console.WriteLine("Soon, the Mooseboar gains quite a distance on you. Who knew that a four-legged animal could move so fast!");
            Console.WriteLine("Making a mental note to smash legs and not eyes next time, you continue your pursuit, but it's apparent your quarry is getting away.");
            Console.WriteLine("The beast has managed the impossible and escaped you. Now you find yourself at the bank of a wide, rocky creek between the tall trees.");
            Console.WriteLine("You soon realize you're not alone! There's an armored man staring at you. Why is a knight in the middle of a creek in the woods?");
            Console.WriteLine("A cunning barbarian such as yourself will find the answer. What were you doing before?");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            confrontingThepaladin();
        }
        public static void strongholdPartone()
        {

        }
        public static void paladinExposition()
        {
            Console.WriteLine("You decided to listen to the Guffin's words. You may grow to regret this.");
            Console.WriteLine("'As I mentioned, I am the great Ser Guffin, great paladin of The Holy Exposition, the glorious order of the realm. THIS realm, in fact.");
            Console.WriteLine("I bet you're wondering what someone as well-equipped as I am doing out here? Well, let me spin you a great yarn.");
            Console.WriteLine("A grand tale of adventure, betrayal, love, tragedy, comedey, and intrigue!'");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            expositionOne();

        }
        public static void expositionOne()
        {
            Console.WriteLine("'Precisely one month and two days ago, I awoke in a panic. My superior, Ser Exposi had barged into my chambers!");
            Console.WriteLine("'He began recanting a lovely tale about his wife and fourteen children, and after two hours, he told me just why he decided to visit.");
            Console.WriteLine("The King himself had given him a most sensitive quest, and time was of the essence! We had to act fast, else the King's bastard child would be in danger!");
            Console.WriteLine("I know what you're thinking. Our great King has a bastard child? Well, it's actually a great story. Allow me to fill you in.'");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            expositionTwo();



        }
        public static void expositionTwo()
        {
            Console.WriteLine("'The King was not always the infallible being you know in the present. Eleven years ago, he was quite the wild one, spreading his...influence in many places.");
            Console.WriteLine("In this case, his influence was most appreciated. In a village not too far from here, one of his mistresses went and had a child!");
            Console.WriteLine("And that child was the King's first bastard. First, I hear you say? Well, there's actually four more. Allow me to elaborate.");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            expositionThree();





        }
        public static void expositionThree()
        {
            Console.WriteLine("'As I mentioned, there are four more bastard offspring of the King. Yes, there are five in total. As a paladin of The Holy Exposition, it's my duty to keep them all in check.");
            Console.WriteLine("The first of the other four was a girl, and members of my order were tasked with keeping her from becoming a witch. An easy task, surely. However!");
            Console.WriteLine("It was one which become monumentally more challenging once you consider the lineage of her mother, a witch from the bogwoods! Now, I bet you're wondering,");
            Console.WriteLine("why did our King find the time to spread his seed that far out of the way of the kingdom? And why a witch? Well, let me tell you a story.");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            expositionFour();




        }
        public static void expositionFour()
        {
            Console.WriteLine("'It all began when our King was still a prince, under the heel of his cruel father.'");
            Console.WriteLine("For a blessed moment, the paladin finally stops talking. You begin to say somehting but are promptly cut off.");
            Console.WriteLine("'A tragedy of love never realized! At least, not spiritually. Our King, the Prince at the time, grew fond of the witch, and vowed to return someday!");
            Console.WriteLine("And though his father kept them apart until his death, the two eventually rejoined, rejoiced in each other's company for at least one night, and boom!");
            Console.WriteLine("A daughter was born. Now, the King has been quite clear with his wishes, and demands we keep her away from the dark arts of her mother. However!");
            Console.WriteLine("Her story has nothing to do with why I ended up in this creek, talking to you, my fine shirtless friend. For that tale starts somewhere else!");
            Console.WriteLine("Allow me to explain.'");
            Console.WriteLine("Better press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            expositionFive();


        }
        public static void expositionFive()
        {

            Console.WriteLine("Your brain feels fuzzy. The paladin continues to talk at you.");
            Console.WriteLine("'Friend! As I was saying before, if you remember from before the tale of the King's witch mistress, I was awoken by the great Ser Esposi.");
            Console.WriteLine("And he had a mission for me, as no other paladin could be tasked with such a harrowing mission. His first bastard had been kidnapped by a merciless mage!");
            Console.WriteLine("This fiend was once a mighty spellcaster who served the King, but after a lengthy plot to assassinate him failed, he fled deep into these woods,");
            Console.WriteLine("possibly taking the bastard child hostage! Now, I know what you're thinking. Possibly? Well you see, there's a good reason we beleive the fiendish");
            Console.WriteLine("fire thrower has taken the boy. It all began when...'");
            Console.WriteLine("Press ENTER to...hey, what's that?");
            Console.ReadLine();
            Console.Clear();
            expositionEnds();





        }
        public static void expositionEnds()
        {
            Console.WriteLine("The paladin's many words are like a curse on your mind. His stories bleeding into each other and meaning nothing to you.");
            Console.WriteLine("However, staring blankly behind the paladin has paid off, as you see a massive, monstrous creature approaching!");
            Console.WriteLine("'Quiet, Paladin!' you yell, waving your club towards the approaching monster. 'There's a golem coming!'");
            Console.WriteLine("The paladin turns and sees the approaching foe. Finally shutting up, he draws the sword from his side.");
            Console.WriteLine("'the mage has sent a golem to kill us!' he yells. 'Prepare youself, friend!'");
            Console.WriteLine("Finally, something is happening! You prepare for the battle!");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            golemCreekbattle();

        }
        public static void golemCreekbattle()
        {
            string choiceeleven;

            Console.WriteLine("A monstrous golem, appearing to be made of the very rock and smooth stones of the creek, towers above you and the paladin. Its body is double your height.");
            Console.WriteLine("Dripping wet, it would be difficult to scale the construct by normal means and attack its small head.");
            Console.WriteLine("You cannot predict how the paladin will act. How will you proceed?");
            Console.WriteLine("1: Charge ahead of the paladin and swing your club at the golem's legs.");
            Console.WriteLine("2: Wait for the paladin to make the first move.");
            Console.WriteLine("3: Flee. There's no glory in fighting rocks!");
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

                        Console.WriteLine("Shoving the paladin out of your way, you charge forward towards the large golem.");
                        Console.WriteLine("Confidently, you swing your club at full force towards the golem's right leg. Pebbles go flying!");
                        Console.WriteLine("You knew it! Wood beats rock! For a breif moment, you're filled with confidence!");
                        Console.WriteLine("Press ENTER to continue");
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
                        Console.WriteLine("Unsure of how to smash a creature made of stones, you wait for the paladin to make the first move.");
                        Console.WriteLine("");

                        break;

                    }











            }



        }
        public static void golemFightchoiceone()
        {




        }
        public static void notusedyetone()
        {

        }
        public static void notusedyetbutwillbe()
        {

        }

        public static void blurg()
        {

        }
        public static void confrontingThepaladin()
        {
            Console.WriteLine("'Who are you!?' you demand loudly. Aggressively, you raise your club in a battle stance.");
            Console.WriteLine("The armored man bows to you, making you uneasy. 'I am Ser Guffin, paladin of this realm. Please, lower your weapon. I need your help!'");
            Console.WriteLine("Help this man? You begin to wonder what could be in it for you. ");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            paladinExposition();

        }
        public static void gotoAncientstronghold()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("                                                                                            ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("                                What will you find in the"                                    );
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
       
        
        public static void gameOver(string deathText)
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


