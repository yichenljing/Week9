using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicCollinsion : MonoBehaviour
{
    AudioSource ding; //create a field for the AudioSource "audio"

    // Start is called before the first frame update
    void Start()
    {
        ding  = this.gameObject.GetComponent<AudioSource>(); //get the AudioSource component from this gameObject
    }

    // Update is called once per frame
    void Update()
    {

    }

    //if this game object collides with something
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.name == "player")
        ding.Play(); //play the audio
       
    }

}
