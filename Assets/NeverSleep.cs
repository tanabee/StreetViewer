using UnityEngine;
using System.Collections;

public class NeverSleep : MonoBehaviour {

	void Awake () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
}
