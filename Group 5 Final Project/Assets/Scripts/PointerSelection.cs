using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerSelection : MonoBehaviour
{
	//This is represented by the cube at the tip of the wand
  public GameObject pointer;

  private GameObject selection = null;

	// public GameObject selected;

	// private bool collision;


    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
    	RaycastHit hit;
    	Outline o;
        ChangeSize c;

        if (Physics.Raycast(pointer.transform.position, pointer.transform.TransformDirection(Vector3.forward), out hit)){
    		// Debug.DrawRay(pointer.transform.position, pointer.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
      //   	Debug.Log(hit.collider.gameObject.name);
     		Debug.Log("Ray Hit something. It was");
        	Debug.Log(hit.collider.gameObject.name);


            // if the previous selection was not the current selection, unmark it
            if ( (selection != null) && (selection.name != hit.collider.gameObject.name)) {
 
                o = selection.gameObject.GetComponent<Outline>();   
                o.enabled = false;

                c = selection.gameObject.GetComponent<ChangeSize>();
                c.enabled = false;

            }

            // add a tag to the hit "UnitSelected", this will indicate the selection, and should be
            // checked for if you want to know if an object is selected.

            selection = hit.collider.gameObject;
            o = selection.gameObject.GetComponent<Outline>();
            o.enabled = true;

            c = selection.gameObject.GetComponent<ChangeSize>();
            c.enabled = true;
            Debug.Log(o.enabled);
            Debug.Log(!o.enabled);
            // hit.collider.gameObject.GetComponent.enabled = true;
            selection = hit.collider.gameObject;



    	}
	}
}

