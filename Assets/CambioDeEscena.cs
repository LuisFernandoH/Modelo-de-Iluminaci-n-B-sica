using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public string sceneName = "Point Light"; // Nombre de la escena a cargar
    public string sceneName2 = "Area Light"; // Nombre de la escena a cargar
    public string sceneName3 = "Spot Light"; // Nombre de la escena a cargar
    public string sceneName4 = "Directional Light"; // Nombre de la escena a cargar

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            LoadScene(sceneName);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            LoadScene(sceneName4);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            LoadScene(sceneName3);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            LoadScene(sceneName2);
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
