using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject UI;

    private void OnTriggerEnter(Collider other)
    {
        UI.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        UI.SetActive(false);
    }
}
