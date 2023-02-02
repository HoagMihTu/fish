using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _StarBehavior : MonoBehaviour
{
    public GameObject starToSpawn1;
	public GameObject starToSpawn2;
    public static int checkend = 0;
	
    // Start is called before the first frame update
    void FixedUpdate()
    {

        string text;
        int check = _ClamBehavior.onend;
        if (check == 0){
            if (checkend == 1){
                Invoke("_PopUp",1);
            }
        }
    }

	void _StarSpawn(GameObject Star1Pos, GameObject Star2Pos, GameObject Star3Pos, GameObject starSpawn1, GameObject starSpawn2, GameObject starSpawn3)
	{
		GameObject ptst = Instantiate(starSpawn1);
		ptst.transform.position = Star1Pos.transform.position;
		GameObject ptsf1 = Instantiate(starSpawn2);
		ptsf1.transform.position = Star2Pos.transform.position;
		GameObject ptsf2 = Instantiate(starSpawn3);
		ptsf2.transform.position = Star3Pos.transform.position;
	}
    void _PopUp(){
        GameObject star1 = GameObject.FindWithTag("Star1");
		GameObject star2 = GameObject.FindWithTag("Star2");
		GameObject star3 = GameObject.FindWithTag("Star3");
        int score = _ClamBehavior.score;
        switch (score)
            {
                case 0:
                    _StarSpawn(star1, star2, star3, starToSpawn2, starToSpawn2, starToSpawn2);
                    break;
                case 1:
                    _StarSpawn(star1, star2, star3, starToSpawn1, starToSpawn2, starToSpawn2);
                    break;
                case 2:
                    _StarSpawn(star1, star2, star3, starToSpawn1, starToSpawn1, starToSpawn2);
                    break;
                case 3:
                    _StarSpawn(star1, star2, star3, starToSpawn1, starToSpawn1, starToSpawn1);
                    break;
                default:
                    break;
            }
    }
}
