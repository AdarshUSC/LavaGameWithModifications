using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     // increase scale every frame
     transform.localScale += new Vector3(1f, 1f, 1f)*Time.deltaTime;

     // change the color of the ball every frame
     GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);   
    }
}
