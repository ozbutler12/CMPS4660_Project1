using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class AnomalyList : MonoBehaviour
{
    [SerializeField] GameObject[] anomalyObjs;
    List<IAnomaly> anomalies;

     void Start()
    {
        anomalies = anomalyObjs.Select(z => z.GetComponent<IAnomaly>()).ToList();
    }


    public List<IAnomaly> Live
    {
        get
        {
            return anomalies?.Where(z => z.live)?.ToList();
        }
    }
}
