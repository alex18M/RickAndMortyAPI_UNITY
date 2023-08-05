using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine.Networking;

public class APIManager : MonoBehaviour
{
    private string apiUrl = "https://rickandmortyapi.com/api"; // URL de la API

    public IEnumerator GetRequest(string endpoint, System.Action<Schema.ApiResponse> callback)
    {
        string requestUrl = apiUrl + endpoint;
    
        UnityWebRequest webRequest = UnityWebRequest.Get(requestUrl);
        yield return webRequest.SendWebRequest();
    
        if (webRequest.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error en la solicitud: " + webRequest.error);
        }
        else
        {
            string responseText = webRequest.downloadHandler.text;
            Schema.ApiResponse response = JsonConvert.DeserializeObject<Schema.ApiResponse>(responseText);
            callback?.Invoke(response);
        }
    }
    // POST.
}