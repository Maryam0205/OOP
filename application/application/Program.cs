using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.BL;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "maryam"; // shopkeeper login
            string userpassword = "78910";

            List<product> productdata = new List<product>();

            List<string> cuscomments = new List<string>();

            List<float> ratings = new List<float>();

            List<customorder> customdata = new List<customorder>();

            List<membership> memberdata = new List<membership>();

            List<int> productrecommendation = new List<int>();

            bool system = true;
            while (system == true)
            {
                int option;
                option = menu();
                if (option == 1)
                {
                    Console.Clear();
                    int logincheck = 0;
                    bool shopkeeper = true;
                    while (shopkeeper == true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        int check = 3;
                        check = shopkeeperlogin(username, userpassword);
                        if (check == 1)
                        {
                            logincheck = 0;
                            while (true)
                            {
                                int s = Shopkeeperoption(productdata, productrecommendation, memberdata, customdata, cuscomments, ratings, username, userpassword);
                                if ( s == 0 )
                                {
                                    break;
                                }
                                if ( s == 1 )
                                {
                                    shopkeeper = false;
                                    break;
                                }
                            }
                        }
                        if (check == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\tW R O N G    I N P U T");
                            logincheck++;
                            if (logincheck == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("   You've inputed wrong password for three times. The program is stopped");
                                system = false;
                            }
                        }
                    }
                }
                else if (option == 2)
                {

                }
                else if (option == 3)
                {
                    system = false;
                }
            }
            Console.ReadLine();
        }
        public static void header()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("  _                      _                                   _                           ");
            Console.WriteLine(" (_)                    | |                                 | |                          ");
            Console.WriteLine("  _ _ ____   _____ _ __ | |_ ___  _ __ _   _   ___ _   _ ___| |_ ___ _ __ ___  ");
            Console.WriteLine(" | | '_ \\ \\ / / _ \\ '_ \\| __/ _ \\| '__| | | | / __| | | / __| __/ _ \\ '_ ` _ \\ ");
            Console.WriteLine(" | | | | \\ V /  __/ | | | || (_) | |  | |_| | \\__ \\ |_| \\__ \\ ||  __/ | | | | |");
            Console.WriteLine(" |_|_| |_|\\_/ \\___|_| |_|\\__\\___/|_|   \\__, | |___/\\__, |___/\\__\\___|_| |_| |_|");
            Console.WriteLine("                                        __/ |       __/ |                      ");
            Console.WriteLine("                                       |___/       |___/                       ");
        }
        public static int menu()
        {
            int n;
            Console.Clear();
            header();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("***************************************************");
            Console.WriteLine("\t\tM A I N    M E N U");
            Console.WriteLine("***************************************************");
            Console.WriteLine();
            Console.WriteLine("\tEnter 1 for shopkeeper");
            Console.WriteLine("\tEnter 2 for customer ");
            Console.WriteLine("\tEnter 3 for exit ");
            Console.Write("\tEnter Your Choice....");
            n = int.Parse(Console.ReadLine());
            return n;
        }
        public static int shopkeeperlogin(string username, string userpassword)
        {
            header();
            string name, password;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("***************************************************");
            Console.WriteLine("\t\tL O G I N    M E N U ");
            Console.WriteLine("***************************************************");
            Console.WriteLine();
            Console.Write("\tEnter username: ");
            name = Console.ReadLine();
            Console.Write("\tEnter Password: ");
            password = Console.ReadLine();
            if (name == username && password == userpassword)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static string Shopkeepermenu()
        {
            Console.Clear();
            header();
            string n;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***************************************************");
            Console.WriteLine("\t\tSHOPKEEPER MENU");
            Console.WriteLine("***************************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\tEnter 1 to view the list of item ");
            Console.WriteLine("\tEnter 2 to Add a product ");
            Console.WriteLine("\tEnter 3 to Delete a product ");
            Console.WriteLine("\tEnter 4 to Update a product ");
            Console.WriteLine("\tEnter 5 to Search for a product ");
            Console.WriteLine("\tEnter 6 to Take an order ");
            Console.WriteLine("\tEnter 7 to View costum order ");
            Console.WriteLine("\tEnter 8 to View recommendation for restocking ");
            Console.WriteLine("\tEnter 9 to View customer comments ");
            Console.WriteLine("\tEnter 10 to View ratings ");
            Console.WriteLine("\tEnter 11 to give membership ");
            Console.WriteLine("\tEnter 12 to delete membership ");
            Console.WriteLine("\tEnter 13 to view membership ");
            Console.WriteLine("\tEnter 14 to Change username or password ");
            Console.WriteLine("\tEnter 15 to log out ");
            Console.WriteLine("\tEnter 16 to exit ");
            Console.Write("\tEnter your choice..... ");
            n = Console.ReadLine();
            return n;
        }
        static int Shopkeeperoption(List<product> productdata, List<int> productrecommendation, List<membership> memberdata, List<customorder> customdata, List<string> cuscomments, List<float> ratings, string username, string userpassword)
        {
            string n;
            n = Shopkeepermenu();
            Console.Clear();
            header();
            if (n == "1")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tLIST OF PRODUCTS");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                listofproductSK(productdata);
            }
            if (n == "2")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tADD A PRODUCT");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                addproduct(productdata, productrecommendation);
            }
            if (n == "3")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tDELETE A PRODUCT");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                deleteproduct(productdata);
            }
            if (n == "4")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tUPDATE A PRODUCT");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                updateproduct(productdata);
            }
            else if (n == "5")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tSEARCH A PRODUCT");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                searchsk(productdata);
            }
            else if (n == "6")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tTAKE AN ORDER");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                takingorder(productdata, memberdata, productrecommendation);
            }
            else if (n == "7")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tVIEW COSTUM ORDERS");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                viewcostumorder(customdata);
            }
            else if (n == "8")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tRESTOCKING RECOMMENDATION");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                restockingrecommendation(productdata);
            }
            else if (n == "9")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tCUSTOMER'S COMMENTS");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                customercomments(cuscomments);
            }
            else if ( n == "10" )
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tRATNGS");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                viewratings(ratings);
            }
            else if ( n == "11" )
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tGIVE MEMBERSHIP");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                givemembership(memberdata);
            }
            else if (n == "12")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tDELETE MEMBERSHIP");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                deletemembership(memberdata);
            }
            else if ( n == "13" )
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tVIEW MEMBERSHIP");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                viewmember(memberdata);
            }
            else if (n == "14")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine("\t\tUPDATE ACCOUNT");
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                changeUsernameOrPassword(username, userpassword);
            }
            else if(n == "15")
            {
                return 0;
            }
            else if ( n == "15")
            {
                return 1;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\tEnter any key to continue....");
            Console.ReadKey();
            return 2;
        }
        static void listofproductSK(List<product> productdata)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < productdata.Count(); i++)
            {
                product p = new product();
                p = productdata[i];
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\tPRODUCT: \t{0}", p.name);
                Console.WriteLine("\tPRICE:   \t{0}", p.price);
                Console.WriteLine("\tQuantity:\t{0}", p.quantity);
                Console.WriteLine();
            }
        }
        static void addproduct(List<product> productdata, List<int> productrecommendation)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int n;
            n = noofproductadded(productdata, productrecommendation);
            if (n != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();
                Console.WriteLine("\t {0} Products are added successfully ", n);
            }
        }
        static int noofproductadded(List<product> productdata, List<int> productrecommendation)
        {
            int n, temporarysize, noOfAddPro = 0;
            Console.Write("\tHow many products you want to add..... ");
            n = int.Parse(Console.ReadLine());
            temporarysize = productdata.Count() + n;
            for (int i = productdata.Count(); i < temporarysize; i++)
            {
                product p = new product();
            here:
                int check = 0;
                Console.Write("\tEnter the name of the products ");
                p.name = Console.ReadLine();
                for (int j = 0; j < i; j++)
                {
                    product p1 = new product();
                    p1 = productdata[j];
                    if (p.name == p1.name)
                    {
                        check = 1;
                    }
                }
                if (check != 0)
                {
                    Console.WriteLine("\tPrduct already existed ");
                    goto here;
                }
                else
                {
                    Console.Write("\tEnter it's price ");
                    p.price = float.Parse(Console.ReadLine());
                    Console.Write("\tEnter it's quantity ");
                    p.quantity = int.Parse(Console.ReadLine());
                    noOfAddPro++;
                    productrecommendation[i] = 0;
                    productdata.Add(p);
                }
            }
            return noOfAddPro;
        }
        static void deleteproduct(List<product> productdata)
        {
            int check = 0;
            string name;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tEnter the name of the product you want to delete ");
            name = Console.ReadLine();
            for (int i = 0; i < productdata.Count(); i++)
            {
                product p1 = new product();
                p1 = productdata[i];
                if (p1.name == name)
                {
                    productdata.RemoveAt(i);
                    check++;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (check == 0)
            {
                Console.WriteLine("\tProduct not found ");
            }
            else
                Console.WriteLine("\tProduct deleted successfully ");
        }
        static void updateproduct(List<product> productdata)
        {
        begin:
            string choice;
            Console.WriteLine("\tEnter 1 to update name ");
            Console.WriteLine("\tEnter 2 to update price ");
            Console.WriteLine("\tEnter 3 to update quantity ");
            Console.Write("\tEnter your choice ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                updateName(productdata);
            }
            else if (choice == "2")
            {
                updatePrice(productdata);
            }
            else if (choice == "2")
            {
                updateQuantity(productdata);
            }
            else
            {
                Console.WriteLine("\tWrong input\nTry again ");
                goto begin;
            }
        }
        static void updateName(List<product> productdata)
        {
            Console.Clear();
            header();
            int check = 0;
            string name;
            Console.WriteLine("\tEnter the name of the product you want to edit ");
            name = Console.ReadLine();
            for (int i = 0; i < productdata.Count(); i++)
            {
                product p = new product();
                p = productdata[i];
                if (p.name == name)
                {
                here:
                    Console.WriteLine("\tEnter updated name ");
                    name = Console.ReadLine();
                    for (int x = 0; x < productdata.Count(); x++)
                    {
                        product p1 = new product();
                        p1 = productdata[x];
                        if (p1.name == name)
                        {
                            string n;
                            Console.WriteLine("\tName already existed ");
                            Console.WriteLine("\tEnter 1 to try again ");
                            n = Console.ReadLine();
                            if (n == "1")
                            {
                                goto here;
                            }
                        }
                    }
                    p.name = name;
                    check++;
                }
            }
            if (check != 0)
            {
                Console.WriteLine("\tProduct name updated succesfully ");
            }
            else
            {
                Console.WriteLine("\tProduct not found ");
            }
        }
        static void updatePrice(List<product> productdata)
        {
            Console.Clear();
            header();
            int check = 0;
            string name;
            float updatedprice = 0F;
            Console.WriteLine("\tEnter the name of the product you want to edit ");
            name = Console.ReadLine();
            for (int i = 0; i < productdata.Count(); i++)
            {
                product p = new product();
                p = productdata[i];
                if (p.name == name)
                {
                    Console.WriteLine("\tEnter updated price ");
                    updatedprice = float.Parse(Console.ReadLine());
                    p.price = updatedprice;
                    check++;
                }
            }
            if (check != 0)
            {
                Console.WriteLine("\tProduct price updated succesfully ");
            }
            else
            {
                Console.WriteLine("\tProduct not found ");
            }
        }
        static void updateQuantity(List<product> productdata)
        {
            Console.Clear();
            header();
            int check = 0;
            string name;
            int updatedquantity = 0;
            Console.WriteLine("\tEnter the name of the product you want to edit ");
            name = Console.ReadLine();
            for (int i = 0; i < productdata.Count(); i++)
            {
                product p1 = new product();
                p1 = productdata[i];
                if (p1.name == name)
                {
                    Console.WriteLine("\tEnter updated price ");
                    updatedquantity = int.Parse(Console.ReadLine());
                    p1.quantity = updatedquantity;
                    check++;
                }
            }
            if (check != 0)
            {
                Console.WriteLine("\tProduct quantity updated succesfully ");
            }
            else
            {
                Console.WriteLine("\tProduct not found ");
            }
        }
        static void searchsk(List<product> productdata)
        {
            int count = 0;
            string name;
            Console.Write("\tEnter the name of the product you want to search ");
            name = Console.ReadLine();
            for (int i = 0; i < productdata.Count(); i++)
            {
                product p1 = new product();
                p1 = productdata[i];
                if (p1.name == name)
                {
                    Console.WriteLine("\tProduct name = {0}", p1.name);
                    Console.WriteLine("\tPrice = {0}", p1.price);
                    Console.WriteLine("\tQuantity = {0}", p1.quantity);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.Write("\tProduct not found ");
            }
        }
        static void takingorder(List<product> productdata, List<membership> memberdata, List<int> productrecommendation)
        {
            int n, quan, check = 0;
            float total = 0;
            string name, code;
            string membershipavailibility;
            Console.Write("\tEnter the number of products ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\tEnter the name of the product ");
                name = Console.ReadLine();
                Console.Write("\tEnter the quantity ");
                quan = int.Parse(Console.ReadLine());
                total = total + takeorder(name, quan, productdata, productrecommendation);
            }
            if (total != 0)
            {
                Console.Write("\tEnter y/Y if membership is available and n/N if not ");
                membershipavailibility = Console.ReadLine();
                if (membershipavailibility == "y" || membershipavailibility == "Y")
                {
                    Console.Write("\tEnter code ");
                    code = Console.ReadLine();
                    for (int i = 0; i < memberdata.Count(); i++)
                    {
                        membership m = new membership();
                        if (m.code == code)
                        {
                            total = total - (total * 0.1F);
                            check++;
                        }
                    }
                    if (check == 0)
                    {
                        Console.Write("\tmembership not found ");
                    }
                }
                Console.Write("\n\tTotal price is " + total);
            }
        }
        static float takeorder(string name, int quan, List<product> productdata, List<int> productrecommendation)
        {
            float total = 0;
            int check = 0;
            for (int i = 0; i < productdata.Count(); i++)
            {
                product p1 = new product();
                p1 = productdata[i];
                if (p1.name == name)
                {
                    if (p1.quantity >= quan)
                    {
                        total = p1.price * quan;
                        p1.quantity -= quan;
                    }
                    else
                    {
                        Console.Write("\tNot enough available ");
                        return 0;
                    }
                    productrecommendation[i]++;
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("\tProduct not found ");
                return 0;
            }
            return total;
        }
        static void viewcostumorder(List<customorder> customdata)
        {
            for (int i = 0; i < customdata.Count(); i++)
            {
                customorder c = new customorder();
                c = customdata[i];
                Console.WriteLine("Product:\t{0} ", c.name);
                Console.WriteLine("Quantity:\t{0} ", c.quantity);
                Console.WriteLine("");
            }
        }
        static void restockingrecommendation(List<product> productdata)
        {
            int check = 0; // Check how many products are restocked
            for (int i = 0; i < productdata.Count(); i++)
            {
                product p = new product();
                p = productdata[i];
                if (p.quantity <= 10) // products whose quantity is less than or equal to 10 are recomeended to restock
                {
                    Console.WriteLine("PRODUCT: \t{0}", p.name);
                    Console.WriteLine("PRICE:   \t{0}", p.price);
                    Console.WriteLine("QUANTITY:\t{0}", p.quantity);
                    Console.WriteLine("");
                    check++;
                }
            }
            if (check == 0) // if no products's quantity is less than or equal to 10
            {
                Console.WriteLine("No recommendatons ");
            }
        }
        static void customercomments(List<string> comments)
        {
            for(int i = 0; i < comments.Count(); i++)
            {
                Console.WriteLine(" {0}. {1}", i + 1, comments[i]);
            }           
        }
        static void viewratings(List<float> ratings)
        {
            float total = 0F;
            for (int i = 0; i < ratings.Count(); i++)
            {
                total += ratings[i];
            }
            Console.WriteLine("\t Your Current Rating is  {0} ", total);
        }
        static void changeUsernameOrPassword(string username, string userpassword)
        {
            string name, password;
            int pin;
            const int userpin = 111004; // constants value can't be changed
            Console.Write("\tEnter current username ");
            name = Console.ReadLine();
            Console.Write("\tEnter current password ");
            password = Console.ReadLine();
            if (name == username && password == userpassword)
            {
                Console.WriteLine("\tEnter pin code "); // to increase the safety
                pin = int.Parse(Console.ReadLine());
                if (pin == userpin)
                {
                    Console.Write("\tEnter new username ");
                    name = Console.ReadLine();
                    Console.Write("Enter new password ");
                    userpassword = Console.ReadLine();
                    Console.WriteLine("\nUsername and password updated successfully " );
                }
                else
                {
                    Console.WriteLine("\twrong pin" );
                }
            }
            else
            {
                Console.WriteLine("\tworng username or password ");
            }
        }
        static void givemembership(List<membership> memberdata)
        {
            int check = 0;
            membership m = new membership();
            Console.Write("\tEnter name: ");
            m.name = Console.ReadLine();
            Console.Write("\tEnter Code: ");
            m.code = Console.ReadLine();
            for (int i = 0; i < memberdata.Count(); i++)
            {
                membership m1 = new membership();
                m1 = memberdata[i];
                if (m1.code == m.code)
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                memberdata.Add(m);
                Console.WriteLine("\tMember added succesfully ");
            }
            else
                Console.WriteLine("\t Code already existed ");
        }
        static void deletemembership(List<membership> memberdata)
        {
            membership m = new membership();
            int check = 0;
            Console.Write("\tEnter Name: ");
            m.name = Console.ReadLine();
            Console.Write("\tEnter code: ");
            m.code = Console.ReadLine();
            for (int i = 0; i < memberdata.Count(); i++)
            {
                membership m1 = new membership();
                m1 = memberdata[i];
                if (m1.name == m.name && m1.code == m.code)
                {
                    memberdata.RemoveAt(i);
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("\tMember not found ");
            }
            else
                Console.WriteLine("\tMembership deleted successfully ");
        }
        static void viewmember(List<membership> memberdata)
        {
            for(int i = 0; i < memberdata.Count(); i++)
            {
                membership m = new membership();
                m = memberdata[i];
                Console.WriteLine("\tName; {0} ", m.name);
                Console.WriteLine("\tCode: {0} ", m.code);
                Console.WriteLine("");
            }
        }
    }
}
