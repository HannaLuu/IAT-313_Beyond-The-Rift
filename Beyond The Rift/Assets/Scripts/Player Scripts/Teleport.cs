using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform clonePoint;

    public GameObject clonePrefab;

    GameObject clone;
    public TimeManager timeManager;

    public bool teleportMode = false;

    Vector3 teleportPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject tpClone = GameObject.FindGameObjectWithTag("TP-Clone_Player");

        //if(tpClone)
        //{
        //teleportPos = tpClone.transform.position;
        //teleportPos = clone.transform.position;
        //}

        if(clone != null)
        {
            teleportPos = clone.GetComponent<TP_Clone>().transform.position;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            SendClone();
            teleportMode = true;
            timeManager.DoSlowMotion();
        }

        if (Input.GetButtonDown("Fire3") && clone.GetComponent<TP_Clone>().colliding == false)
        {
            teleportMode = false;
            Teleport();
        }

        void SendClone()
        {
            clone = Instantiate(clonePrefab, clonePoint.position, clonePoint.rotation) as GameObject;
        }

        void Teleport()
        {
            transform.position = teleportPos;
        }
    }
}
