using RestSharp;
using System.Net;
using UnityEngine;

public class ProductFacts : MonoBehaviour {
    // Use this for initialization
    void Start () {
        // Test this with mlab. 
        var apikey = MongoDB.Instance.ApiKey;
        var db     = MongoDB.Instance.Database;
        var client = new RestClient(db + "collections/products?");
        var request = new RestRequest("q={'barcode': 8214343481}&apiKey=" + apikey, Method.GET);
        IRestResponse response = client.Execute(request);
        var content = response.Content;
        print(content);
    }

    // Update is called once per frame
    void Update () {

	}
}
