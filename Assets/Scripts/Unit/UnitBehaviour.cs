using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBehaviour : MonoBehaviour
{
    public Unit unit;

    //Getters
    public float Health 
    {
        get
        {
            return unit.GetHealth();
        }
        set
        {
            if (unit == null)
            {
                unit = new Unit();
            }
            else
            {
                unit.health = value;
            }
        }
    }
    public float Strength 
    {
        get
        {
            return unit.GetStrength();
        }
        set
        {
            if (unit == null)
            {
                unit = new Unit();
            }
            else
            {
                unit.strength = value;
            }
        }
    }
    public float Speed 
    {
        get
        {
            return unit.GetSpeed();
        }
        set
        {
            if (unit == null)
            {
                unit = new Unit();
            }
            else
            {
                unit.speed = value;
            }
        }
    }
    public float Defence 
    {
        get
        {
            return unit.GetDefence();
        }
        set
        {
            if (unit == null)
            {
                unit = new Unit();
            }
            else
            {
                unit.defence = value;
            }
        }
    }

    private void Start()
    {
        Debug.Log("health " + Health);
        Debug.Log("strength " + Strength);
        Debug.Log("speed " + Speed);
        Debug.Log("defence " + Defence);
    }

    private void Update()
    {

    }
}
