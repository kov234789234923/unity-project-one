using UnityEngine;

public class FPS_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody rig;
    [SerializeField] private float speed = 1;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float mouseSensitivity = 2;
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 movementDir = cameraTransform.forward.normalized* vertical + cameraTransform.right.normalized * horizontal;
        movementDir = new Vector3 (movementDir.x, rig.linearVelocity.y, movementDir.z);
        rig.linearVelocity = Vector3.ClampMagnitude(movementDir,1) * speed;

        rig.angularVelocity = Vector3.zero;
        float newAngleX = cameraTransform.rotation.eulerAngles.x - mouseY * mouseSensitivity;
        if (newAngleX > 180) { newAngleX = newAngleX - 360; }
        newAngleX = Mathf.Clamp(newAngleX, -80, 80);
        //if (cameraTransform.rotation.eulerAngles.x - mouseY > 280 || cameraTransform.rotation.eulerAngles.x - mouseY < 80)
        cameraTransform.rotation = Quaternion.Euler(newAngleX, cameraTransform.rotation.eulerAngles.y, cameraTransform.rotation.eulerAngles.z);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseX * mouseSensitivity, transform.rotation.eulerAngles.z);
    }
}
