using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Ejercicio 1 1****************");
            print100PairNumbers();//Print 100 first numbers
            print50Numbers();//print fizz buzz fizzbuz and another case print number
            print10NumbersWhileBucle();//Print 1 to 10 numbers with while
            print100PairNumbers();// plus from 1 to 100
            plus100FirstNumbers();//Print 100 numbers
            print100PairNumbers();//Print 100 first numbers

            Console.WriteLine("\n*********** Ejercicio 2 1****************");
            positiveOrNegativeNumber();//positve or negative entered number
            studentAprobedRebrobed();//Aprobed or reprobed number function
            rangeNumber();//Determine if ragen is 20
            dayOfWeek();//Show a week day string
            calculateOperation();


            Console.WriteLine("\n*********** Ejercicio 3 1****************");
            Persona juan = new Persona();//declar una variable de tipo Persona
            juan.setName("Juan");//set name
            juan.setAge(27);//set age
            juan.setDNI("1758987544");//set dni
            //Print object atributes
            Console.WriteLine($"Name : {juan.getName()}");//print what the method return
            Console.WriteLine($"Age : {juan.getAge()}");
            Console.WriteLine($"DNI : {juan.gedDNI()}");

            Point p1 = new Point();//create object Point
            p1.setX(123);//set x
            p1.setY(456);//set y
            Console.WriteLine("X: =" + p1.getX());// print get x value or atribute
            Console.WriteLine("y: =" + p1.getY());// print get y value or atribute

            Circle c1 = new Circle();//Create circle object
            c1.setX(5);
            c1.setY(10);
            c1.setR(5);
            c1.calculateArea();

            Person2 persona = new Person2();//create Persona dos object
            persona.setNombre("Luis");
            persona.setApellido("Ubillus");
            persona.setEdad(36);
            persona.setGenero("Masculino");

            Console.WriteLine(persona.imprimirInformacion());

        }
        //Ejercicio 1
        static void print100PairNumbers()//print pair numbers
        {
            Console.WriteLine("\n1 y 2 Imprimir los números pares que hay dentro de los 100 primeros números enteros. ");
            int increment = 0;// this variable will increment 
            while((increment += 2) <= 100)// increment inside of while and evaluate condition
            {
                Console.WriteLine(increment);//print increment
            }
        }

        static void print50Numbers()//fizzbazzfunction
        {
            Console.WriteLine("\n2. Imprimir los números del 1 al 50:");
            for (int i = 0; i <= 50; i++)// go onthough numbers from 0 to 50 and increment
            {
                if (i % 3 == 0 && i % 5 == 0)//the remainder must be zero at 3 and 5

                {
                    Console.WriteLine("FizzBuzz");//print
                }
                else if (i % 3 == 0)//the remainder must be 0 in 3
                {
                    Console.WriteLine("Fizz");//print
                }
                else if (i % 5 == 0)//the remainder must be 0 in 5
                {
                    Console.WriteLine("Buzz");//print
                }
                else//print number
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        static void print10NumbersWhileBucle()// print 10 numbers
        {
            Console.WriteLine("\n3. Imprime los números del 1 al 10 utilizando un bucle \" while \".");
            int count = 0;//counter
            //increment and evaluate condition
            while (count++ <10) Console.WriteLine(count);//Print number
            
        }
    
        static void plus100FirstNumbers()// pluss 100 numbers
        {
            Console.WriteLine("\n4 Calcula la suma de los primeros 100 números enteros utilizando un bucle \" while \".");
            int count = 0;// count 1,2,3...100
            int add = 0;//save plus
            while ((count ++) < 100)//plus count and evaluate
            {
                add += count; ;//save plus
            }
            Console.WriteLine($"Total = {add}");//print result
        }


        //Ejercicio 2
        static void positiveOrNegativeNumber()//print if is positive negative or zero
        {
            Console.WriteLine("1. Escribe un programa que evalúe si un número ingresado por el usuario es positivo, negativo o cero.");
           Console.WriteLine("Enter a number: ");// print messagge
            int enterNumber = int.Parse(Console.ReadLine());// get number and parce to int
            if (enterNumber > 0)//evaluate is >0
            {
                Console.WriteLine($"The number {enterNumber} is POSITIVE");//print
            }else if (enterNumber  < 0)//evaluate is negative
            {
                Console.WriteLine($"The number {enterNumber} is NEGATIVE");//print
            }
            else// otherwise
            {
                Console.WriteLine($"The number {enterNumber} is 0");//print 
            }

        }
        static void studentAprobedRebrobed()//print if student is aprobed or filed
        {
            Console.WriteLine("2. Crea un programa que solicita al usuario ingresar una calificación y luego muestre un mensaje según la calificación ingresada (por ejemplo: \"Aprobado\" si la calificación es mayor o igual a 60, \"Reprobado\" si es menor a 60).");
            Console.WriteLine("Enter a calification :");//Print message get number
            int calf = int.Parse(Console.ReadLine());//get and parse int
            if (calf >= 60) //condition if is aprobed
                {
                Console.WriteLine("Aprobado");//print
            }
            else//student will reprobed
            {
                Console.WriteLine("Reprobado");//print

            }
        }
        static void rangeNumber()
        {
            Console.WriteLine("\n 3. Desarrolla un programa que pida al usuario ingrese un número y luego determine en qué rango se encuentra (por ejemplo: \"Menor que 10\", \"Entre 10 y 20\", \"Mayor que 20\")");
            Console.WriteLine("Enter a number: ");//messagge to user
            int userNumber = int.Parse(Console.ReadLine());//read an parce enter user number
            if(userNumber < 10)
            {
                Console.WriteLine("Number is less to 10");
            }
            else if(userNumber>20)
            {
                Console.WriteLine("Number is greater to 20");
            }
            else
            {
                Console.WriteLine("Number betewwn 10 and 20");
            }


        }
        static void dayOfWeek()// show the string day
        {
            Console.WriteLine("\n4. Escribe un programa que solicite al usuario ingresar un número del 1 al 7 y luego muestre el día de la semana correspondiente (por ejemplo: 1 para \"Lunes\", 2 para \"Martes\", etc.)");
            Console.WriteLine("Enter a number and show the week day");
            int dayNumber = int.Parse(Console.ReadLine());// get string day and parse to int
            switch (dayNumber)// print the string with coincidence
            {
                case 1://print moday
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Twesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Freday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("This nomber is not a week day!");
                    break;

            }
        }
        static void calculateOperation()//calculator
        {
            Console.WriteLine("\n5. Ingresar 2 números y luego un carácter indicando la operación a realizar (+, -, *, /) y reportar el resultado de la operación utilizando la sentencia switch.");
            Console.Write("Enter number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter operator (+. -, *, /)");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    int add = number1 + number2;
                    Console.WriteLine($"La suma es {add}");
                    break;
                case "+-":
                    int less = number1 - number2;
                    Console.WriteLine($"La resta es {less}");
                    break;
                case "*":
                    int multi = number1 + number2;
                    Console.WriteLine($"La multiplicaicon  es {multi}");
                    break;
                case "/":
                    float div = (float)number1 + (float)number2;
                    if (number2 == 0)
                    {
                        Console.WriteLine("la division entre cero no esta permitida");
                    }
                    else
                    {
                        Console.WriteLine($"La division es: {div}");
                    }

                    break;
                default:
                    Console.WriteLine("Operacion invalida");
                    break;
            }
        }

    }

    //Ejercicio 3
    class Persona
    {
        //Atributes
        private String name;
        private byte age;
        private string dni;
        public Persona()//constructor
        {
            Console.WriteLine("\n1. Crea una clase llamada \"Persona\" con atributos como nombre, edad y DNI. Luego, implemente métodos para la clase, como obtener y establecer valores para los atributos.");
        }
        public void setName(String name)//set name atribute
        {
            this.name = name;//set name
        }
        public void setAge(byte age)//set name atribute
        {
            this.age = age;//set age
        }
        public void setDNI(string dni)//set name atribute
        {
            this.dni = dni;//set dni
        }
        public string getName()//obtains atribute
        {
            return this.name;//return name
        }
        public byte getAge()//obtains atribute
        {
            return this.age;//return age
        }
        public string gedDNI()//obtains atribute
        {
            return this.dni;//return dni
        }
    }

     class Point
    {
        //Atributes
        private int x;
        private int y;

        public Point()//Constructor
        {
            Console.WriteLine("\n2. Crea una clase que represente un punto en el plano cartesiano. La clase debe tener los siguientes atributos: x, y. Los métodos deben permitir establecer y obtener los valores de los atributos.");
        }
        //get atributes
        public int getX() { return x; }
        public int getY() { return y; }

        //set atributes
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
    }

    class Circle
    {
        //Atributes
        private int x=0;//diametro
        private int y=0;
        private int r=0;
        public Circle()
        {
            Console.WriteLine("\n3. Crea una clase que represente un círculo. La clase debe tener los siguientes atributos: x, y, radio. Los métodos deben permitir establecer y obtener los valores de los atributos. También debe tener un método que calcule el área del círculo.");
        }
        //get methods
        public int getX() { return x; }
        public int getY() { return y; }
        public int getR() { return r; }

        //set methods
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setR(int r)
        {
            this.r = r;
        }


        public void calculateArea()
        {
            if (r>0)
            {
                Console.WriteLine($"El radio es : {Math.PI * Math.Pow(this.r, 2)}");

            }else if (x > 0)
            {
                Console.WriteLine($"El radio es : {Math.PI * Math.Pow(this.r, 2)/2}");

            }
            else
            {
                Console.WriteLine("El radio es 0");
            }
        }
    }


    class Person2
    {
        //atributos
        private string nombre;
        private string apellido;
        private byte edad;
        private string genero;

        public Person2()
        {
            Console.WriteLine("\n4. Crea una clase que represente una persona. La clase debe tener los siguientes atributos: nombre, apellido, edad, género. Los métodos deben permitir establecer y obtener los valores de los atributos. También debe tener un método que imprima la información de la persona.");
        }
        //gey meyhods
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public byte getEdad() { return edad; }
        public string getGenero() { return genero; }

        //set methods
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setEdad(byte edad)
        {
            this.edad = edad;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public string imprimirInformacion()
        {
            return $"Nombre:{this.nombre}\n" +
                $"Apellido : {this.apellido}\n" +
                $"Edad: {this.edad}\n" +
                $"Genero: {this.genero} \n";
        }

    }
}
