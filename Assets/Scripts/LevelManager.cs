using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public float gameScale =  0f;

    public Image keyUIImage;
    public Animator canvasAnim;
    public Text gameText;
    public static bool keyPickedUp = false;
    bool keyPickupTextShow = false;

    SlowTypeText slowType;
	// Use this for initialization
	void Start () {
        slowType = gameText.gameObject.GetComponent<SlowTypeText>();
	}
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = gameScale;
        Debug.Log(keyPickedUp);
        if (keyPickedUp == true && keyPickupTextShow == false) {
            keyUIImage.gameObject.SetActive(true);
            StartCoroutine(StartTimedText("You have found the hidden key", 2f));
            keyPickupTextShow = true;

        }
	}

    public IEnumerator StartTimedText(string textToShow, float sec) {
        ShowText(textToShow);        
        yield return new WaitForSeconds(sec);
        gameText.gameObject.SetActive(false);
        gameText.GetComponent<SlowTypeText>().fullText = "";
    }



    public void ShowText(string textToShow) {
        //StopAllCoroutines();
        //gameText.text = textToShow;
        slowType.fullText = textToShow;
        StartCoroutine(slowType.SlowText());
        gameText.gameObject.SetActive(true);
    }
    public void HideText() {
        gameText.gameObject.SetActive(false);
        gameText.text = "";
        slowType.fullText = "";
        
    }
}
