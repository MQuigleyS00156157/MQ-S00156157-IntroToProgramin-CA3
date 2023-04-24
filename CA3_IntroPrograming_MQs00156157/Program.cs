using System.ComponentModel.Design;
using System.Net.Cache;

namespace CA3_IntroPrograming_MQs00156157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ReadCSVFile();

            Passanger[] passangers = new Passanger[400];




            int userChoice = 0;
            do
            {
                Console.WriteLine("Please select am Option");
                Console.WriteLine("{0, -10}{1, -20}", "Option", "Discription");
                Console.WriteLine("{0, -10}{1, -20}", "1", "Ship Report");
                Console.WriteLine("{0, -10}{1, -20}", "2", "Occupation Report");
                Console.WriteLine("{0, -10}{1, -20}", "3", "Age Report");
                Console.WriteLine("{0, -10}{1, -20}", "4", "Exit");

                Console.WriteLine("Enter your option (1-4):");
                userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {

                    Manifest();
                    Console.ReadLine();



                }


                if (userChoice == 2)

                {

                    OccupationReport();
                    Console.ReadLine();

                }



                if (userChoice == 3)
                {

                    AgeReport();
                    Console.ReadLine();


                }



                if (userChoice == 4)
                {
                    Console.WriteLine("thank you for filing a report");
                    return;
                }



            }

            while (userChoice != 4);
        }
        static void ReadCSVFile()
        {
            // read all data from csv file
            // create an array of student objects
            // print out the name of each student

            Passanger[] passangers = new Passanger[400]; // assuming ten students, must be big enought to hold all records
            try
            {
                FileStream fs = new FileStream("faminefile.csv", FileMode.Open, FileAccess.Read); ;
                StreamReader sr = new StreamReader(fs);


                // to read the first line in file
                string recordIn = sr.ReadLine();
                recordIn = sr.ReadLine();
                string[] fields = null;// new string[3]; // use this array to store chopped up line from file

                int sum = 0;
                int count = 0;

                while (recordIn != null)
                {
                    fields = recordIn.Split(','); // split where there is a comma
                                                  //Console.WriteLine(fields.Length);
                    if (fields.Length == 10)
                    {
                        //myStudents[count] = new Student();
                        //myStudents[count].StudNum = fields[0];
                        //myStudents[count].StudName = fields[1];

                        //// for the age field in passanger file you will have to do some work
                        //// to pick out the age
                        //myStudents[count].Score = int.Parse(fields[2]);


                        // sum += int.Parse(fields[2]); // must convert to a number if doinf arithmetic

                        count++;
                    }
                    recordIn = sr.ReadLine(); // read next record
                }

                //int avg = sum / count;
                //Console.WriteLine("Average score = {0}", avg);
                sr.Close();

                // test print out all students

                for (int i = 0; i < count; i++)
                {
                    //  Console.WriteLine(myStudents[i].StudName);
                }

            }

            catch (IOException myError)
            {
                Console.WriteLine(myError.Message);

            }
            catch (Exception myError) // general exception which will be used if not exact match found
            {
                Console.WriteLine("there was a problem");
            }


        }

        static void Manifest()
        {


            Console.WriteLine("\n################### \n Manifest Report \n ################");

            string path = @"../../../faminefile.csv";

            bool firstrow = true;

            using (StreamReader sr = File.OpenText(path))
            {
                string input = sr.ReadLine();

                Console.WriteLine("Please enter Ship Name: ");
                string target = Console.ReadLine();
                while (input != null)
                {
                    if (firstrow)  // skip the header line
                    {
                        firstrow = false;
                        input = sr.ReadLine();
                        continue;
                    }
                    // Console.WriteLine(input);
                    string[] fields = input.Split(",");
                    string manifestData = fields[8].Trim().ToLower();


                    if (manifestData.StartsWith(target))
                    {
                        Console.WriteLine(" first name : " + fields[1] + " last name : " + fields[0] + " Ship Name: " + fields[8]);
                    }

                    input = sr.ReadLine();
                }
            }
        }

            static void OccupationReport()
            {
                int farmerCount = 0;
                int dressmakerCount = 0;
                int matronCount = 0;
                int labourCount = 0;
                int spinsterCount = 0;
                int fishermanCount = 0;
                int chambermaidCount = 0;
                int smithCount = 0;
                int clerkCount = 0;
                int masonCount = 0;
                int carpenterCount = 0;
                int bakerCount = 0;
                int tannerCount = 0;
                int saddlerCount = 0;
                int immigrantCount = 0;
                int unemployedCount = 0;


                Console.WriteLine("\n################### \n Occupation Report \n ################");

                string path = @"../../../faminefile.csv";

                bool firstrow = true;

                using (StreamReader sr = File.OpenText(path))
                {
                    string input = sr.ReadLine();

               // string job = Console.ReadLine();

                while (input != null)
                    {
                        if (firstrow)
                        {
                            firstrow = false;
                            input = sr.ReadLine();
                            continue;
                        }
                        string[] fields = input.Split(",");
                        string occupationData = fields[4].Trim().ToLower();
                   
                        if (occupationData.StartsWith("cultivator"))
                        {
                            farmerCount++;
                        }

                        else if (occupationData.StartsWith("dressmaker"))
                        {
                            dressmakerCount++;
                        }

                        else if (occupationData.StartsWith("chamber Maid "))
                        {
                        chambermaidCount++;
                        }

                        else if (occupationData.StartsWith("spinster"))
                        {
                        spinsterCount++;
                        }

                        else if (occupationData.StartsWith("matron"))
                        
                        {
                        matronCount++;
                        }

                         else if (occupationData.StartsWith("laborer"))
                        {
                        labourCount++;
                        }

                        else if (occupationData.StartsWith("fisher"))
                        {
                        fishermanCount++;
                        }

                        else if (occupationData.StartsWith("smith"))
                        {
                        smithCount++;
                        }
                    else if (occupationData.StartsWith("mason"))
                    {
                        masonCount++;
                    }
                    else if (occupationData.StartsWith("baker"))
                    {
                        bakerCount++;
                    }
                    else if (occupationData.StartsWith("tanner"))
                    {
                        tannerCount++;
                    }
                    else if (occupationData.StartsWith("carpenter"))
                    {
                        carpenterCount++;
                    }
                    else if (occupationData.StartsWith("immigrant"))
                    {
                        immigrantCount++;
                    }
                    else if (occupationData.StartsWith("clerk"))
                    {
                        clerkCount++;
                    }

                    else if (occupationData.StartsWith("saddler"))
                    {
                        saddlerCount++;
                    }

                    else
                    {
                            unemployedCount++;
                        }
                        input = sr.ReadLine();


                    }


                    Console.WriteLine(($"{"\n- farmers aboard",-31} {farmerCount}"));
                    Console.WriteLine(($"{"\n- unemployed members aboard ( infants, children etc) ",-31} {unemployedCount}"));
                    Console.WriteLine(($"{"\n- dressmakers aboard",-31} {dressmakerCount}"));
                    Console.WriteLine(($"{"\n- chamber maid aboard",-31} {chambermaidCount}"));
                Console.WriteLine(($"{"\n- bakers aboard",-31} {bakerCount}"));
                Console.WriteLine(($"{"\n- clerk aboard",-31} {clerkCount}"));
                Console.WriteLine(($"{"\n- carpenter aboard",-31} {carpenterCount}"));
                Console.WriteLine(($"{"\n- immigrants aboard",-31} {immigrantCount}"));
                Console.WriteLine(($"{"\n- smiths aboard",-31} {smithCount}"));
                Console.WriteLine(($"{"\n- saddler aboard",-31} {saddlerCount}"));
                Console.WriteLine(($"{"\n- masons aboard",-31} {masonCount}"));
                Console.WriteLine(($"{"\n- matron aboard",-31} {matronCount}"));
                Console.WriteLine(($"{"\n- fishermen aboard",-31} {fishermanCount}"));
                Console.WriteLine(($"{"\n- tanner aboard",-31} {tannerCount}"));
                Console.WriteLine(($"{"\n- labour aboard",-31} {labourCount}"));
                Console.WriteLine(($"{"\n- spinsters aboard",-31} {spinsterCount}"));

            }
        }
        

        static void AgeReport()


        {
            int infantCount = 0;
            int childCount = 0;
            int teenCount = 0;
            int youngadultCount = 0;
            int adultCount = 0;
            int elderCount = 0;
            int unkownCount = 0;

            Console.WriteLine("\n################### \n Age Report \n ################");

            string path = @"../../../faminefile.csv";

            bool firstrow = true;

            using (StreamReader sr = File.OpenText(path))
            {
                string input = sr.ReadLine();

                while (input != null)
                {
                    if (firstrow)
                    {
                        firstrow = false;
                        input = sr.ReadLine();
                        continue;
                    }

                    string[] fields = input.Split(",");

                    // Console.WriteLine(fields[2]);

                    string ageData = fields[2].Trim().ToLower();
                    double age = -1;

                    if (ageData.StartsWith("infant"))
                    {
                        if (double.TryParse(ageData.Substring(17, 2), out age))
                        {
                            age /= 12;
                            infantCount++;
                        }
                        else
                        {
                            unkownCount++;
                        }

                    }

                    else if (ageData.StartsWith("age"))
                    {
                        if (double.TryParse(ageData.Substring(4), out age))
                        {
                            //u
                        }
                        else
                        {
                            unkownCount++;
                        }
                    }

                    else
                    {
                        unkownCount++;
                    }


                    if (age >= 0 && age <= 1)
                    {
                        infantCount++;
                    }

                    else if (age >= 1 && age <= 12)
                    {
                        childCount++;
                    }

                    else if (age >= 12 && age <= 19)
                    {
                        teenCount++;
                    }

                    else if (age >= 20 && age <= 29)
                    {
                        youngadultCount++;
                    }

                    else if (age >= 29 && age <= 49)
                    {
                        adultCount++;
                    }

                    else if (age >= 50)
                    {
                        elderCount++;
                    }

                    input = sr.ReadLine();
                }


            }
            Console.WriteLine($"{"\n- infants aboard (<1 years old )",-31} {infantCount}");
            Console.WriteLine($"{"- children aboard ( 1 - 12 years old )",-30} {childCount}");
            Console.WriteLine($"{"- teenagers aboard ( 12 - 19 years old )",-30}{teenCount}");
            Console.WriteLine($"{"- yough adults aboard aboard ( 20 - 29 years old )",-30}{youngadultCount}");
            Console.WriteLine($"{"- adults aboard ( 30 -49 years old )",-30}{adultCount}");
            Console.WriteLine($"{"- elders aboard ( 50+ years old )",-30}{elderCount}");
            Console.WriteLine($"{"- unkown age group aboard ( ??? years old )",-30}{unkownCount}");

        }


    }
}
    

    














