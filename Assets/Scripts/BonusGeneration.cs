using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGeneration : MonoBehaviour
{

    public float XSize = 8.8f;
    public float ZSize = 8.8f;
    public Vector3 curPos;
    public GameObject birdPrefab;
    public GameObject rabbitPrefab;
    public GameObject pigPrefab;
    public GameObject curBird;
    public GameObject curRabbit;
    public GameObject curPig;

    void Start()
    {
        BonusGenerate();
    }

    public void AddNewBird()
    {
        RandomPos();
        curBird = GameObject.Instantiate(birdPrefab, curPos, Quaternion.identity) as GameObject;
    }

    public void AddNewRabbit()
    {
        RandomPos();
        curRabbit = GameObject.Instantiate(rabbitPrefab, curPos, Quaternion.identity) as GameObject;
    }

    public void AddNewPig()
    {
        RandomPos();
        curPig = GameObject.Instantiate(pigPrefab, curPos, Quaternion.identity) as GameObject;
    }

    public void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize), 0.25f, Random.Range(ZSize * -1, ZSize));
    }


    //Every 13 seconds - generate random bonus.
    public void BonusGenerate()
    {
        StartCoroutine(TimerBonus());
    }
    IEnumerator TimerBonus()
    {
        yield return new WaitForSeconds(13);
        if (Random.value < .5f)
        {
            AddNewBird();
        }
        else if (Random.value < 1f)
        {
            AddNewPig();
        }
        yield return TimerBonus();
    }
}
