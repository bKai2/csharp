using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace tutorial {
    class Program {
        static void Main(string[] args) {

        }

        static void Random() {
            Random random = new Random();

            double num = random.NextDouble();
            int num2 = random.Next(0, 10);
            int num3 = random.Next(0, 10);
            int num4 = random.Next(0, 10);
            int num5 = random.Next(0, 10);
        }

        static void Hypotenuse() {
            Console.Write("Enter the first leg: ");
            int leg1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second leg: ");
            int leg2 = Convert.ToInt32(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2));
            Console.WriteLine("The length of the hypotenuse is " + hypotenuse + ".");
        }

        static void StringMethods() {
            String fullName = "Kai Yilmaz";
            String phoneNumber = "123-456-7890";
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);
            fullName = fullName.ToLower();
            Console.WriteLine(fullName);
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine(phoneNumber);
            String userName = fullName.Insert(0, "Xxx-");
            userName = userName.Insert(-1, "-xxX");
            Console.WriteLine(userName);
            Console.WriteLine(userName.Length);
            String firstName = fullName.Substring(0, 3);
            Console.WriteLine(firstName);
        }

        static void IfStatements() {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18) {
                Console.WriteLine("You are now signed up!");
            } else if (age < 0) {
                Console.WriteLine("You haven't been born yet.");
            } else {
                Console.WriteLine("Sorry, you're to young!");
            }
        }

        static void Switch() {
            Console.Write("Enter a day: ");
            String day = Console.ReadLine();
            switch (day) {
                case "Monday":
                    Console.WriteLine("Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine(day + "is not a day.");
                    break;
            }
        }

        static void LogicalOperators() {
            Console.Write("What is the temp outside (F)?: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (temp > 100) {
                Console.WriteLine("It's REALLY hot.");
            } else if (temp == 420 || temp == 69) {
                Console.WriteLine("Haha funny number");
            } else if (temp >= 82 && temp <= 100) {
                Console.WriteLine("hot");
            } else if (temp >= 60 && temp <= 82) {
                Console.WriteLine("Normal temp");
            } else {
                Console.WriteLine("Cold");
            }
        }

        static void WhileLoop() {
            String name = "";

            while (name == "") {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);


        }

        static void ForLoop() {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }

        }

        static void NestedLoops() {
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("What symbol?: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++) {
                Console.Write("\n");
                for (int j = 0; j < columns; j++) {
                    Console.Write(symbol);
                }
            }

        }

        static void Arrays() {

            // arrays have fixed size

            //declaring but not initializing
            String[] coolCars = new string[2];


            String[] cars = { "BMW", "Mustang", "Corvetted" };
            Console.WriteLine(cars[0] + cars[1] + cars[2]);
            cars[0] = "Tesla";
            Console.WriteLine(cars[0] + cars[1] + cars[2]);

            for (int i = 0; i < cars.Length; i++) {
                Console.WriteLine(cars[i]);
            }


            //foreach
            foreach (String car in cars) {
                Console.WriteLine(car);
            }

        }

        static void MethodsMain() {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            SingHappyBirthday(name);
            SingHappyBirthday(name);
            SingHappyBirthday(name);


        }

        static void SingHappyBirthday(String name) {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + name + "!");
        }

        static void ReturnMain() {
            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x * z = " + ReturnMultiply(x, y));
        }

        static void MethodOverloadingMain() {
            // name + parameter = signature
            // methods can have the same main if they have different aprameters

            Console.WriteLine(ReturnMultiply(3, 4, 5));
            Console.WriteLine(ReturnMultiply(3, 4));
        }

        static double ReturnMultiply(double x, double y) {
            double z = x * y;
            return z;
        }

        static double ReturnMultiply(double x, double y, double i) {
            double z = x * y * i;
            return z;
        }

        static void ParamsKeyword() {
            double[] prices = { 7.99, 8.6, 9 };

            Console.WriteLine(ShoppingFunction(prices));
        }

        static double ShoppingFunction(params double[] prices) {
            double total = 0;

            foreach (double price in prices) {
                total += price;
            }

            return total;
        }

        static void Exceptions() {

            //try attemps to run a line of code
            //catch catches exceptions and does something
            //finally does something after all the code is completed (whether there is an exception or not

            try {
                Console.WriteLine("Enter something to divide 100 by: ");
                double divisor = Convert.ToDouble(Console.ReadLine());
            } catch (FormatException e) {
                Console.WriteLine("ENTER A NUMBER");
            } catch (DivideByZeroException e) {
                Console.WriteLine("YOU CANT DIVIDE BY ZERO");
            } catch (Exception e) {
                Console.WriteLine("UH OH");
            } finally {
                Console.WriteLine("Thanks for visiting!");
            }
        }

        static void ConditionalOperator() {
            double temperature = 20;
            String message;

            //if else
            if (temperature > 15) {
                message = "Warm";
            } else {
                message = "Cold";
            }
            Console.WriteLine(message);

            //conditional operator
            // returns 1 of two values depending on what the condition evaluates to
            message = (temperature >= 15) ? "Warm" : "Cold";
            Console.WriteLine(message);
        }

        static void StringInterpolation() {
            //string interpolation = insert variables into a string literal
            // precede a string literal with $
            //{} placeholders

            String firstName = "Kai";
            String lastName = "Yil";
            int age = 15;

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old.");
            Console.WriteLine($"{firstName} {lastName} is {age} years old.");

        }

        static void MultidimensionalArrays() {
            String[] ford = { "E", "F", "G" };
            String[] chevy = { "Y", "Z", "H" };
            String[] zorbo = { "U", "X", "N" };

            String[,] parkingLot = { { ford[0], ford[1], ford[2] }, { chevy[0], chevy[1], chevy[2] }, { zorbo[0], zorbo[1], zorbo[2] } };

            foreach (String car in parkingLot) {
                Console.WriteLine(car);
            }

            for (int j = 0; j < parkingLot.GetLength(0); j++) {
                for (int i = 0; i < parkingLot.GetLength(1); i++) {
                    Console.WriteLine(parkingLot[j, i]);
                }
            }

        }

        static void Static() {
            // static modified belongs to a class, not an object, and like non constructed properties require public
            // classes can be static with no objects
            Cars Car1 = new Cars("Chevy");
            Cars Car2 = new Cars("Toyota");
            Cars Car3 = new Cars("Kia");

            Console.WriteLine(Cars.numCars);
        }
        static void ClassesMain() {
            //greetings!

            Greetings.Hello();
            Greetings.Waiting();
            Greetings.Bye();
        }
        static void ObjectsMain() {

            // you can assign properties manually
            Humans human1 = new Humans("jebediah", 99);
            human1.Sleep();
            human1.Eat();

            //or you can use a constructor
            // you can assign properties manually
            Humans human2 = new Humans("jean", 17);
            human2.Sleep();
            human2.Eat();
        }

        static void OverloadedConstructors() {
            //parameters + name = signature 
            // two constructors can have the same name but different signatures, like normal methods

            Pizza pizza1 = new Pizza("Bread", "Sauce", "Cheese", "Topping");
            Pizza pizza2 = new Pizza("Bread", "Sauce", "Cheese");
        }


        static void Inheritance() {
            //classes can inherit the fields and methods of other classes
            VehicleBicycle bike = new VehicleBicycle();
            VehicleCar car = new VehicleCar();
            Console.WriteLine(car.speed);
            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheels);
            Console.WriteLine(car.wheels);

            //the different properties being inherited are the same as in their parent object, and cannot be converted into a different variable type
        }

        static void AbstractClasses() {
            VehicleBicycle bike = new VehicleBicycle();
            VehicleCar car = new VehicleCar();

            //the vehicle class does not have all of the properties needed (it is not complete)
            //it is meant to be inherited, so it should be defined as abstract (cannot be instantiated)

        }

        static void ArrayOfObjects() {

            Cars[] garage = new Cars[3];

            Cars car1 = new Cars("Mustang", "W");
            Cars car2 = new Cars("Corvette", "W");
            Cars car3 = new Cars("Lambo", "W");

            //making a list of non-anonymous objects
            garage[1] = car1;
            garage[2] = car2;
            garage[3] = car3;

            foreach (Cars car in garage) {
                Console.WriteLine(car.model);
            }

            //making a list of anonymous objects
            Cars[] garageAnon = { new Cars("Mustang"), new Cars("Corvette"), new Cars("Lambo") };
        }

        public static void ObjAsArgument() {
            Cars car1 = new Cars("Mustang", "Silver");
            Console.WriteLine(car1.color + " " + car1.model);
            ChangeColor(car1, "purple");
        }

        public static void ChangeColor(Cars car, String color) {
            car.color = color;
        }

        public Cars CopyCar(Cars car) {
            Cars copyCar = new Cars(car.model, car.color);
            return copyCar;
        }

        public static void MethodOverriding() {
            //method overriding allows a class to change an inherited method
        }
        public static void ToString() {
            //this is naturally inherited, so you can override it
            //an inherent method of objects that converts an object to its string bersion for display
            Cars car1 = new Cars("Corvette", "Blue");

            //it would normally return the class and object name
            String carString = car1.ToString();

            //after bein overriden
            //you dont even need the method
            Console.WriteLine(carString);
            Console.WriteLine(car1);
        }


        public static void Polymorphism() {
            VehicleCar car = new VehicleCar();
            VehicleBicycle bicycle = new VehicleBicycle();

            //if you want to make an array of multiple different objects, you use polymorphism
            //essentially, you use an inherited type
            Vehicle[] vehicles = { car, bicycle };

            foreach (Vehicle vehicle in vehicles) {
                Console.WriteLine(vehicle.ToString());
            }

            //if its an object, it is inherited from the object base class
            Object[] objects = { "dog", bicycle };

        }

        public static void Interface() {
            // an interface declares what a class should have
            // the class that inherits from it defines how it should be done
            //interfaces are like a contract, that make it more secure
            //one class can inherit multiple
            Hawk hawk = new Hawk();
            Mouse mouse = new Mouse();
            hawk.Hunt();
            mouse.Flee();
        }

    }

    interface IPrey {
        void Flee();
    }

    interface IPredator {
        void Hunt();
    }

    class Hawk : IPredator {
        public void Hunt() {
            Console.WriteLine("The hawk is searching for food");

        }
    }

    class Mouse : IPrey {
        public void Flee() {
            Console.WriteLine("The mouse is running away");
        }

    }
    abstract class Vehicle {
        public int speed = 0;

        public virtual void go() {
            Console.WriteLine("Zoom!");
        }
    }

    class VehicleCar : Vehicle {
        public override void go() {
            Console.WriteLine("Car zoom!");
        }
        public int wheels = 4;
    }

    class VehicleBicycle : Vehicle {
        public override void go() {
            Console.WriteLine("Vehicle zoom!");
        }
        public int wheels = 2;
    }

    class Humans {
        //fields and methods are properties of objects if they aren't static
        // they are only accessible from other classes if public, even as properties of an obj
        //this is unless they are assigned in a constructor
        String name;
        int age;

        public void Eat() {
            Console.WriteLine(name + " is eating!");
        }
        public void Sleep() {
            Console.WriteLine(name + " is sleeping!");
        }

        //constructors are special methods with the class name, dont have void
        public Humans(String name, int age) {
            // this is the class, so if the function is called on instantiation, the values will be assigned to arguments
            this.name = name;
            this.age = age;
        }
    }

    class Greetings {
        //messages
        //static methods within a class are characteristics of that class
        public static void Hello() {
            Console.WriteLine("Hello");
        }

        public static void Waiting() {
            Console.WriteLine("Waiting...");
        }

        public static void Bye() {
            Console.WriteLine("Adios!");
        }
    }

    class Cars {
        public String model;
        public String color;
        public static int numCars = 0;

        public Cars(String model, String color) {
            //constructions dont only have assignment
            // if each object has its own version, then numCars will always be 1
            // if numCars is static, then you get the real nunber
            numCars++;
            this.color = color;
            this.model = model;
        }

        public override string ToString() {
            return "This is a {color} {model}.";
        }
    }

    class Pizza {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(string bread, string sauce, string cheese, string topping) {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(string bread, string sauce, string cheese) {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;

        }
    }

    abstract class Animal {
        //virtual function means that it can be overriden
        public virtual void Speak() {
            Console.WriteLine("Words");
        }

        class dog : Animal {
            //override function means that it is overriding another function
            public override void Speak() {
                Console.WriteLine("Woof");
            }
        }
        class cat : Animal {
            //after a function is overriden it doesnt need to happen again
            public void Speak() {
                Console.WriteLine("Woof");
            }
        }
    }
}