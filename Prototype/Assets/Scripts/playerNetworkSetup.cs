using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerNetworkSetup : NetworkBehaviour
{
    [SyncVar]private string playerUniqueIdentity;
    private NetworkInstanceId playerNetID;
    private Transform myTransform;
	private Camera playerCamera;

    public override void OnStartLocalPlayer()
    {
        //base.OnStartLocalPlayer();

        GetNetIdentity();
        SetIdentity();
    }

    //void Awake()
    //{
	//	myTransform = transform;
    //}
    void Start()
    {


        if (isLocalPlayer)
        {
			if (gameObject.transform.name == "Player 1") 
			{
				gameObject.transform.position = GameObject.FindObjectOfType<NetworkPlayerManager>().spawnPositionPlayer1;
				GameObject c = GameObject.Find("CameraPlayer1");
				c.GetComponent<Camera>().enabled = true;
			} 
			else 
			{
				gameObject.transform.position = GameObject.FindObjectOfType<NetworkPlayerManager>().spawnPositionPlayer2;
				GameObject c = GameObject.Find("CameraPlayer2");
				c.GetComponent<Camera>().enabled = true;
			}

            GetComponent<PlayerControls>().enabled = true;
        }
    }

    void Update()
    {
        if (transform.name == "" || transform.name == "Player(Clone)")
        {
            SetIdentity();
        }
    }


    [Client]
    void GetNetIdentity()
    {
        playerNetID = GetComponent<NetworkIdentity>().netId;
        CmdTellServerMyIdentity(MakeUniqueIdentity());
    }

    void SetIdentity()
    {
        if (!isLocalPlayer)
        {
            transform.name = playerUniqueIdentity;
        }
        else
        {
            transform.name = MakeUniqueIdentity();
        }
    }

    string MakeUniqueIdentity()
    {
		string uniqueIdentity = "null";
		if(playerNetID.Value % 2 == 1)
		{
			uniqueIdentity = "Player " + ((playerNetID.Value % 2)).ToString();
		}
		else if(playerNetID.Value % 2 == 0)
		{
			uniqueIdentity = "Player " + ((playerNetID.Value % 2) +2).ToString();
		}
        
        return uniqueIdentity;
    }

    [Command]
    void CmdTellServerMyIdentity(string name)
    {
        playerUniqueIdentity = name;
    }
	
}
