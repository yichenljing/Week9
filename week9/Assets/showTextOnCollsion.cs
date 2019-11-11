
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showTextOnCollsion : MonoBehaviour
{
    /*  public GameObject Uiobject;
      public GameObject trigger;
      // Start is called before the first frame update

      void start()
      {
          Uiobject.SetActive(false);
      }
      private void OnTriggerEnter(Collider other)
      {
          if (other.GetComponent<Collider>().name == "FPSController")
             {

              Uiobject.SetActive(true);
          }
      }

      // Update is called once per frame
      void Update()
      {

      }
      private void OnTriggerExit(Collider other)
      {
          Uiobject.SetActive(false);
          Destroy(trigger);
      }*/


    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;
    public BoxCollider BoxCollider;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("textCandle").GetComponent<Text>();
        myText.color = Color.clear;

    }

    // Update is called once per frame
    void Update()
    {
        FadeText();

        /*   if (Input.GetKeyDown(KeyCode.Escape)) {
               Screen.lockCursor = false;
           }
           */
    }
    
    void OnTriggerEnter(Collider other) //enter the range
    {
        print("进入碰撞范围");
        if (other.GetComponent<Collider>().name == "FPSController") //需要进入碰撞的名称
        {
            timeTick = 0;
            displayInfo = true;
        }
    }
    void OnTriggerExit(Collider other)  //离开碰撞范围
    {
        print("离开碰撞范围");
        if (other.GetComponent<Collider>().name == "FPSController") //需要进入碰撞的名称
        {
            myText.color = new Color(0,0,0,0);
            displayInfo = false;
            timeTick = 0;
        }
    }



    float timeTick = 0;
    void FadeText()
    {
        timeTick += Time.deltaTime;
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, new Color(1,1,1,1), timeTick/fadeTime );
        }
    }

 
}
