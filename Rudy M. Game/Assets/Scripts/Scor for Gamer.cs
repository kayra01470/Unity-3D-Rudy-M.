using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorforGamer : MonoBehaviour
{
    int hits = 0;
     private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag != "hit"){
            hits++;
            Debug.Log("You have crashed" + " " + hits + " " +  " times");
        }
    }

}