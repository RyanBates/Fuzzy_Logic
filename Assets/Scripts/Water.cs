using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Water : MonoBehaviour
{
    float spawnTime;
    public float thirst;
    public bool quenched, pickedUp;

    public Slider water;

	// Use this for initialization
	void Start ()
    {
        thirst = 40;
	}
	
	// Update is called once per frame
	void Update ()
    {
        thirst -= Time.deltaTime / 2;


        water.value = thirst;
        water.maxValue = 100;
        water.minValue = 0;
    }
}
