using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class SetupLocalPlayer : NetworkBehaviour {

    [SyncVar]
    public string pname = "player";

    [SyncVar]
    public Color playerColor = Color.white;

    void OnGUI()
    {
        if (isLocalPlayer)
        {
            pname = GUI.TextField(new Rect(25, Screen.height - 40, 100, 30), pname);
            if(GUI.Button(new Rect(130,Screen.height-40,80,30),"Change"))
            {
                CmdChangeName(pname);
            }
        }
    }

    [Command]
    public void CmdChangeName(string newName)
    {
        pname = newName;
    }

    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<drive>().enabled = true;

            //Camera.main.transform.position = this.transform.position - this.transform.forward * 10 + this.transform.up * 3;
            //Camera.main.transform.LookAt(this.transform.position);
            //Camera.main.transform.parent = this.transform;

            SmoothCameraFollow.target = this.transform;
        }
        Renderer[] rends = GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rends)
            r.material.color = playerColor;
        
        this.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
    }
    void Update()
    {
            this.GetComponentInChildren<TextMesh>().text = pname;
    }
}
