using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
	public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.0f) {

    		//LOCK UNIFORMITY
    		if( OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) > 0.0f) { 
    			Vector3 uniformScale = new Vector3(OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RHand).x,
    												 OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RHand).x,
    												 OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RHand).x);
    			obj.transform.localScale += uniformScale * 0.5f;
    		}

    		else {

    			obj.transform.localScale += OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RHand) * 0.5f;
    		}
    		Debug.Log(OVRInput.GetLocalControllerVelocity(OVRInput.GetActiveController()));
    		Debug.Log("inIF");
    	}

    	if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.0f) {
    		//LOCK UNIFORMITY
    		if( OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0.0f) { 
    			Vector3 uniformScale = new Vector3(OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LHand).x,
    												 OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LHand).x,
    												 OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LHand).x);
    			obj.transform.localScale += uniformScale * 0.5f;
    		}

    		else {
    			
    			obj.transform.localScale += OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LHand) * 0.5f;
    		}

    	}

    }
}
