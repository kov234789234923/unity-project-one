using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public List<Light> lights;
    public List<Material> environmentMaterials; 

    private void Start()
    {
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].gameObject.SetActive(false);
        }
        if (lights.Count > 1)
        {
            lights[1].gameObject.SetActive(true);
            
            UpdateEnvironmentMaterialsColor(lights[1].color);
        }
    }

    
    public void UpdateEnvironmentMaterialsColor(Color newColor)
    {
        foreach (Material material in environmentMaterials)
        {
            material.SetColor("_EmissionColor", newColor);
        }
    }

    
    public void ActivateLight(Light lightToActivate)
    {
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].gameObject.SetActive(false);
        }
        lightToActivate.gameObject.SetActive(true);

        
        UpdateEnvironmentMaterialsColor(lightToActivate.color);
    }
}