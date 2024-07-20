/*
Creating a Color Palette

Suppose you're developing an application to create a custom color palette where users can input their preferred colors. The program allows users to enter colors in a forward sequence, then displays these colors in both forward and reverse order for a better understanding of the palette.

User Interaction:

The program prompts the user to input different colors.
The user enters each color one by one.
After entering the colors, the program displays the colors in the order they were inputted (forward traversal).
Following that, the program showcases the same colors but in reverse order (backward traversal).
Users can take note of how the colors look in both sequences, helping them visualize the color palette.
*/

using System;
using System.Collections.Generic;
class Task5{
    static void Main(){
        List<string> colors = new List<string>();
        Console.WriteLine("Enter colors for your palette (type 'done' to finish):");
        string input = Console.ReadLine();
        while (input != "done"){
            colors.Add(input);
            input = Console.ReadLine();
        }
        Console.WriteLine("Colors in forward order:");
        foreach (string color in colors){
            Console.WriteLine(color);
        }
        Console.WriteLine("Colors in reverse order:");
        for (int i = colors.Count - 1; i >= 0; i--){
            Console.WriteLine(colors[i]);
        }
    }
}