using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shock : MonoBehaviour
{

    public UnityEvent shock;

    void start()
    {
        InvokeRepeating("ShockwaveEvent", 3f, 4f);
    }

    private void ShockwaveEvent()
    {
        shock.Invoke();
    }

}
