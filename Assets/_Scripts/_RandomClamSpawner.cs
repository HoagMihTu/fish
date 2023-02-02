using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _RandomClamSpawner : MonoBehaviour
{
	
	public bool alwaysSpawn = true;
	
	public GameObject prefabsToSpawn1;
	public GameObject prefabsToSpawn2;
	public GameObject prefabsToSpawn3;
	public GameObject NumToSpawn1;
	public GameObject NumToSpawn2;
	public GameObject NumToSpawn3;
	public GameObject NumToSpawn4;
	public GameObject NumToSpawn5;
	public GameObject NumToSpawn6;
	public GameObject NumToSpawn7;
	public GameObject NumToSpawn8;
	public GameObject NumToSpawn9;
	public GameObject NumToSpawn10;
	public GameObject NumToSpawn11;
	public GameObject NumToSpawn12;
	public GameObject NumToSpawn13;
	public GameObject NumToSpawn14;
	public GameObject NumToSpawn15;
	
    // Start is called before the first frame update
    void Start()
    {
		int[] a = {-1,1};
		int[] b = {1,2};
		int[] c = {-2,-1};
		int[] fixfalse = new int[2];

		int gigido = _Check.number;

		int rndFixAnswer = Random.Range(1,4);
		switch (rndFixAnswer)
		{
			case 1:
				fixfalse = a;
				break;
			case 2:
				fixfalse = b;
				break;
			case 3:
				fixfalse = c;
				break;
			default:
				break;
		}
		if (gigido <= 2){
			fixfalse = b;
		}

        GameObject clam1 = GameObject.FindWithTag("Clam1");
		GameObject clam2 = GameObject.FindWithTag("Clam2");
		GameObject clam3 = GameObject.FindWithTag("Clam3");
		GameObject nb1 = GameObject.FindWithTag("NB1");
		GameObject nb2 = GameObject.FindWithTag("NB2");
		GameObject nb3 = GameObject.FindWithTag("NB3");


		int rndSpawnNumber = Random.Range(1,7);
		switch (rndSpawnNumber)
		{
			case 1:
				_RandomSpawn(clam1, clam2, clam3, nb1, nb2, nb3, gigido, (gigido + fixfalse[0]), (gigido +  fixfalse[1]));
				break;
			case 2:
				_RandomSpawn(clam1, clam3, clam2, nb1, nb3, nb2, gigido, (gigido + fixfalse[0]), (gigido +  fixfalse[1]));
				break;
			case 3:
				_RandomSpawn(clam2, clam1, clam3, nb2, nb1, nb3, gigido, (gigido + fixfalse[0]), (gigido +  fixfalse[1]));
				break;
			case 4:
				_RandomSpawn(clam2, clam3, clam1, nb2, nb3, nb1, gigido, (gigido + fixfalse[0]), (gigido +  fixfalse[1]));
				break;
			case 5:
				_RandomSpawn(clam3, clam1, clam2, nb3, nb1, nb2, gigido, (gigido + fixfalse[0]), (gigido +  fixfalse[1]));
				break;
			case 6:
				_RandomSpawn(clam3, clam2, clam1, nb3, nb2, nb1, gigido, (gigido + fixfalse[0]), (gigido +  fixfalse[1]));
				break;
			default:
				break;
		}
    }

	void _RandomSpawn(GameObject TrueClamPos, GameObject FalseClamPos1, GameObject FalseClamPos2, GameObject TrueNBPos, GameObject FalseNBPos1, GameObject FalseNBPos2, int TrueClamAns, int FalseClamAns1, int FalseClamAns2)
	{
		GameObject ptst = Instantiate(prefabsToSpawn1);
		ptst.transform.position = TrueClamPos.transform.position;
		_getNB(TrueNBPos, TrueClamAns);
		GameObject ptsf1 = Instantiate(prefabsToSpawn2);
		ptsf1.transform.position = FalseClamPos1.transform.position;
		_getNB(FalseNBPos1, FalseClamAns1);
		GameObject ptsf2 = Instantiate(prefabsToSpawn3);
		ptsf2.transform.position = FalseClamPos2.transform.position;
		_getNB(FalseNBPos2, FalseClamAns2);
	}
	void _getNB(GameObject NBpos,int Ans){
		switch(Ans){
			case 1:
				GameObject ptst1 = Instantiate(NumToSpawn1);
				ptst1.transform.position = NBpos.transform.position;
				break;
			case 2:
				GameObject ptst2 = Instantiate(NumToSpawn2);
				ptst2.transform.position = NBpos.transform.position;
				break;
			case 3:
				GameObject ptst3 = Instantiate(NumToSpawn3);
				ptst3.transform.position = NBpos.transform.position;
				break;
			case 4:
				GameObject ptst4 = Instantiate(NumToSpawn4);
				ptst4.transform.position = NBpos.transform.position;
				break;
			case 5:
				GameObject ptst5 = Instantiate(NumToSpawn5);
				ptst5.transform.position = NBpos.transform.position;
				break;
			case 6:
				GameObject ptst6 = Instantiate(NumToSpawn6);
				ptst6.transform.position = NBpos.transform.position;
				break;
			case 7:
				GameObject ptst7 = Instantiate(NumToSpawn7);
				ptst7.transform.position = NBpos.transform.position;
				break;
			case 8:
				GameObject ptst8 = Instantiate(NumToSpawn8);
				ptst8.transform.position = NBpos.transform.position;
				break;
			case 9:
				GameObject ptst9 = Instantiate(NumToSpawn9);
				ptst9.transform.position = NBpos.transform.position;
				break;
			case 10:
				GameObject ptst10 = Instantiate(NumToSpawn10);
				ptst10.transform.position = NBpos.transform.position;
				break;
			case 11:
				GameObject ptst11 = Instantiate(NumToSpawn11);
				ptst11.transform.position = NBpos.transform.position;
				break;
			case 12:
				GameObject ptst12 = Instantiate(NumToSpawn12);
				ptst12.transform.position = NBpos.transform.position;
				break;
			case 13:
				GameObject ptst13 = Instantiate(NumToSpawn13);
				ptst13.transform.position = NBpos.transform.position;
				break;
			case 14:
				GameObject ptst14 = Instantiate(NumToSpawn14);
				ptst14.transform.position = NBpos.transform.position;
				break;
			case 15:
				GameObject ptst15 = Instantiate(NumToSpawn15);
				ptst15.transform.position = NBpos.transform.position;
				break;
			default:
				break;
		}
	}

}

