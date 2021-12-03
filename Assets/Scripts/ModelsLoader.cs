using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ModelsLoader : MonoBehaviour
{
    string filePath;

    private void Start()
    {
        
        filePath = $"{Application.persistentDataPath}/Files/";
    }

    public void DownloadFile(string url)
    {
        StartCoroutine(GetFileRequest(url, (UnityWebRequest req) =>
        {
            if (req.isNetworkError || req.isHttpError)
            {
                // Log any errors 
                Debug.Log($"{req.error} : {req.downloadHandler.text}");
            }
            else
            {
                // Success!
                Debug.Log(req.downloadHandler.text);
            }
        }));
    }

    IEnumerator GetFileRequest(string url, Action<UnityWebRequest> callback)
    {
        using (UnityWebRequest req = UnityWebRequest.Get(url))
        {
            yield return req.SendWebRequest();
            callback(req);
        }
    }
}