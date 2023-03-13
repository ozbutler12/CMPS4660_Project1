using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class AnomalyGenerator : MonoBehaviour
{
    InputManager inputManager;
    AnomalyList anomalyList;
    private void Start()
    {
        inputManager = GetComponent<InputManager>();
        anomalyList = GetComponent<AnomalyList>();
        inputManager.OnDebugEvent += Generate;
    }

    public void Generate()
    {
        var live = anomalyList.Live;
        var rnd = Random.Range(0, live.Count);
        live[rnd].Appear();
    }
}
