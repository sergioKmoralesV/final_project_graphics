using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    GameObject rotater;
    public void move()
	{
        rotater.gameObject.transform.Rotate(new Vector3(0, 180, 180));
	}
    void Start()
    {
        rotater = GameObject.Find("timeImage");
    }
   
}
