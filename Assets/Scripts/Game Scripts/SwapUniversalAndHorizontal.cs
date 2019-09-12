using UnityEngine;
using System.Collections;

public class SwapUniversalAndHorizontal : MonoBehaviour 
{
    public static SwapUniversalAndHorizontal instance;
    PlayingObject universalPlayingObject;
    PlayingObject horizontalPlayingObject;
    string horizontalPOName = "";

    void Awake()
    {
        instance = this;
    }
	
	void Start () 
    {
	
	}


    internal void StartSwapProcess(PlayingObject universalPO,PlayingObject horizontalPO)
    {
		Debug.Log ("StartSwapProcess");
		horizontalPOName = horizontalPO.name;
        universalPlayingObject = universalPO;
        horizontalPlayingObject = horizontalPO;

        StartCoroutine(ChangeAllToOne());
    }


    IEnumerator ChangeAllToOne()
    {
		Debug.Log ("ChangeAllToOne");
		yield return new WaitForSeconds(GameManager.instance.swappingTime);

        for (int i = 0; i < ColumnManager.instance.gameColumns.Length; i++)
        {
            for (int j = 0; j < ColumnManager.instance.gameColumns[i].playingObjectsScriptList.Count; j++)
            {
                if ((PlayingObject)ColumnManager.instance.gameColumns[i].playingObjectsScriptList[j])
                {
                    if (((PlayingObject)ColumnManager.instance.gameColumns[i].playingObjectsScriptList[j]).name == horizontalPOName)
                    {
                        PlayingObject po = ((PlayingObject)ColumnManager.instance.gameColumns[i].playingObjectsScriptList[j]);

                        if (po.objectType == ObjectType.None)
                        {
                            Destroy(((PlayingObject)ColumnManager.instance.gameColumns[i].playingObjectsScriptList[j]).gameObject);
                            GameObject pref;
                            if (Random.value < .5f)
                                pref = horizontalPlayingObject.horizontalPowerPrefab;
                            else
                                pref = horizontalPlayingObject.verticalPowerPrefab;

                            ColumnManager.instance.gameColumns[i].ChangeItem(j, pref, horizontalPOName);
                            //SoundFxManager.instance.tickSound.Play();
							AkSoundEngine.PostEvent ("sfx_clock_tick", GameObject.Find ("WwiseGlobal"));
                            yield return new WaitForSeconds(.2f);
                        }
                    }
                }
            }
        }

        StartCoroutine(BurstAll());
    }


    IEnumerator BurstAll()
    {
		Debug.Log ("BurstAll");
		universalPlayingObject.DestroyMe();

        for (int i = 0; i < ColumnManager.instance.gameColumns.Length; i++)
        {
            for (int j = 0; j < ColumnManager.instance.gameColumns[i].playingObjectsScriptList.Count; j++)
            {
                if ((PlayingObject)ColumnManager.instance.gameColumns[i].playingObjectsScriptList[j])
                {
                    if (((PlayingObject)ColumnManager.instance.gameColumns[i].playingObjectsScriptList[j]).name == horizontalPOName)
                    {
                        PlayingObject po = ((PlayingObject)ColumnManager.instance.gameColumns[i].playingObjectsScriptList[j]);

                        if (po.brust == false)
                        {
                            po.specialObjectScript.AssignBrustToItsTarget();
							AkSoundEngine.PostEvent ("sfx_special_match", GameObject.Find ("WwiseGlobal"));
                            yield return new WaitForSeconds(.6f);
                        }
                         
                    }
                }
            }
        }

        print("1");
        GameOperations.instance.RemoveBrustItems();
        GameOperations.instance.Invoke("AddMissingItems", .1f);
    }

    
	
	
}
