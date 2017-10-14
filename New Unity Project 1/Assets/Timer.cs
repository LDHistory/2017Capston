using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public static float time;
	// Use this for initialization
	void Start () {
        time = 1f;
	}
	
	// Update is called once per frame
	void Update () {

        if (time != 0) {

            time += Time.deltaTime;

        }
        int t=Mathf.FloorToInt(time);
       Text uiText=GetComponent< Text > ();
        uiText.text = "경과 시간: " + t.ToString();
	}
}
