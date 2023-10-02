using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LoopTest : MonoBehaviour {

      void Start(){
            MyForLoop();
      }

      void MyForLoop(){
            for (int i = 0; i < 100; i++){
                 Debug.Log("The for-loop is now at " + i);
           }
      }
}