using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ProductFacts : MonoBehaviour{
    public string code = "8214343481";
    // Use this for initialization
    void Start() {
        // Test this with mlab. 
        var apikey = MongoDB.Instance.ApiKey;
        var db     = MongoDB.Instance.Database;

        StartCoroutine(GetProduct(apikey, db, code));
    }

    private IEnumerator GetProduct(string apikey, string db, string code){
        var query = "collections/products?q={%22barcode%22:%20"+code+"}";
        using (UnityWebRequest request = UnityWebRequest.Get(db+query+"&apiKey="+apikey)){
            yield return request.Send();
            if (request.isError){
                Debug.Log(request.error);
            }
            else{
                Debug.Log(request.downloadHandler.text);
            }
        }
    }

}
