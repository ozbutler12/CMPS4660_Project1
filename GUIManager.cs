using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GUIManager : MonoBehaviour
{
    [SerializeField] GameObject purgeScreen;
    [SerializeField] GameObject detectorObj;
     IAnomalyDetector detector;
    private void Start()
    {
        detector = detectorObj.GetComponent<IAnomalyDetector>();
        detector.OnDetect += Purge;
    }

    void Purge()
    {
        purgeScreen.SetActive(true);
        StartCoroutine(DelayedAction());

    }

    private IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(2);
        purgeScreen.SetActive(false);
    }
}
