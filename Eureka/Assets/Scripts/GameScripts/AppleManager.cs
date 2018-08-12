using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleManager : MonoBehaviour
{
    public GameObject[] apples;

    void OnTriggerStay(Collider coll)
    {
        if(coll.gameObject.transform.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ActionScript.DropApples(apples);
            }
        }
    }
}
