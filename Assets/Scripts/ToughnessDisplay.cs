using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToughnessDisplay : MonoBehaviour
{
    public int points = 0;
    public Text pointsText;

   
    void Start(){
        //GameObject hp = GameObject.Find("HPDisplay");
        //HPDisplay hpScript = hp.GetComponent<HPDisplay>();
        //hpScript.addPoints += points * 5;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "TOUGHNESS : " + points;

        /*if(Input.GetKeyDown(KeyCode.Space)){
            strength = Random.Range(1, 10);
        }*/
    }

    public void Generate(){
        points = Random.Range(1, 10);
        
        /*GameObject hp = GameObject.Find("HPDisplay");
        HPDisplay hpScript = hp.GetComponent<HPDisplay>();
        hpScript.addPoints += points * 5;*/
    }
}
