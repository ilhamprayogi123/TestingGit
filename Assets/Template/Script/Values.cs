using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

using Random = UnityEngine.Random;

public class Values : MonoBehaviour
{
    public int brotherCount;
    public int moneyCount;
    public DateTime dateTime;

    // Start is called before the first frame update
    void Start()
    {
        //score = scoreManager.sc
        brotherCount = Random.Range(1, 4);
        moneyCount = Random.Range(1, 10);
        dateTime = DateTime.Now;
    }
}
