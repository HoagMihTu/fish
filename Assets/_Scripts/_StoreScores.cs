using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _StoreScores : MonoBehaviour
{
    public static int[] point;
    public static void SaveLevelPoint(string level, int score){
        PlayerPrefs.SetInt(level, score);
    }
    public static void FetchLevelPoint(){
        point = new int[6];
        for (int i=1; i<6; i++){
            point[i] = PlayerPrefs.GetInt("level"+i);
        }
        Debug.Log(point[1]);
        Debug.Log(point[2]);
        Debug.Log(point[3]);
    }
}
