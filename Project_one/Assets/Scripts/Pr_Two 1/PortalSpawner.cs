using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner : MonoBehaviour
{
    [SerializeField] private LightChanger _lightChanger;
    [SerializeField] private Transform _portalParent;
    [SerializeField] private GameObject _lightPrefab;
    [SerializeField] private GameObject _portalPrefab;
    [SerializeField] private float _portalDistance = 2f;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            GameObject portalGO = Instantiate(_portalPrefab, _portalParent);
            portalGO.transform.localPosition = -Vector3.forward * _portalParent.childCount * _portalDistance + Vector3.up * 1.5f;

            GameObject lightGO = Instantiate(_lightPrefab, _lightChanger.transform);
            lightGO.transform.localPosition = Vector3.zero;

            Light light = lightGO.GetComponent<Light>();
            lightGO.SetActive(false);
            _lightChanger.lights.Add(light);

            portalGO.GetComponentInChildren<Portal>()._lightToTurnOn = light;

            Color randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            light.color = randomColor;

            
            List<MeshRenderer> meshRenderers = new List<MeshRenderer>(portalGO.GetComponentsInChildren<MeshRenderer>());
            foreach (MeshRenderer meshRenderer in meshRenderers)
            {
                
                Material newMaterial = new Material(meshRenderer.material);
                newMaterial.SetColor("_EmissionColor", randomColor);
                meshRenderer.material = newMaterial;
                
            }
        }
    }
}