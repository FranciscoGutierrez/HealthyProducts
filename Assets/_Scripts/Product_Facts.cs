using RestSharp;
using System.Net;
using UnityEngine;

public class Product_Facts : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ServicePointManager.ServerCertificateValidationCallback +=  (sender, certificate, chain, sslPolicyErrors) => true;
				// Test this with mlab. 
        var client = new RestClient("http://beta.json-generator.com/");
        var request = new RestRequest("api/json/get/EJXTAEX2M", Method.GET);
        IRestResponse response = client.Execute(request);
        var content = response.Content;
        print(content);
    }

    // Update is called once per frame
    void Update () {

	}
}
