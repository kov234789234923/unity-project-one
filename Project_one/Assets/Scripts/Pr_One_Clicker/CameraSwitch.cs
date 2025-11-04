using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour 
{
    private Camera mainCameraComponent;
    [SerializeField] private Camera otherCameraComponent;
    [SerializeField] private Score scoreScript;
    public bool isMainCamera;

    private void Start()
    {

        mainCameraComponent = GetComponent<Camera>();
        mainCameraComponent.depth = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            scoreScript.scoreValue++;
            scoreScript.scoreText.text = "Score:" + scoreScript.scoreValue.ToString();
            mainCameraComponent.depth = 1;
            otherCameraComponent.depth = 0;
            isMainCamera = true;
}

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            scoreScript.scoreValue--;
            scoreScript.scoreText.text = "Score:" + scoreScript.scoreValue.ToString();
            mainCameraComponent.depth = 0;
            otherCameraComponent.depth = 1;
            isMainCamera = false;
        }
    }
}
