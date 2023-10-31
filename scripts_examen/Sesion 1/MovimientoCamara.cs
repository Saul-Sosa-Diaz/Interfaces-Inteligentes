using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;
 
    public Vector2 sensitivity = Vector2.one * 360f;
    void Start()
    {
        Cursor.visible = false; // Ocultar el ratón
        Cursor.lockState = CursorLockMode.Locked; // Bloquear el ratón en el centro de la pantalla
        rotationX = transform.localEulerAngles.x;
        rotationY = transform.localEulerAngles.y;
    }
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity.x;
        rotationX += Input.GetAxis("Mouse Y") * Time.deltaTime * -1 * sensitivity.y;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Limitar la rotación en el eje X
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }

}
