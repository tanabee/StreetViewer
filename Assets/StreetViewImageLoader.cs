using UnityEngine;
using System.Collections;

public class StreetViewImageLoader : MonoBehaviour {
	
	public double heading = 0.0;
	public double pitch = 0.0;
	
	private int width = 640;
	private int height = 480;
	
	private double longitude = 139.667431;
	private double latitude = 35.697408;
	
	// Use this for initialization
	void Start () {
		StartCoroutine(GetStreetViewImage(latitude, longitude, heading, pitch));
	}
	
	private IEnumerator GetStreetViewImage(double latitude, double longitude, double heading, double pitch) {
		string url = "http://maps.googleapis.com/maps/api/streetview?" + "size=" + width + "x" + height + "&location=" + latitude + "," + longitude + "&heading=" + heading + "&pitch=" + pitch + "&fov=90&sensor=false";
		
		WWW www = new WWW(url);
		yield return www;
		
		GetComponent<Renderer>().material.mainTexture = www.texture;
	}
}
