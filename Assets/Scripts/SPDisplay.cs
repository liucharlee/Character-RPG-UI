using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPDisplay : MonoBehaviour
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
        pointsText.text = "SP : " + points;

        
        //addPoints = toughnessScript.points * 5;

        /*if(Input.GetKeyDown(KeyCode.Space)){
            strength = Random.Range(1, 10);
        }*/
    }

    public void Generate(){
        GameObject IQ = GameObject.Find("IQDisplay");
        IQDisplay IQScript = IQ.GetComponent<IQDisplay>();
        addPoints = IQScript.points * 15;
        
        points = 100 + addPoints;
    }
}
