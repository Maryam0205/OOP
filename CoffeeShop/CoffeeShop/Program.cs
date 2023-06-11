using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_06.BL;
using Week_06.DL;
using Week_06.UI;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        { 
            Coffeeshop shop = ShopCRUD.nameofshop();
            int option = -1;
            while (option != 9)
            {
                Console.Clear();
                option = ShopCRUD.menu(shop.name);
                Console.Clear();
                if (option == 1)
                {
                    MenuItem obj = ShopCRUD.inputforaddmenu();
                    Listmenucs.addmenuintomenulist(shop, obj);
                }
                if (option == 2)
                {
                    MenuItem obj = Listmenucs.productwithcheapestprice(shop);
                    ShopCRUD.viewcheapest(obj);
                }
                if (option == 3)
                {
                    ShopCRUD.viewdrinkmenu(shop);
                }
                if (option == 4)
                {
                    ShopCRUD.viewFoodmenu(shop);
                    Console.ReadKey();
                }
                if (option == 5)
                {
                    MenuItem obj = ShopCRUD.addoredered();
                    bool check = Listmenucs.verifyproductavailability(shop, obj);
                    if (check)
                    {
                        Listmenucs.addproductintoorderedlist(shop, obj);
                    }
                    else
                    {
                        ShopCRUD.elseforordernot();
                    }
                }
                if (option == 6)
                {
                    bool check = Listmenucs.orderfullyavailablility(shop);
                    if (check)
                    {
                        Listmenucs.fullfilledordered(shop);
                        Listmenucs.emptylist(shop);
                    }
                    else
                    {
                        ShopCRUD.elseforfulldfillodered();
                    }
                }
                if (option == 7)
                {
                    bool check = Listmenucs.orderfullyavailablility(shop);
                    if (check)
                    {
                        Listmenucs.viewallorderedlist(shop);
                    }
                    else
                    {
                        ShopCRUD.elseforoption7();
                    }

                }
                if (option == 8)
                {
                    float price = Listmenucs.calculatetotal(shop);
                    ShopCRUD.totalprice(price);

                }
                Console.ReadKey();
            }
        }
    }
}
