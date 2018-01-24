using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shelter : MonoBehaviour
{
    float spawnTime;
    public float rest;
    public bool rested, pickedUp;

    public Slider house;

	// Use this for initialization
	void Start ()
    {
        rest = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
        rest -= Time.deltaTime / 2.5f;

        house.value = rest;
        house.maxValue = 100;
        house.minValue = 0;
    }
}
