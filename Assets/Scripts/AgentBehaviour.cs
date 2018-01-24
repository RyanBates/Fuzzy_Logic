using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBehaviour : MonoBehaviour
{
    Food food;
    Shelter house;
    Water water;

    public bool dead;

    bool fdesiger, fneed, wdesiger, wneed, rdesiger, rneed;

    bool close, mid, far;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (food.hunger == 100)
            food.full = true;

        if (water.thirst == 100)
            water.quenched = true;

        if (house.rest == 100)
            house.rested = true;

        /////////////////////////////////////////// about food

        if (food.full = false && food.hunger >= 50)
        {
            fneed = false;
            fdesiger = true;
        }
        
        if (food.full = false && food.hunger <= 50)
        {
            fneed = true;
            fdesiger = true;
        }

        if (food.full == true)
        {
            fneed = false;
            fdesiger = false;
        }

        /////////////////////////////////////////// about water

        if (water.quenched = false && water.thirst >= 50)
        {
            wneed = false;
            wdesiger = true;
        }

        if(water.quenched = false && water.thirst <= 50)
        {
            wneed = true;
            wdesiger = true;
        }

        if(water.quenched == true)
        {
            wneed = false;
            wdesiger = false;
        }


        /////////////////////////////////////////// about rest
        if (house.rested = false && house.rest >= 50)
        {
            rneed = false;
            rdesiger = true;
        }

        if (house.rested = false && house.rest <= 50)
        {
            rneed = true;
            rdesiger = true;
        }

        if(house.rested == true)
        {
            rneed = false;
            rdesiger = false;
        }
    }
}
