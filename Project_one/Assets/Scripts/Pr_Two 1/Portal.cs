using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] public Light _lightToTurnOn;
    [SerializeField] private LightChanger _lightChanger;

    private void Awake()
    {
        _lightChanger = Object.FindFirstObjectByType<LightChanger>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Player")) 
        {
            _lightChanger.ActivateLight(_lightToTurnOn);
        }
    }
}