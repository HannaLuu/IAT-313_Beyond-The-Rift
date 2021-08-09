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

    public ManaBar manaBar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(manaBar.SpendMana);
        //Debug.Log(teleportMode);
        if(clone != null)
        {
            teleportPos = clone.GetComponent<TP_Clone>().transform.position;
        }

        if(manaBar.manaAmount <= 0f)
        {
            teleportMode = false;
        }

        if (Input.GetButtonDown("Fire2") && manaBar.CanSpendMana(manaBar.manaCost) == true)
        {
            SendClone();
            teleportMode = true;
            manaBar.SpendMana = true;
            timeManager.DoSlowMotion();
        }

        if (Input.GetButtonDown("Fire3") && clone.GetComponent<TP_Clone>().colliding == false)
        {
            teleportMode = false;
            manaBar.SpendMana = false;
            FindObjectOfType<AudioManager>().Play("Teleport");
            Teleport();
        }

        if (teleportMode == false)
        {
            manaBar.SpendMana = false;
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
