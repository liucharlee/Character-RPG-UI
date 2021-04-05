using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPDisplay : MonoBehaviour
{
    public int points = 100;
    public Text pointsText;
    
    public int addPoints = 0;

    //IQDisplay toughnessScript;
    
    void Start(){
        //GameObject toughness = GameObject.Find("ToughnessDisplay");
        //toughnessScript = toughness.GetComponent<IQDisplay>();
    }
    
    // Update is called once per frame
    void Update()
    {
        pointsText.text = "HP : " + points;

        
        //addPoints = toughnessScript.points * 5;

        /*if(Input.GetKeyDown(KeyCode.Space)){
            strength = Random.Range(1, 10);
        }*/
    }

    public void Generate(){
        GameObject toughness = GameObject.Find("ToughnessDisplay");
        ToughnessDisplay toughnessScript = toughness.GetComponent<ToughnessDisplay>();
        addPoints = toughnessScript.points * 10;
        
        points = 100 + addPoints;
    }
}

