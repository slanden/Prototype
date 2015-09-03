using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkTestControlls : NetworkBehaviour
{
    [SyncVar]
    Vector3 otherplayer;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(1, 1, 1);

        if (isLocalPlayer)
            otherplayer = gameObject.GetComponent<Transform>().position;
    }

    // Update is called once per frame
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

           otherplayer = gameObject.GetComponent<Transform>().position;
        }
        else if (!isLocalPlayer)
            gameObject.GetComponent<Transform>().position = otherplayer;
    }
}
