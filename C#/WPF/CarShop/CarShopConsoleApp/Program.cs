using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static Store CarStore = new Store();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the car store. First you must " +
                "create some cars and put them into the store inventory. Then " +
                "you may add cars to the cart. Finally, you may checkout, which " +
                "will calculate your total bill.");
            int action = ChooseAction();
            while (action != 0)
            {
                while (action > 3 || action < 0)
                {
                    Console.Out.WriteLine("The number entered is out of bounds.");
                    action = ChooseAction();
                }
                switch (action)
                {
                    case 1:
                        {
                            //You chose to add a car
                            Console.Out.WriteLine("You chose to add a new car to the store:");

                            //Ask for three property details
                            string carMake = "";
                            string carModel = "";
                            string carColor = "";
                            int carYear = 0;
                            decimal carPrice = 0;

                            Console.Out.WriteLine("What is the car make? Ford, GM, Toyota etc ");
                            carMake = Console.ReadLine();

                            Console.Out.WriteLine("What is the car model? Corvette, Focus, Ranger etc ");
                            carModel = Console.ReadLine();

                            Console.Out.WriteLine("What is the color? Red, Blue, Green etc ");
                            carColor = Console.ReadLine();

                            while (carYear == 0)
                            {
                                Console.Out.WriteLine("What is the year? Only whole numbers ");
                                try
                                {
                                    carYear = int.Parse(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.Out.WriteLine("Please enter a valid number.");
                                }
                            }

                            while (carPrice == 0)
                            {
                                Console.Out.WriteLine("What is the car price? Only numbers please ");
                                try
                                {
                                    carPrice = int.Parse(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.Out.WriteLine("Please enter a valid number");
                                }

                            }

                            //Create a new car object and add it to the list.
                            Car newCar = new Car();
                            newCar.Make = carMake;
                            newCar.Model = carModel;
                            newCar.Color = carColor;
                            newCar.Year = carYear;
                            newCar.Price = carPrice;
                            CarStore.CarList.Add(newCar);
                            PrintStoreInventory(CarStore);
                            break;
                        }
                    case 2:
                        {
                            //You chose to buy a car

                            //Display the list of cars in inventory
                            PrintStoreInventory(CarStore);

                            //Ask for a car number to purchase
                            int choice = -1;
                            while (choice < 0 || choice > CarStore.CarList.Count - 1)
                            {
                                Console.Out.Write("Which car would you like to add to the cart? (number) ");
                                choice = int.Parse(Console.ReadLine());
                                //Add the car to the shopping card
                                try
                                {
                                    CarStore.ShoppingList.Add(CarStore.CarList[choice]);
                                }
                                catch (Exception)
                                {
                                    Console.Out.WriteLine("Please enter a valid number.");
                                }
                             }
                           
                            PrintShoppingCart(CarStore);
                            break;
                        }
                    case 3:
                        {
                            //Checkout
                            PrintShoppingCart(CarStore);
                            Console.Out.WriteLine("Your total cost is ${0}", CarStore.Checkout());
                            break;
                        }
                    default:
                        break;
                }
                action = ChooseAction();
            }
        }

        public static int ChooseAction()
        {
            int choice = -1;
            while (choice == -1)
            {
                Console.Out.Write("Choose an action (0) quit (1) add a car (2) add item to cart (3) checkout ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Out.WriteLine("Please input a valid integer.");
                }
            }
            
            return choice;     
        }

        public static void PrintStoreInventory( Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory: ");
            int i = 0;
            foreach (var c in carStore.CarList)
            {
                Console.Out.WriteLine(string.Format("Car # = {0} {1} ", i, c.Display));
                i++;
            }
        }

        public static void PrintShoppingCart( Store carStore)
        {
            Console.Out.WriteLine("These are the cars in your shopping cart: ");
            int i = 0;
            foreach (var c in carStore.ShoppingList)
            {
                Console.Out.WriteLine(string.Format("Car # = {0} {1}", i, c.Display));
                i++;
            }
        }
    }
}
