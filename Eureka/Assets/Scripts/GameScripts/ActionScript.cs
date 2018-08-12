using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ActionScript {

    public static void DropApples(GameObject[]apples)
    {
        for (int i = 0; i < apples.Length; i++)
        {
            apples[i].GetComponent<Rigidbody>().useGravity = true;
            apples[i].GetComponent<Rigidbody>().isKinematic = false;
            apples[i].transform.parent = null;
        }
    }

}
