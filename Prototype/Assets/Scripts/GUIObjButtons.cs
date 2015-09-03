using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIObjButtons : MonoBehaviour
{
    public bool isDisplay = false;
    public bool isDeck;
    public bool isHand;
    public bool isField;
	// Use this for initialization
	void Start () {
        datButton.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update ()
    {   if (isDisplay == true)
        {
            datButton.SetActive(true);
        }
        else
        {
            datButton.SetActive(false);
        }

	}

    public void buttonActions(string n)
    {
        print(n);
        /*
        function calls go in here for the actions that should be performed 
        when the button is pressed
        */
    }

    void OnMouseOver()
    {
        isDisplay = true;
    }

    void OnMouseExit()
    {
        isDisplay = false;
    }

    public GameObject datButton;

    
}
