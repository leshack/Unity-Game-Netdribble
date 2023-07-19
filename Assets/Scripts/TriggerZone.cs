using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    //We declare a light datatype here
    public Light myLight;
    //We also declare the duration it will take for us to switch the color of the lighting
    float duration = 5.0f;
    //We declare and initialize the colors of the lights we wish switch between
    Color color0 = Color.red;
    Color color1 = Color.white;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Inbuilt functin for invoking a trigger
    void OnTriggerEnter(Collider other)
    {
        //we print out sth
        Debug.Log("Danger Zone");
        //We are light intensity
        myLight.intensity = Mathf.PingPong(Time.time, 0.2f);
        //Math pingpong function smoothens the transition between different colors or intensity
        float t = Mathf.PingPong(Time.time, duration) / duration;
        myLight.color = Color.Lerp(color0, color1, t);
    }
    void OnTriggerExit(Collider other)
    {
        myLight.intensity = 1.0f;
        myLight.color = color1;
        Debug.Log("Safe Zone");
    }
}