using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using TMPro;

[System.Serializable]

public class _ClamBehavior : MonoBehaviour
{

    public TMP_Text Answer;
    public string type;
    public int answer = 0;
    public static int score = 0;
    public GameObject prefabsToSpawn;
    public GameObject SBToSpawn;
    public GameObject EffectToSpawn;
    public GameObject BtnToDestroy;
    public static Vector2 TrueMark;
    public static int onclick = 0;
    public static int onend = 3;
    public static int endcheck = 0;
    public static int begone = 0;
    private Button btn;


        [SpineAnimation]
		public string open1Animation;
        [SpineAnimation]
		public string open2Animation;

		[SpineAnimation]
		public string close1Animation;
        [SpineAnimation]
		public string close2Animation;

        SkeletonAnimation skeletonAnimation;

		// Spine.AnimationState and Spine.Skeleton are not Unity-serialized objects. You will not see them as fields in the inspector.
		public Spine.AnimationState spineAnimationState;
		public Spine.Skeleton skeleton;


    // Start is called before the first frame update
    void Start()
    {
        // Debug.unityLogger.logEnabled = false;
        skeletonAnimation = GetComponent<SkeletonAnimation>();
		spineAnimationState = skeletonAnimation.AnimationState;
		skeleton = skeletonAnimation.Skeleton;
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (begone >0){
            Destroy(BtnToDestroy);
        }
    }
    public void ClamOnClick(){
        onend = onend -1 ;
        begone = 1;
        StartCoroutine(openclam());
        Invoke("AfterCredits",1);
        Invoke("ReloadScene", 4);
    }
    void ReloadScene(){
        if (onend > 0){
            _Check.number = Config.getNumber();
            SceneManager.LoadScene("Game");
            onclick = 0;
            begone = 0;
        }else{
            endcheck++;
            if (endcheck == 1){
                int[] point;
                point = new int[6];
                point = _StoreScores.point;
                if (score >= point[Config.level]){
                    _StoreScores.SaveLevelPoint("level"+Config.level, score);
                }
                GameObject SBpos = GameObject.FindWithTag("SB");
                GameObject ptst = Instantiate(SBToSpawn);
                ptst.transform.position = SBpos.transform.position;
                GameObject ptst1 = Instantiate(EffectToSpawn);
                ptst1.transform.position = SBpos.transform.position;
                _StarBehavior.checkend++;
            }
            onclick = 0;
            begone = 0;
        }
        _Fish1Behavior.i = 0;
    }

    IEnumerator openclam () {
				spineAnimationState.SetAnimation(0, open1Animation, true);
				yield return new WaitForSeconds(0.8f);
                spineAnimationState.SetAnimation(0, open2Animation, true);
				yield return new WaitForSeconds(2);
                spineAnimationState.SetAnimation(0, close2Animation, true);
				yield return new WaitForSeconds(0.3f);
                spineAnimationState.SetAnimation(0, close1Animation, true);
				yield return new WaitForSeconds(1);
	}

    void AfterCredits(){
        if(type == "False"){
            onclick = 1;
            Invoke("SharkAttack", 1);
            GameObject ptst = Instantiate(prefabsToSpawn);
		    ptst.transform.position = transform.position + new Vector3(0,2.5f,0)-(transform.forward*2);
        } else{
            onclick = 2;
            TrueMark = transform.position+ new Vector3(0,2.5f,0);
            score++;
        }
    }
}
