using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreHight : MonoBehaviour
{
    // Start is called before the first frame update
    Text scoreHigh;
    void Start()
    {
        scoreHigh = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        scoreHigh.text = "SCORE HIGH: " + Score.scoreHight;
    }
}
