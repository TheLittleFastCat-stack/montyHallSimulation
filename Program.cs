

String input;

int sampleCount = 0;
int samplesCompleted = 0;
     
int carDoor = 0;
int chosenDoor = 0;

int switchingWins = 0;
int stayWins = 0;



Random random = new Random();

readConsole();


void readConsole(){
    
    Console.WriteLine("Begin simulation? ( y / n)");
    input = Console.ReadLine();
    if(input == "y"){
        Console.WriteLine("Sample count:"); 
        int i = 1;
        while(i == 1)
        {
            input = Console.ReadLine();
            if (Int32.TryParse(input, out sampleCount))
            {
                Console.WriteLine("Sample count confirmed: ");
                Console.WriteLine(sampleCount);
                simulation();
                
            }
            else
            {
                Console.WriteLine("Error: wrong format, enter number only!");
            }

            
            
        }
    }
    if(input == "n"){
        System.Environment.Exit(1);
    }
    
}

void simulation()
{   
    switchingWins = 0;
    stayWins = 0;
    
    Console.WriteLine("simulating switching technigue <°?°>: ");
    Console.WriteLine(sampleCount);

    while(samplesCompleted < sampleCount)
    {
        carDoor = random.Next(1, 4);
        chosenDoor = random.Next(1, 4);


        int openedDoor;
        do
        {
            openedDoor = random.Next(1, 4);
        }
        while (openedDoor == carDoor || openedDoor == chosenDoor);


        int switchedDoor = 6 - chosenDoor - openedDoor;

        if (switchedDoor == carDoor)
        {   
            switchingWins++;
            Console.WriteLine("WON by switching <°O°>");
        }
        else
        {
             Console.WriteLine("LOST even when swithing <°~°>");
        }


        samplesCompleted ++;
    }

    Console.WriteLine("simulating staying technigue <°-°>: ");
    Console.WriteLine(sampleCount);
    
    samplesCompleted = 0;
    while(samplesCompleted < sampleCount)
    {
        carDoor = random.Next(1, 4);
        chosenDoor = random.Next(1, 4);


        if(chosenDoor == carDoor)
        {
            Console.WriteLine("WON by staying <°O°>");
            stayWins ++;
        }
        else
        {
            Console.WriteLine("LOST by staying <°~°>");
        }

        samplesCompleted ++;
    }

    displayData();
    
}

void displayData()
{
    
    Console.WriteLine("\nSimulation complete! <°o°>");
    Console.WriteLine("Total simulations: ");
    Console.WriteLine(sampleCount * 2);
    Console.WriteLine("Wins by switching: ");
    Console.WriteLine(switchingWins);
    Console.WriteLine("Wins by staying: ");
    Console.WriteLine(stayWins);

    readConsole();
}

