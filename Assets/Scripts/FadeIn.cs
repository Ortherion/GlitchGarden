using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

    public float fadeInTime;
    public float alphaChange;
     
    private Image fadePanel;
    private Color currentColor = Color.black;

	// Use this for initialization
	void Start () {
        fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.timeSinceLevelLoad < fadeInTime) {
            fadePanel.CrossFadeAlpha(alphaChange, fadeInTime, false);
            //float alphaChange = Time.deltaTime / fadeInTime;
            //currentColor.a -= alphaChange;
            //fadePanel.color = currentColor;
        } else {
            gameObject.SetActive(false);
        }
	}

    
}
