using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Food : MonoBehaviour
{
    AgentBehaviour agent;

    float spawnTime;
    public float hunger;

    public bool full, pickedUp;

    public Slider food;

	// Use this for initialization
	void Start ()
    {
        hunger = 70;
	}
	
	// Update is called once per frame
	void Update ()
    {
        hunger -= Time.deltaTime;

        food.value = hunger;
        food.maxValue = 100;
        food.minValue = 0;

        if (hunger == 0)
            agent.dead = true;
	}
}
