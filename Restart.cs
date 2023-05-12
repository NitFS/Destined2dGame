using UnityEngine;

public class Restart : MonoBehaviour {

 void Start()
 {
 }
 void Update()
     {
         if (Input.GetKeyDown(KeyCode.E))
         {
             Application.LoadLevel(1);
         }
     }
 }