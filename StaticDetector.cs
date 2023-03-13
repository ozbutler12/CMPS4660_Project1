using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticDetector : MonoBehaviour, IAnomalyDetector
{
    [SerializeField] PaintingAnomaly anomaly;
    [SerializeField] InputManager inputManager;
    public System.Action OnDetect { get; set; }
    private void Start()
    {
        inputManager.OnReportEvent += Detect;
    }

    void Detect()
    {
        OnDetect?.Invoke();
        StartCoroutine(DelayedAction());
    }

    private IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(1.5f);
        anomaly.Disappear();
    }
}
