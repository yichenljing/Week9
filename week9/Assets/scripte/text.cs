using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{

    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("text").GetComponent<Text>();
        myText.color = Color.clear;
        
    }

    // Update is called once per frame
    void Update()
    {
        FadeText();


    }
    void OnTriggerEnter(Collider other) //enter the range
    {
        if (other.GetComponent<Collider>().name == "player")
            displayInfo = true;
    }

    void OnTriggerExit(Collider other)  //leave the range
    {
        if (other.GetComponent<Collider>().name == "player")
            displayInfo = false;
    }

    void FadeText() {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }


}
