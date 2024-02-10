using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System.Reflection.PortableExecutable;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNumber = 0; 

            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            string userInput = Console.ReadLine();
            itemNumber = Convert.ToInt64(userInput);
            

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null; // store reference to Appliance object so that the number the user inputs, matches the specified item number. 

            // Loop through Appliances
                // Test appliance item number equals entered item number
                    // Assign appliance in list to foundAppliance variable
            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }
               
            }

                    // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
                // Write "No appliances found with that item number."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            else
            {
                if (foundAppliance.IsAvailable)
                {
                    foundAppliance.Checkout();
                    Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
                    // Write "Appliance has been checked out."
                // Otherwise (appliance isn't available)
                    // Write "The appliance is not available to be checked out."
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string enteredBrand = Console.ReadLine();



            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();
            

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach(var appliance in Appliances)
            {
                if(appliance.Brand == enteredBrand)
                {
                    foundAppliances.Add(appliance);
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
           
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");
            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");
            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");

            // Create variable to hold entered number of doors
            int enteredNumDoors = 0;

            // Get user input as string and assign to variable
            string inputNumDoors = Console.ReadLine();
            

            // Convert user input from string to int and store as number of doors variable.
            enteredNumDoors = Convert.ToInt32(inputNumDoors);

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;
            foreach (var appliance in Appliances)
            {
                if(appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    
                    if(enteredNumDoors == 0 || refrigerator.Doors == enteredNumDoors)
                    {
                        foundAppliances.Add(refrigerator);
                    }

                }

            }

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list
            
            

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");
            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");
            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");

            // Get user input as string and assign to variable
            string userInputOptions = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;
            

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            if (userInputOptions == "0")
            {
                grade = "Any";
            }
            else if (userInputOptions == "1")
            {
                grade = "Residential";
            }
            else if (userInputOptions == "2")
            {
                grade = "Commercial";
            }
            else
            {
                Console.WriteLine("Invalid option");
                return;
            }

            // Return to calling (previous) method
            // return;

            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");
            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");

            // Get user input as string
            string userInputVoltage = Console.ReadLine();
            // Create variable to hold voltage
            int voltage = Convert.ToInt32(userInputVoltage); 

            // Test input is "0"
            // Assign 0 to voltage
            if (userInputVoltage == "0" || userInputVoltage == "Any")
            {
                voltage = 0;
            }
            // Test input is "1"
            // Assign 18 to voltage
            else if (userInputVoltage == "1" || userInputVoltage == "18")
            {
                voltage = 18; 
            }
            // Test input is "2"
            // Assign 24 to voltage
            else if (userInputVoltage == "2" || userInputVoltage == "24")
            {
                voltage = 24;
            }
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            else
            {
                Console.WriteLine("invalid option");
                return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> foundAppliances = new List<Appliance>();

            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                if(appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    if(grade == "Any" || (vacuum.Grade == userInputOptions && voltage == 0) || vacuum.BatteryVoltage == voltage)
                    {
                        foundAppliances.Add(vacuum);
                    }
                }
            }
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Kitchen"
            Console.WriteLine("1 - Kitchen");
            // Write "2 - Work site"
            Console.WriteLine("2 - Work site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string userInputRoomType = Console.ReadLine();

            // Create character variable that holds room type
            char roomType; 


            // Test input is "0"
            // Assign 'A' to room type variable
            if (userInputRoomType == "0" || userInputRoomType == "A")
            {
                roomType = 'A';
            }
            // Test input is "1"
            // Assign 'K' to room type variable
            else if (userInputRoomType == "1" || userInputRoomType == "K")
            {
                roomType = 'K';
            }
            // Test input is "2"
            // Assign 'W' to room type variable
            else if (userInputRoomType == "2" || userInputRoomType == "W")
            {
                roomType = 'W';
            }
            // Otherwise (input is something else)
            // Write "Invalid option."
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }
            // Return to calling method
            // return;

            // Create variable that holds list of 'found' appliances
            List<Appliance> foundAppliances = new List<Appliance>();

            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave
            foreach (var appliance in Appliances)
            {
                if(appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if(roomType == 'A' || microwave.RoomType == roomType)
                    {
                        foundAppliances.Add(microwave);
                    }
                }
            }

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Quietest"
            Console.WriteLine("1 - Quietest");
            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter");
            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet");
            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");

            // Get user input as string and assign to variable
            string userInputSound = Console.ReadLine();

            // Create variable that holds sound rating
            string soundRating; 

            // Test input is "0"
            // Assign "Any" to sound rating variable
            if (userInputSound == "0" || userInputSound == "Any")
            {
                soundRating = "Any";
            }
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            else if (userInputSound == "1"|| userInputSound == "Qt")
            {
                soundRating = "Qt";
            }
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            else if (userInputSound == "2" || userInputSound == "Qr")
            {
                soundRating = "Qr";
            }
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            else if (userInputSound == "3" || userInputSound == "Qu")
            {
                soundRating = "Qu";
            }
            // Test input is "4"
            // Assign "M" to sound rating variable
            else if (userInputSound == "4" || userInputSound == "M")
            {
                soundRating = "M";
            }
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> foundAppliances = new List<Appliance>();

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher
            foreach (var appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if(userInputSound == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        foundAppliances.Add(dishwasher);
                    }
                }
            }

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 – Refrigerators"
            Console.WriteLine("1 – Refrigerators");
            // Write "2 – Vacuums"
            Console.WriteLine("2 – Vacuums");
            // Write "3 – Microwaves"
            Console.WriteLine("3 – Microwaves");
            // Write "4 – Dishwashers"
            Console.WriteLine("4 – Dishwashers");

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance:");

            // Get user input as string and assign to appliance type variable
            string userInputType = Console.ReadLine();
            Appliance appliance = null;

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");

            // Get user input as string and assign to variable
            string userInputNum = Console.ReadLine();

            // Convert user input from string to int
            int numOfApp = Convert.ToInt32(userInputNum);
            // Create variable to hold list of found appliances
            List<Appliance> foundAppliances = new List<Appliance>();

            // Loop through appliances
            foreach (var currentAppliance in Appliances)
            {
                if(userInputType == "0")
                {
                    foundAppliances.Add(currentAppliance);
                }
                else if(userInputType == "1")
                {
                    if(currentAppliance is Refrigerator)
                    {
                        foundAppliances.Add(currentAppliance);
                    }
                }
                else if(userInputType == "2")
                {
                    if(currentAppliance is Vacuum)
                    {
                        foundAppliances.Add(currentAppliance);
                    }
                }
                else if(userInputType == "3")
                {
                    if(currentAppliance is Microwave)
                    {
                        foundAppliances.Add(currentAppliance);
                    }
                }
                else if(userInputType == "4")
                {
                    if(currentAppliance is Dishwasher)
                    {
                        foundAppliances.Add(currentAppliance);
                    }
                }
            }
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());
            foundAppliances.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
            DisplayAppliancesFromList(foundAppliances, numOfApp);
        }
    }
}
