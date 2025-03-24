// // a for loop by default is a count-controlled loop
// //this means the loop will execute a certain number of times then exit
// //this is different from a while loop as the condition is iterating (going through the loop) by a value vs a condition

// //a for loop in c# looks a bit different than a for loop in python
// //this more of a "traditional" way for loops work
// //for loop syntax is as follows
// //for(i = starting value; ending condition; decrement/increment)

// using System.Runtime.InteropServices;

// for (int i = 0; i < 11; i++){  //i++ is the same as i = i + 1
//     Console.WriteLine(i);
// }

// //mainly what for loops are used for is to loop through arrays.  arrays a data structures that contain multiple items
// //arrays in c# are different from lists in python
// //arrays have a set size and data type (ie strings, ints, floats)

// string[] items = {"sword","shield","staff"};
// for(int i = 0; i < items.Length; i++){
//     Console.WriteLine(items[i]);
// }

// //break - breaks a loop if an inner condition is met but the outer condition isn't
// for(int i = 0; i < 11; i++){
//     if(i == 4){
//         break;
//     }
//     else{
//         Console.WriteLine(i);
//     }
// }

// //continue is like a break but can give out a message or perform code and then continues on in the loop
// for(int i = 0; i < 11; i++){
//     if(i == 4){
//         Console.WriteLine("4 was found!");
//         continue;
//     }
//     else{
//         Console.WriteLine(i);
//     }
// }
