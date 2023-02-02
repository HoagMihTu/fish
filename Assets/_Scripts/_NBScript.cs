using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _NBScript : MonoBehaviour
{
    public GameObject NB;

    void Update()
    {
        if (_ClamBehavior.begone>0){
            Begone();
        }
    }

    void Begone(){
        Destroy(NB);
    }
}
