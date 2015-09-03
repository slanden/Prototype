using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {

    public Camera cam;
    public GameObject card1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cam.transform.position = card1.transform.position;
            //cam.transform.position = card1.transform.TransformDirection(card1.transform.position);
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, -1.44f);
        }

    }
}
