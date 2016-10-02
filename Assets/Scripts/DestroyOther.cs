using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player" && other.gameObject.tag == "NormalObject")
        {
            Debug.Log("Object is suppose to be destroyed.");
            Destroy(other.gameObject);
        }

    }
}
