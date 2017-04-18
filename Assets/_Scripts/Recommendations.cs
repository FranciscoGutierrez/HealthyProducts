using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recommendations : MonoBehaviour {

    public GameObject itemPrefab;
    public string productID;
    public int itemCount = 3;

    void Start() {
        //RectTransform rowRectTransform = itemPrefab.GetComponent<RectTransform>();
        //RectTransform containerRectTransform = gameObject.GetComponent<RectTransform>();
        //float width = containerRectTransform.rect.width;
        //float ratio = width / rowRectTransform.rect.width;
        //float height = rowRectTransform.rect.height * ratio;
        //int rowCount = itemCount;
        //float scrollHeight = height * rowCount;
        //containerRectTransform.offsetMin = new Vector2(containerRectTransform.offsetMin.x, -scrollHeight / 2);
        //containerRectTransform.offsetMax = new Vector2(containerRectTransform.offsetMax.x, scrollHeight / 2);
        for (int index = 0; index < itemCount; index++) {
            GameObject newItem = Instantiate(itemPrefab) as GameObject;
            newItem.name = itemPrefab.name + index;
            newItem.transform.parent = gameObject.transform;

            RectTransform rectTransform = newItem.GetComponent<RectTransform>();
            rectTransform.offsetMin  = new Vector2(0, 0);
            rectTransform.offsetMax  = new Vector2(160, 80);
            rectTransform.localScale = new Vector3(1, 1, 1);
            rectTransform.rotation   = Quaternion.Euler(90, 0, 0);
            if (index == 0) rectTransform.localPosition = new Vector3(0,  12, 0);
            if (index == 1) rectTransform.localPosition = new Vector3(0,  72, 0);
            if (index == 2) rectTransform.localPosition = new Vector3(0, -48, 0);
        }
    }
}