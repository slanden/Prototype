using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {

    public Camera cam;
    public GameObject card1;
 
	void Start ()
    {
	
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            card1.transform.position = cam.ScreenToViewportPoint(transform.position);
        }
        
	}
}
