using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBarchart : MonoBehaviour {

    public GameObject emptyGraphPrefab;
    public WMG_Axis_Graph graph;
    
    // Use this for initialization
    void Start () {
        GameObject graphGO = GameObject.Instantiate(emptyGraphPrefab);
        graphGO.transform.SetParent(this.transform, false);
        graph = graphGO.GetComponent<WMG_Axis_Graph>();

    }
}
