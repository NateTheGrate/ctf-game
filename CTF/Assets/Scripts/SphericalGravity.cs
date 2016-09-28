using UnityEngine;
using System.Collections;

public class SphericalGravity : MonoBehaviour {

    public float gravityForce;
    public float range;
	// Use this for initialization
	void Start () {
        foreach (Object o in UnityEngine.Object.FindObjectsOfType<GameObject>()) {
            Debug.Log(o.ToString() );
        }
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    // FixedUpdate is called every physics call
    void FixedUpdate() {

        //find all objects not a planet, with a rigidbody, in range to apply gravity to it
        foreach (GameObject o in UnityEngine.Object.FindObjectsOfType<GameObject>() ) {
            
            if (!o.tag.Equals("Planet")) { //if is not planet

                //maybe add a component to have some object be affected and some not
                if (o.GetComponent<Rigidbody>() != null) { // if has rigidbody

                    if (Mathf.Abs(Vector3.Distance(this.transform.position, o.transform.position)) < range) { //if in range

                        o.GetComponent<Rigidbody>().AddForceAtPosition((this.transform.position - o.transform.position) * gravityForce * Time.deltaTime, this.transform.position); //apply force

                    }

                }

            }

        }
    }
}
