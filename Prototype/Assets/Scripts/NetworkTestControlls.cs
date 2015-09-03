using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkTestControlls : NetworkBehaviour
{


    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    [ClientCallback]
    void Update()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKeyDown(KeyCode.A))
                gameObject.GetComponent<Transform>().position -= new Vector3(1, 0, 0);
            if (Input.GetKeyDown(KeyCode.D))
                gameObject.GetComponent<Transform>().position -= new Vector3(-1, 0, 0);
            if (Input.GetKeyDown(KeyCode.W))
                gameObject.GetComponent<Transform>().position -= new Vector3(0, 0, -1);
            if (Input.GetKeyDown(KeyCode.S))
                gameObject.GetComponent<Transform>().position -= new Vector3(0, 0, 1);
        }

    }
}
