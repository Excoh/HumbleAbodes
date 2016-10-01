using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject breakableCube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(breakableCube, transform.position, transform.rotation);
        }
	}
}
