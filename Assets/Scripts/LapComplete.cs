using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject LapTrigger;
    public GameObject HalfLapTrigger;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    private void Start()
    {
        LapTrigger.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<TMPro.TextMeshProUGUI>().text += "0" + LapTimeManager.SecondCount + "";
        } else
        {
            SecondDisplay.GetComponent<TMPro.TextMeshProUGUI>().text += "" + LapTimeManager.SecondCount + "";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI>().text += "0" + LapTimeManager.MinuteCount + ":"; 
        }
        else
        {
            MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI>().text += "" + LapTimeManager.MinuteCount + "";
        }

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        LapTrigger.SetActive(false);
        HalfLapTrigger.SetActive(true);


    }

}
