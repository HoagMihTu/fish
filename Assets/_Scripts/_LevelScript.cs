using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _LevelScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject starToSpawn1;
	public GameObject starToSpawn2;
    public int[] point;
    void Start()
    {
        _StoreScores.FetchLevelPoint();
        point = new int[6];
        point = _StoreScores.point;
        GameObject lilstar1_1 = GameObject.FindWithTag("lilstar1_1");
		GameObject lilstar1_2 = GameObject.FindWithTag("lilstar1_2");
		GameObject lilstar1_3 = GameObject.FindWithTag("lilstar1_3");
        GameObject lilstar2_1 = GameObject.FindWithTag("lilstar2_1");
        GameObject lilstar2_2 = GameObject.FindWithTag("lilstar2_2");
        GameObject lilstar2_3 = GameObject.FindWithTag("lilstar2_3");
        GameObject lilstar3_1 = GameObject.FindWithTag("lilstar3_1");
        GameObject lilstar3_2 = GameObject.FindWithTag("lilstar3_2");
        GameObject lilstar3_3 = GameObject.FindWithTag("lilstar3_3");
        GameObject lilstar4_1 = GameObject.FindWithTag("lilstar4_1");
        GameObject lilstar4_2 = GameObject.FindWithTag("lilstar4_2");
        GameObject lilstar4_3 = GameObject.FindWithTag("lilstar4_3");
        GameObject lilstar5_1 = GameObject.FindWithTag("lilstar5_1");
        GameObject lilstar5_2 = GameObject.FindWithTag("lilstar5_2");
        GameObject lilstar5_3 = GameObject.FindWithTag("lilstar5_3");
        _PopUp(lilstar1_1, lilstar1_2, lilstar1_3, point[1]);
        _PopUp(lilstar2_1, lilstar2_2, lilstar2_3, point[2]);
        _PopUp(lilstar3_1, lilstar3_2, lilstar3_3, point[3]);
        _PopUp(lilstar4_1, lilstar4_2, lilstar4_3, point[4]);
        _PopUp(lilstar5_1, lilstar5_2, lilstar5_3, point[5]);

    }

    // Update is called once per frame
    public void LoadLevel(int level)
    {
        Config.level = level;
        _Check.number = Config.getNumber();
        _ClamBehavior.onend = 3;
        _ClamBehavior.endcheck = 0;
        _StarBehavior.checkend = 0;
        _ClamBehavior.score = 0;
        SceneManager.LoadScene("Game");
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
    void _PopUp(GameObject LilStar1Pos, GameObject LilStar2Pos, GameObject LilStar3Pos, int score){
        switch (score)
            {
                case 0:
                    _StarSpawn(LilStar1Pos, LilStar2Pos, LilStar3Pos, starToSpawn2, starToSpawn2, starToSpawn2);
                    break;
                case 1:
                    _StarSpawn(LilStar1Pos, LilStar2Pos, LilStar3Pos, starToSpawn1, starToSpawn2, starToSpawn2);
                    break;
                case 2:
                    _StarSpawn(LilStar1Pos, LilStar2Pos, LilStar3Pos, starToSpawn1, starToSpawn1, starToSpawn2);
                    break;
                case 3:
                    _StarSpawn(LilStar1Pos, LilStar2Pos, LilStar3Pos, starToSpawn1, starToSpawn1, starToSpawn1);
                    break;
                default:
                    break;
            }
    }
}
