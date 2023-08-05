using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RestAPI : MonoBehaviour
{
    private APIManager apiManager;

    private void Start()
    {
        apiManager = GetComponent<APIManager>();
        StartCoroutine(apiManager.GetRequest("/character", HandleResponse));
    }

    private void HandleResponse(Schema.ApiResponse response) // Cambiamos ApiResponse por Schema.ApiResponse
    {
        foreach (var character in response.results)
        {
            Debug.Log("ID: " + character.id + ", Nombre: " + character.name);
        }
    }
}