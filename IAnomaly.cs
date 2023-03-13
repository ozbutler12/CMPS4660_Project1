using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnomaly
{
    public bool live { get;}

    public void Appear();
    public void Disappear();
}
