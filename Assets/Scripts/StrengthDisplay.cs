using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrengthDisplay : MonoBehaviour
{
    public int strength;
    public Text strengthText;

    // Update is called once per frame
    void Update()
    {
        strengthText.text = "STRENGTH : " + strength;

        /*if(Input.GetKeyDown(KeyCode.Space)){
            strength = Random.Range(1, 10);
        }*/
    }

    public void Generate(){
        strength = Random.Range(1, 10);
    }
}
