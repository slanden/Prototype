using UnityEngine;
using System.Collections;

public class GUIObjButtons : MonoBehaviour
{
    public int selGridInt = 0;
    public string[] selStrings = new string[] { "Grid 1", "Grid 2", "Grid 3", "Grid 4" };
    bool display = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    void OnGUI()
    {
        if(display == true)
        GUI.SelectionGrid(new Rect(25, 25, 100, 30), selGridInt, selStrings, 2);
    }

    void OnMouseDown()
    {
        display = true;
        print("ImHere");
    }
}
