using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   public enum TYPE
    {
        AMMO, COIN, GRENEADE, HEART, WEAPON
    }

    public TYPE type;
    public int value;

    void Update()
    {
        transform.Rotate(Vector3.up * 35 * Time.deltaTime);   
    }
}
