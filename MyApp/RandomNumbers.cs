/*
Name:         Roger Silva Santos Aguiar
Function:     This class has a method that generates random numbers
Initial date: June 14, 2020
Last update:  June 14, 2020
*/

using System;

public class RandomNumbers
{
    //Variables
    private int quantity;
    private int min;
    private int max;

    //Constructor
    public RandomNumbers(int newQuantity, int newMin, int newMax)
    {
        //It gets the values
        quantity = newQuantity;
        min = newMin;
        max = newMax;

        //It creates an array
        int[] randomNumbers = returnNumbers();
    }//End constructor

    //This function generates the random numbers and return the array
    public int[] returnNumbers()
    {
        //Variables
        Random next = new Random();
        int[] newArray = new int[quantity];

        //Process
        for(int i = 0; i < quantity; i++)
        {
            newArray[i] = next.Next(min, max);
        }//End for

        //It displays the array
        displayArray(newArray);

        //It returns the array
        return newArray;
    }//End function

    //Method to display the array
    private void displayArray(int[] myArray)
    {
        for(int i = 0; i < quantity; i++)
        {
            Console.Write(myArray[i] + " - ");
        }//End for
    }
}//End class