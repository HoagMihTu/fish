using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _MesScript : MonoBehaviour
{
    public TMP_Text Answer;

    // Update is called once per frame
    void Update()
    {
        if(_ClamBehavior.onend == 0){
            message();
        }
    }

    void message(){
        int point = _ClamBehavior.score;
        switch(point){
            case 0:
                Answer.text = "HỌC LẠI";
                break;
            case 1:
                Answer.text = "HỌC THÊM";
                break;
            case 2:
                Answer.text = "HỌC KHÁ";
                break;
            case 3:
                Answer.text = "HỌC TỐT";
                break;
        }
    }
}
