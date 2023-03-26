using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;

public class GetTimeAPI : MonoBehaviour
{
    private static readonly HttpClient _client = new HttpClient();

    private const string _urlTimeDB = "http://api.timezonedb.com/v2.1/get-time-zone?key=";

    private const string _key = "2OU0YV1DF3G7" + "&format=json&by=zone&zone=";

    private const string _country = "Asia/Yekaterinburg";
    
    void Start()
    {
        GetTime();
    }

    private async void GetTime()
    {
        var responseString = await _client.GetStringAsync(_urlTimeDB + _key + _country);
        Debug.Log(responseString);
    }
    
    void Update()
    {
        
    }
}
