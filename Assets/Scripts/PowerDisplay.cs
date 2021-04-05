using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerDisplay : MonoBehaviour
{
    public int points = 0;
    public Text pointsText;

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "POWER : " + points;

        /*if(Input.GetKeyDown(KeyCode.Space)){
            strength = Random.Range(1, 10);
        }*/
    }

    public void Generate(){
        points = Random.Range(1, 10);
    }
}
