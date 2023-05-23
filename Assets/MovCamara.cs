using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float sensitivity = 1f;
    private bool isFirstClick = true;


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calcula la rotación de la cámara basada en la entrada del mouse
        Vector3 rotation = new Vector3(-mouseY, mouseX, 0f) * sensitivity;
        transform.eulerAngles += rotation;

        if (Input.GetMouseButtonDown(0))
        {
            if (isFirstClick)
            {
                Cursor.visible = false; // Oculta el cursor del mouse en el primer clic
                isFirstClick = false;
            }
            else
            {
                Cursor.visible = true; // Muestra el cursor del mouse en el segundo clic
                isFirstClick = true;
            }
        }
    }
}
