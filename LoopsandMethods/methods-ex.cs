
// //invoking or calling or using the method
// doit();
// doit();

// string noise = "bark bark";

// //using an argument with a method
// speak(noise);

// double x = 548;
// double y = 5844;

// add_numbers(x,y);

// double a = 4545;
// double b = 5454;
// double result = add_numbers_return(a,b);
// Console.WriteLine(result);


// //methods use reusable code that can be called in the main method (by default in the new C# the main method is implied in the program.cs file)
// //you call it by its name()
// //define or declare a method - the format looks like the one below
// //static voidorreturntype nameofmethod(){}
// //void - just performs the statements or actions inside of a method you create.  Does not return a value
// static void doit(){
//     Console.WriteLine("Do IT. JUST DO IT");
// }

// //methods can also have information or data passed to it...the data being passed to the method definition is called parameters
// //you have to declare the data type (int,string,float,double) when creating params.
// static void speak(string speaking_noise){
//     Console.WriteLine(speaking_noise);
// }

// //you can also use more than one parameter.  Use commas to separate them.  Let's create a method to add two numbers together

// static void add_numbers(double number1, double number2){
//     double sum = number1 + number2;
//     Console.WriteLine(sum);
// }

// //a return method returns data into a variable or other object that is assigned to it.  It's purpose is to pass data to some other object or variable.
// //when using a return method we do not use the void keyword.  We instead have to tell the method what type of data we are returning (int,string,double, etc...)

// static double add_numbers_return(double number1, double number2){
//     //you should only return one thing at a time in a method...ie the method only returns one value or object
//     return number1 + number2;
// }
