// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int first = 1;
//int second = 2;
//int third = 3;
//int fourth = 4;
//int fifth = 5;
//object[] stuff = { 1, "hi" };
//object[] stuf = new object[2];
//stuf[1] = first;


//Random rnd = new Random();
//string[] arsenal = { "recket" , "drone" , "tank"};
//List<int> houses = new List<int>();

//for (int i = 0; i <= rnd.Next(1000); i++)
//{
//    houses.Add(i);
//}  

//Console.WriteLine("who many houses to destory");

//if(int.TryParse(Console.ReadLine(), out int some)){
//        if (some <= houses.Count)
//        {
//            for (int j = 0; j <= some; j++)
//            {
//                int rnd2 = rnd.Next(0,houses.Count-1);
//                houses.RemoveAt(rnd2);
//                string arsenal2 = arsenal[rnd.Next(0,2)];
//                Console.WriteLine($"house {rnd2} ar {arsenal2}");
//            }
//        }
//    }

//1.
//List<string> names = new List<string> {"nachum", "meir", "moshe", "menachem", "yzchak"};
//names.Add("avi");
//names.Add("avrame");
//names.Remove("avi");
//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//2.
//Dictionary<string, int> dict = new Dictionary<string, int>
//{
//    {"nachum",24 },
//    {"meir",25 },
//    {"menachem", 23 }
//};
//dict.Add("noch", 18);
//dict["menachem"] = 24;
//foreach(var key in dict)
//{
//    Console.WriteLine($"Sir {key.Key} year old {key.Value}");
//}


//3.
//List<Dictionary<string, string>> listDict = new List<Dictionary<string, string>>();
//listDict.Add(new Dictionary<string, string>
//{
//    {"name","nachum" },
//    {"email","na@gmail.com" },
//    {"status","smart" }
//});
//listDict.Add(new Dictionary<string, string>
//{
//    {"name", "menachem" },
//    {"email", "men@gmail.com" },
//    {"status", "smaily" }
//});
//foreach(var x in listDict)
//{
//    Console.WriteLine(x["email"]);
//}


//4.
//List<string> username = new List<string> { "nahum"};
//Console.WriteLine("plaese enter username");
//string entername = Console.ReadLine();
//int index = 0;
//foreach(string s in username)
//{
//    if (s == entername)
//    {
//        Console.WriteLine($"yes user name {entername} found in index {index}");
//        break;
//    }
//    else if (index == username.Count - 1)
//    {
//        Console.WriteLine("Username not registered");

//    }
//    index++;
//}

//Dictionary<string, Dictionary<string, bool>> so = new Dictionary<string, Dictionary<string, bool>>();

//5.
//Dictionary<string, List<string>> soldier = new Dictionary<string, List<string>>
//{
//    {"beni", ["recorder", "map", "notebook"] },
//    {"mati",["map"] },
//    {"nachum" , ["recorder", "map", "notbook"]}
//};
//foreach (var key in soldier)
//{
//    if (key.Value.Count < 3)
//    {
//        Console.WriteLine($"{key.Key} is missing tools");
//        continue;
//    }
//    Console.WriteLine($"{key.Key} is ready for intel work");
//}