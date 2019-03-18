using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckGround : MonoBehaviour {

    private controles player;
    


	// Use this for initialization
	void Start () {

        player = GetComponentInParent<controles>();
	}

     void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            player.grounded = true;
        }
    }

     void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            player.grounded = false;
        }   
    }
}