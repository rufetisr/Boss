using BossProg;
using System;
using System.IO;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading;

List<string> vacansies = new()
{
    {
        @"      
1. Vakansiya - proqramci 
-Texniki ali tehsil ( İT sferasinda tehsi arzuolunandir) 
-1 ilden az olmayan inkisaf uzre is tecrubesi,     
-Bank sektorunda is tecrubesi arzuolunandir
-JAVA,
-C#,VISUAL PASCAL proqramlasdirmadillerindenbirini bilmeli
   Maas(1000-1500)"
    },
    {
        @"
2. Vakansiya - Mid/Senior Full Stack PHP(Laravel) developer
 - MYSQL ve PostgresSql ile tecrube ve SQLsorgulari yazmaq uzre bilikler
 - HTML,
 - CSS,
 -JavaScript haqqinda esas bilikler
 - VueJS ile yuksek seviyyede islemebacarigi(Vuetify ve ya Quasar iletecrube)
 - DevOps bilikleri(deploymentseviyyesinde)
    Maas(1400-2000)"
    },
    {
        @"
3. Vakansiya - Qrafik Dizayner
-İs tecrubesi : 1 ilden asagi
- Coral Draw, Photoshop
- Adobe Illustrator ,İndesignproqramlarinda yukse seviyyede islemebacarigi ;
- Metbee avadanliqlari haqqinda texnikibilik ;
-Capa hazirliq merhelesinden anlayisliolmali 
    Maas(800-1100)"
    },
    {
        @"
4. Vakansiya - Sistem inzibatcisi
-MS Windows serverler (Windows Server2012, 2016)uzre bilikler
-Merkezi avtorizasiya ve   idareetmesistemleri il is tecrubesi - ActiveDirectory, Group policy
-Backup sistemleri ile is tecrubesi -Veeam Backupand Replication
-VMware uzre bilikler (Esxi 6,6.5 vSphere6 /vSAN )
-Router, Firewall-lar ile  isleye bilme bacarigi (NAT, VIPs, Network Security, VPN Tunneling, Proxy)
    Maas(1300-1500)"
    }
};

Employer employer1 = new(1, "Adil", "Resulov", "Baki", "050-478-23-85", 27, "Prosys MMC", vacansies);

int a2 = 0;
int SearchForVacancies()
{
    Console.Write("Search:");
    string str = Console.ReadLine();

    var a = vacansies.Where(v => v.ToLower().Contains(str.ToLower())).Select(s => s).ToList();
    Console.Clear();
    Console.WriteLine($"Search results: {a.Count} is elani ");
    a.ForEach(s => Console.WriteLine(s));
    var s = a.ToString();
    var num = 1;
    if (a.Count == 1 && s.Contains($"{num}. "))
    {
        a2 = num;
    }
    return a.Count;
}


void ShowVacancies()
{
    Console.Clear();
    Console.WriteLine("\t\t--Vakansiyalar--");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    vacansies.ForEach(vc => Console.WriteLine(vc));
    Console.ResetColor();
}


Worker worker1 = new(1, "Murad", "Eliyev", "Baki", "051-734-23-65", 20,
    new CV()
    {
        Bacariqlar = "C++, C#, Java",
        Companies = "BankofBaku, KapitalBank",
        FerqlenmeDiplomu = "-",
        Ixtisas = "Komputer muhendisliyi",
        BildiyiDiller = "Ingilis,Rus",
        OxuduguMekteb = "20 nomreli mekteb",
        UniQebulBali = 520,
        StartWorkTime = new DateTime(2020, 05, 7),
        StopWorkTime = new DateTime(2021, 06, 14),
        GitLink = "https://github.com/Murad122/Murad122",
        Linkedln = "https://www.linkedin.com/home"
    });



Worker worker2 = new(2, "Togrul", "Quliyev", "Baki", "050-536-76-27", 24,
    new CV()
    {
        Bacariqlar = "MySql, Html, Css, JavaScript",
        Companies = "freelancer",
        FerqlenmeDiplomu = "-",
        Ixtisas = "IT",
        BildiyiDiller = "Ingilis",
        OxuduguMekteb = "54 nomreli mekteb",
        UniQebulBali = 547,
        StartWorkTime = new DateTime(2020, 05, 7),
        GitLink = "https://github.com/Togrul44/Togrul44",
        Linkedln = "https://www.linkedin.com/home"
    });

List<Employer> employers = new() { employer1 };
List<Worker> workers = new() { worker1, worker2 };

void StartMenu()
{
    Console.WriteLine(
        "1. Worker\n" +
        "2. Employee"
        );
    Console.Write("Choose=> ");
    int ch = int.Parse(Console.ReadLine());
    Console.Clear();
    RegisterAndLogin(ref ch);
}

void RegisterAndLogin(ref int ch)
{

    try
    {
        if (ch != 1 && ch != 2)
        {
            throw new Exception("Wrong Choice");
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
        Console.WriteLine("Please try again");
        Thread.Sleep(1500);
        Console.Clear();
        StartMenu();
    }
Label:
    if (ch == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("\t\t--Worker--\n");
        Console.ResetColor();
    }
    else if (ch == 2)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t--Employer--");
        Console.ResetColor();
    }
    Console.WriteLine("1. SignUp" +
        "\n2. SignIn" +
        "\n3. Exit");
    int a = int.Parse(Console.ReadLine());
    if (ch == 1)
    {

        if (a == 1)
        {
            WorkerSignUp(workers);
            goto Label;
        }
        else if (a == 2)
        {
            WorkerSignIn(workers);
        }
        else if (a == 3)
        {
            Console.Clear();
            StartMenu();
        }

        else
        {
            try
            {
                throw new Exception("Wrong Choice");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.WriteLine("Please try again");
                Thread.Sleep(1500);
                Console.Clear();
                goto Label;
            }
        }
    }
    else if (ch == 2)
    {

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t--Employer--");
        Console.ResetColor();
        if (a == 1)
        {
            EmployerSignUp(employers);
            goto Label;
        }
        else if (a == 2)
        {
            EmployerSignIn(employers);
        }
        else if (a == 3)
        {
            Console.Clear();
            StartMenu();
        }
        else
        {
            try
            {
                throw new Exception("Wrong Choice");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.WriteLine("Please try again");
                Thread.Sleep(1500);
                Console.Clear();
                goto Label;
            }
        }
    }
}

int index = 0;
void WorkerSignUp(List<Worker> workers)
{
    Console.WriteLine("\t\t--SignUp--");
    Console.Write("Username: ");
    workers[index].Username = Console.ReadLine();
    Console.Write("Password: ");
    workers[index].Password = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Has Successfully SignUp...");
    workers.Add(workers[index]);
    JsonWrite("Worker.json", workers[index]);
    Thread.Sleep(900);
    Console.ResetColor();
    Console.Clear();
    File.AppendAllText("sign.json", workers[index].Username + " " + workers[index].Password + "\n");
    index++;
}

void WorkerSignIn(List<Worker> workers)
{
label:
    Console.WriteLine("\t\t--SignIn--");
    Console.Write("Username: ");
    var name = Console.ReadLine();
    Console.Write("Password: ");
    var pass = Console.ReadLine();
    FileInfo fileInfo = new("sign.json");
    if (!File.Exists("sign.json"))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        throw new NullReferenceException("Ilk once SignUp olmalisiz");
        Console.ResetColor();
        WorkerSignUp(workers);
    }
    var str = File.ReadAllLines("sign.json");
    bool b = false;
    int index;
    for (int i = 0; i < str.Length; i++)
    {

        var w = str[i].Split(' ');
        if (pass == w[1] && name == w[0])
        {
            b = true;
            ShowVacancies();
            index = i;
            SearchMenu(index);
            break;
        }
    }
    try
    {
        if (b == false)
        {
            throw new ArgumentException("Invalid Username or Password !");
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
        Console.WriteLine("Please try again");
        Thread.Sleep(1500);
        Console.Clear();
        goto label;
    }

}

void ExceptionHandler(Action action)
{
    try
    {
        action.Invoke();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
        Console.WriteLine("Please try again");
        Thread.Sleep(1500);
        Console.Clear();
        ExceptionHandler(action.Invoke);
    }
}


void EmployerSignUp(List<Employer> employer)
{
    Console.WriteLine("\t\t--SignUp--");
    Console.Write("Username: ");
    employer1.Username = Console.ReadLine();
    Console.Write("Password: ");
    employer1.Password = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Has Successfully SignUp...");
    employers.Add(employer1);
    JsonWrite("Employer.json", employer1);
    Thread.Sleep(900);
    Console.ResetColor();
    Console.Clear();
    File.AppendAllText("signEmp.json", employer1.Username + " " + employer1.Password + "\n");
}

void EmployerSignIn(List<Employer> employers)
{
label:
    Console.WriteLine("\t\t--SignIn--");
    Console.Write("Username: ");
    var name = Console.ReadLine();
    Console.Write("Password: ");
    var pass = Console.ReadLine();

    if (!File.Exists("signEmp.json"))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        throw new NullReferenceException("Ilk once SignUp olmalisiz");
        Console.ResetColor();
        EmployerSignUp(employers);
    }
    var str = File.ReadAllLines("signEmp.json");
    bool b = false;
    for (int i = 0; i < str.Length; i++)
    {

        var w = str[i].Split(' ');
        if (pass == w[1] && name == w[0])
        {
            b = true;
            ShowVacancies();
            EmployerMenu(index);
            break;
        }
    }
    try
    {
        if (b == false)
        {
            throw new ArgumentException("Invalid Username or Password !");
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
        Console.WriteLine("Please try again");
        Thread.Sleep(1500);
        Console.Clear();
        goto label;
    }

}
int vcIndex = 0;
void SearchMenu(int index)
{
    Console.WriteLine(
        "\n1. Search" +
        "\n2. Choose vacancy" +
        "\n3. Exit");
    Console.Write("Choice-> ");
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
    {
        Console.Clear();
        int result = SearchForVacancies();
        if (result == 1)
        {
            SendCv(index);
        }
        else if (result == 0)
        {
            Thread.Sleep(1700);
            Console.Clear();
            ShowVacancies();
            SearchMenu(index);
        }
        else
        {
            SearchMenu(index);
        }
    }

    else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
    {
        Console.Write("\nVacancy: ");
        var ch = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        vcIndex = ch;
        Console.WriteLine(vacansies[ch - 1]);

        SendCv(index);
    }
    else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
    {
        Console.Clear();
        ExceptionHandler(StartMenu);

    }
    else
    {
        throw new Exception("\nWrong Choice!");
    }
}


void SendCv(int index)
{
    Console.Write("\n\t\t");
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("Back <= (LeftArrow)");
    Console.ResetColor();
    Console.Write("\t\t");
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("Choose CV => click ENTER");
    Console.ResetColor();
    Console.WriteLine();

    var key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.Enter)
    {
    label5:
        Console.WriteLine(workers[index]);
        Console.Write("\n\t\t");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Back <= (LeftArrow)");
        Console.ResetColor();
        Console.Write("\t\t");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Send CV => click ENTER");
        Console.ResetColor();
        Console.WriteLine();
        var key1 = Console.ReadKey();

        if (key1.Key == ConsoleKey.Enter)
        {
            var cv = JsonConvert.SerializeObject(workers[index], Formatting.Indented); File.WriteAllText("cvSenders.json", cv);
            Console.WriteLine("Loading...");
            for (int j = 0; j < 35; j++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(" ");
                Thread.Sleep(100);

            }
            Console.ResetColor();
            Console.WriteLine("\nCV downloaded successfully");

            Console.Beep();
            Thread.Sleep(1500);
            Console.Clear();
            goto label5;

        }
        else if (key1.Key == ConsoleKey.LeftArrow)
        {
            Console.Clear();
            ShowVacancies();
            SearchMenu(index);
        }
        else
        {
            throw new Exception("Wrong Choice!");
        }
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        Console.Clear();
        ShowVacancies();
        SearchMenu(index);
    }
    else
    {
        throw new Exception("Wrong Choice!");
    }
}

void JsonWrite(string path, object obj)
{
    var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
    File.WriteAllText(path, json);
}

string JsonRead(string path)
{
    var str = File.ReadAllText(path);
    var objFromJson = JsonConvert.DeserializeObject(str);
    return str;
}
int i = 5;
void EmployerMenu(int index)
{
label:
    ShowVacancies();
    Notification(index);
    //var s= JsonRead("vacancy.json");
    // Console.WriteLine(s);
    Console.WriteLine("\n1. Vacancy Share" +
                      "\n2. Choose vacancy" +
                      "\n3. Exit");
    var ch = Console.ReadKey();
    Console.WriteLine();
    if (ch.Key == ConsoleKey.D1 || ch.Key == ConsoleKey.NumPad1)
    {
        Console.Write("Vacancy name: ");
        var vc = Console.ReadLine();
        Console.Write("What skills do you want ? ");
        var skills = Console.ReadLine();

        Console.Write("\n\t");
        vacansies.Add($"\n{i}. Vakansiya - " + vc + $"\n-{skills}");
        JsonWrite("vacancy.json", vacansies[i - 1]);
        i++;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Vacancy added");
        Thread.Sleep(1400);
        Console.ResetColor();
        goto label;
    }

    else if (ch.Key == ConsoleKey.D2 || ch.Key == ConsoleKey.NumPad2)
    {
        Console.Write("\nVacancy: ");
        var vs = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine(vacansies[vs - 1]);
        Console.Write("\n\t\t");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Back <= (LeftArrow)");
        Console.ResetColor();
        Console.Write("\t\t");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("View Worker's CV => click ENTER");
        Console.ResetColor();
        Console.WriteLine();
        var key1 = Console.ReadKey();

        if (key1.Key == ConsoleKey.Enter)
        {
            if (vs == vcIndex)
            {
                Console.WriteLine(workers[index]);
                Console.Write("\n\t\t");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Back <= (LeftArrow)");
                Console.ResetColor();
                Console.Write("\t\t");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Accept Worker's CV => click ENTER\n");
                Console.ResetColor();
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("This CV is accepted");
                    Thread.Sleep(1200);
                    vacansies.RemoveAt(vs - 1);
                    Console.Clear();
                    goto label;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    goto label;

                }
            }
            else
            {
                Console.WriteLine("CV gonderilmeyib");
                Thread.Sleep(1400);
                Console.Clear();
                goto label;
            }
        }
        else if (key1.Key == ConsoleKey.LeftArrow)
        {
            Console.Clear();
            goto label;

        }
    }
    else if (ch.Key == ConsoleKey.D3 || ch.Key == ConsoleKey.NumPad3)
    {
        Console.Clear();
        ExceptionHandler(StartMenu);

    }
}

void Notification(int index)
{
    Console.Write("\n\t\t\t\t\tNotifications: ");
    if (File.Exists("cvSenders.json"))
    {
        Worker wkCv = new();
        var cv = File.ReadAllText("cvSenders.json");
        var s = JsonConvert.DeserializeObject(cv);
        if (cv.Length > 0 && vcIndex > 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Beep();
            Console.WriteLine($"Sizin {vcIndex} nomreli is elaniniza CV gonderildi {workers[index].Name + " " + workers[index].Surname} terefinden");
            Console.ResetColor();
        }
    }

}
ExceptionHandler(StartMenu);