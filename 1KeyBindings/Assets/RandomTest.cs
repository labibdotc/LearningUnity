using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    public int randomStart = 0;
    public int randomEnd = 4;
    public static string myPhrase1 = "Sit upright.";
    public static string myPhrase2 = "Take an eye break: look out a window.";
    public static string myPhrase3 = "Ask for help.";
    public static string myPhrase4 = "You should drink more water.";
    public static string myPhrase5 = "Get up and stretch.";
    public string[] myStrings = {myPhrase1, myPhrase2, myPhrase3, myPhrase4, myPhrase5};
    void Start() {
        randomEnd = myStrings.Length;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")){
            RandomMaker();
        }
    }
    void RandomMaker() {
        int randomNum = Random.Range(randomStart, randomEnd);
        Debug.Log("[r]: "+ myStrings[randomNum]);
    }
}
