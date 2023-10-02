using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayChange : MonoBehaviour
{
    public GameObject TreeArt;
     public bool isVisible = false;
    // Start is called before the first frame update
    void Start()
    {
        TreeArt.SetActive(isVisible);
    }

    // Update is called once per frame
    void Update()
    {
        TreeArt.SetActive(isVisible);

        if (Input.GetKeyDown(KeyCode.Space)){
            isVisible = !isVisible;
        }
        // TreeArt.SetActive(true);
    }
}
