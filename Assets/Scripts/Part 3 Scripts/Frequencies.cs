using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Frequencies 
{
    public static float Frequency(string frequency) //Different frequencies attached to their own string number to be used in an array in the sound generator script
    {
        switch (frequency)
        {
            case "1": return 261.62f;
            case "2": return 277.18f;
            case "3": return 293.66f;
            case "4": return 311.13f;
            case "5": return 329.63f;
            case "6": return 349.23f;
            case "7": return 369.99f;
            case "8": return 392.00f;
            case "9": return 415.30f;
            case "10": return 440.00f;
           
            default: return 440.0f;  
        }
    }

    
}
