using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnomalyDetector
{
    public System.Action OnDetect { get; set; }
}
