// Application created while following the Microsoft Learn Course:
// Guided project - Develop conditional branching and looping structures in C#
// while completing the freeCodeCamp certification

/*
 * The goal of this application is to match stray pets with potential owners
 * This application will use predefined sample data, iterate a "menu options
 * and user selection" code block, conditionally branch based on the menu 
 * selections, display information based on the menu selections, and have
 * the option for a user to add new pet(s) into the database.
 * Pet Characteristics:
 * Pet ID #
 * Species
 * Age
 * Physical condition/characterstics
 * Personality
 * Nickname
 */

// the ourAnimals array will store the following: 
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            suggestedDonation = "49.99";
            break;
        
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss in Boots";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;
    }

    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:c2}";
}

do
{



    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type \"Exit\" to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    //Console.WriteLine($"You selected menu option {menuSelection}.");
    //Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    //readResult = Console.ReadLine();

    switch(menuSelection)
    {
        case "1":
            // List all pet information here
            Console.WriteLine("--------------------");

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {

                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }

                    Console.WriteLine("--------------------");
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Add a new animal into the array
            Console.WriteLine("--------------------");
            string anotherPet = "y";
            int petCount = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount++; 
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We are currently serving {petCount} animals. We can look for " +
                    $"homes for {(maxPets - petCount)} more animals.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;
                do
                {
                    Console.WriteLine("\r\nEnter \"dog\" or \"cat\" to begin a new entry:");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                            validEntry = true;
                    }
                } while (validEntry == false);

                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or a question mark (?) if the age is unknown:");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else if (animalAge == "?")
                        {
                            validEntry = true;
                        }
                        else
                        {
                            validEntry = false;
                            Console.WriteLine("Please enter a valid animal age.");
                        }
                    }
                } while (validEntry == false);

                do
                {
                    Console.WriteLine("Please enter a physical description of the animal (like size, color, gender, weight, housetrained, etc.):");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();

                        if (animalPhysicalDescription == "")
                            animalPhysicalDescription = "tbd";
                    }
                } while (animalPhysicalDescription == "");

                do
                {
                    Console.WriteLine("Please enter a description of the animal's personality (likes, dislikes, trick, energy level, etc.):");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();

                        if (animalPersonalityDescription == "")
                            animalPersonalityDescription = "tbd";
                    }
                } while (animalPersonalityDescription == "");

                do
                {
                    Console.WriteLine("Please enter the animal's nickname:");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();

                        if (animalNickname == "")
                            animalNickname = "tbd";
                    }
                } while (animalNickname == "");

                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                petCount++;

                if (petCount < maxPets)
                {
                    Console.WriteLine("Do you want to enter the information for another pet? (y/n)");

                    do
                    {
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }
                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("\nUnfortunately, we do not have the ability to service more pets.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Check all animals have an age and physical description
            Console.WriteLine("--------------------");
            bool noMissingData = true;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    string enteredAge = ourAnimals[i,2].Substring(4);
                    int petAge;
                    bool validEntry = int.TryParse(enteredAge, out petAge);
                    bool exitLoop = false;

                    if (validEntry == false)
                    {
                        noMissingData = false;
                        do
                        {
                            if (ourAnimals[i, 3] != "Nickname: ")
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]}, {ourAnimals[i, 3]}, is missing an age.");
                            }
                            else
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing an age.");
                            }
                            Console.WriteLine("Please enter an age or a question mark if it is still unknown:");
                            readResult = Console.ReadLine();
                           
                            if (readResult != null)
                            {
                                animalAge = readResult;
                                if (animalAge != "?")
                                {
                                    validEntry = int.TryParse(animalAge, out petAge);
                                }
                                else if (animalAge == "?")
                                {
                                    validEntry = true;
                                }
                                else
                                {
                                    validEntry = false;
                                    Console.WriteLine("Please enter a valid animal age.");
                                }
                            }

                            if (validEntry)
                            {
                                if (animalAge != "?")
                                {
                                    ourAnimals[i, 2] = "Age: " + petAge.ToString();
                                }
                                else if (animalAge == "?")
                                {
                                    ourAnimals[i, 2] = "?";
                                }
                                    exitLoop = true;
                            }
                            else exitLoop = false;

                        } while(exitLoop == false);
                    }

                    string enteredDescription = ourAnimals[i, 4].Substring(21);

                    if (enteredDescription == null || enteredDescription.Trim().Length == 0)
                    {
                        noMissingData = false;
                        validEntry = false;
                        do
                        {
                            if (ourAnimals[i, 3] != "Nickname: ")
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]}, {ourAnimals[i, 3]}, is missing a phyical description.");
                            }
                            else
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing a phyical description.");
                            }
                            Console.WriteLine("Please enter a phyical description or hit enter if it is still unknown:");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                if (readResult.Length > 0)
                                {
                                    ourAnimals[i, 4] = "Physical Description: " + readResult.ToLower();
                                }
                                validEntry = true;
                            }
                        } while (validEntry == false);
                    }
                }
            }

            if (noMissingData)
            {
                Console.WriteLine("All pets have an age and physical description!");

            }
            else
            {
                Console.WriteLine("All updates have been made!");
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            // Check all animals have nicknames and personality descriptions
            Console.WriteLine("--------------------");
            bool noMissingData4 = true;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    string enteredNickname = ourAnimals[i, 3].Substring(9);
                    bool validEntry;
                    if (enteredNickname == null || enteredNickname.Trim().Length == 0)
                    {
                        noMissingData4 = false;
                        validEntry = false;
                        do
                        {
                            Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing a nickname.");
                            Console.WriteLine("Please enter a nickname or hit enter if it is still unknown:");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                if (readResult.Length > 0)
                                {
                                    ourAnimals[i, 3] = "Nickname: " + readResult.ToLower();
                                }
                                validEntry = true;
                            }
                        } while (validEntry == false);
                    }
                    string enteredDescription = ourAnimals[i, 5].Substring(12);
                    
                    if (enteredDescription == null || enteredDescription.Trim().Length == 0)
                    {
                        noMissingData4 = false;
                        validEntry= false;
                        do
                        {
                            if (ourAnimals[i, 3] != "Nickname: ")
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]}, {ourAnimals[i, 3]}, is missing a personality description.");
                            }
                            else
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing a personality description.");
                            }
                            Console.WriteLine("Please enter a personality description or hit enter if it is still unknown:");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                if (readResult.Length > 0)
                                {
                                    ourAnimals[i, 5] = "Personality: " + readResult.ToLower();
                                }
                                validEntry = true;
                            }
                        } while (validEntry == false);
                    }
                }
                
            }
            if (noMissingData4)
            {
                Console.WriteLine("All pets have a nickname and personality description!");

            }
            else 
            {
                Console.WriteLine("All updates have been made!");
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
       
        case "5":
            // Update an animal's age
            Console.WriteLine("--------------------");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Update an animal's personality description
            Console.WriteLine("--------------------");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // List cats that match entered characteristics
            Console.WriteLine("--------------------");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // List dogs that match entered characteristics
            Console.WriteLine("--------------------");
            string dogCharacteristics = "";

            while (dogCharacteristics == "")
            {
                Console.WriteLine("\nEnter one (1) characteristic you would like to search for in a dog");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristics = readResult.ToLower().Trim();
                }
            }

            string dogDescription = "";
            bool noMatchesDog = true;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    if (dogDescription.Contains(dogCharacteristics))
                    {
                        Console.WriteLine($"\nOur Dog {ourAnimals[i, 3]} is a match!");
                        Console.WriteLine(dogDescription);
                        noMatchesDog = false;
                    }
                }
            }

            if (noMatchesDog)
            {
                Console.WriteLine($"Unfortunately, none of our dogs matched your desired characteristic of:" +
                    $"\n{dogCharacteristics}");
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit" && menuSelection != "q");
