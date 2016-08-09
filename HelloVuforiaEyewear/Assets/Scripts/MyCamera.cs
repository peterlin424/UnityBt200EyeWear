using UnityEngine;
using System.Collections;

public class MyCamera : MonoBehaviour {

	Renderer rend;
	void Start () {
		rend = this.GetComponent<Renderer>();
		WebCamTexture wc = new WebCamTexture ();
		rend.material.mainTexture = wc;
		wc.Play ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
