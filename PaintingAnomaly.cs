using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingAnomaly : MonoBehaviour, IAnomaly
{
    [SerializeField] Material normal, anomaly;
    [SerializeField] Renderer painting;

    [SerializeField] bool _live;
    public bool live
    {
        get { return _live; }
    }

    public void OnValidate()
    {
        painting = GetComponent<Renderer>();
        painting.material = normal;
    }

    public void Appear()
    {
        _live = false;
        painting.material = anomaly;
    }

    public void Disappear()
    {
        painting.material = normal;
    }
}
