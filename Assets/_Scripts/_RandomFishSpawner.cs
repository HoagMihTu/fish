using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _RandomFishSpawner : MonoBehaviour
{
	
	public string spawnPointTag1 = "sometag";
	public string spawnPointTag2 = "sometag";
	public bool alwaysSpawn = true;

	
	public List<GameObject> prefabsToSpawn1;
	public List<GameObject> prefabsToSpawn2;

    // Start is called before the first frame update
    void Start()
    {
		int gigido = _Check.number;
		int i = gigido;
		_Fish1Behavior.i = 0;
        GameObject[] fishes1 = GameObject.FindGameObjectsWithTag(spawnPointTag1);
		foreach(GameObject fish in fishes1){
			int randomPrefab = Random.Range(0, prefabsToSpawn1.Count);
			if(alwaysSpawn){
				GameObject pts = Instantiate(prefabsToSpawn1[randomPrefab]);
				pts.transform.position = fish.transform.position;
			}else{
				int spawnOrNot = Random.Range(0, 2);
				if (i == 0){
					spawnOrNot = 1;
				}
				if(spawnOrNot == 0){
					GameObject pts = Instantiate(prefabsToSpawn1[randomPrefab]);
					pts.transform.position = fish.transform.position;
					i--;
				}
			}
		}
		GameObject[] fishes2 = GameObject.FindGameObjectsWithTag(spawnPointTag2);
		foreach(GameObject fish in fishes2){
			int randomPrefab = Random.Range(0, prefabsToSpawn2.Count);
			if(alwaysSpawn){
				GameObject pts = Instantiate(prefabsToSpawn2[randomPrefab]);
				pts.transform.position = fish.transform.position;
			}else{
				int spawnOrNot = Random.Range(0, 2);
				if (i == 0){
					spawnOrNot = 1;
				}
				if(spawnOrNot == 0){
					GameObject pts = Instantiate(prefabsToSpawn2[randomPrefab]);
					pts.transform.position = fish.transform.position;
					i--;
				}
			}
		}
    }


}
