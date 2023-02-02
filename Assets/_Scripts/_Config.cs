using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour
{ 
    public static int level = 1;
    public enum Level1
    {
        Min = 1,
        Max = 5
    };
    public enum Level2
    {
        Min = 3,
        Max = 7
    };

    public enum Level3
    {
        Min = 5,
        Max = 9
    };

    public enum Level4
    {
        Min = 7,
        Max = 11
    };

    public enum Level5
    {
        Min = 9,
        Max = 13
    };

    public enum Level6
    {
        Min = 11,
        Max = 15
    };

    public static int getNumber()
    {
        int number;
        switch(level){
            case 1:
                number =Random.Range((int) Config.Level1.Min,(int) Config.Level1.Max);
                return number;
            case 2:
                number =Random.Range((int) Config.Level2.Min,(int) Config.Level2.Max);
                return number;
            case 3:
                number =Random.Range((int) Config.Level3.Min,(int) Config.Level3.Max);
                return number;
            case 4:
                number =Random.Range((int) Config.Level4.Min,(int) Config.Level4.Max);
                return number;
            case 5:
                number =Random.Range((int) Config.Level5.Min,(int) Config.Level5.Max);
                return number;
            case 6:
                number =Random.Range((int) Config.Level6.Min,(int) Config.Level6.Max);
                return number;
            default: 
                return number = 0;
        }
    }
    

}

