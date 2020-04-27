using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{

    public GameObject LapTrigger;
    public GameObject HalfLapTrigger;

    private void OnTriggerEnter(Collider other)
    {
        LapTrigger.SetActive(true);
        HalfLapTrigger.SetActive(false);
    }

}
