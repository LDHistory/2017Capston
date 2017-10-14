using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static float SCORE=1;
    // Use this for initialization
    void Start () {
        SCORE =1f;
	}

    // Update is called once per frame
    void Update()
    {
        if (SCORE != 0)
        {

            SCORE += Time.deltaTime;
        }
            int t = Mathf.FloorToInt(SCORE);
            Text uiText = GetComponent<Text>();
            uiText.text = "점수: " + t.ToString();
    }
}
