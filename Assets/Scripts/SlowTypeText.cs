using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowTypeText : MonoBehaviour {

    [Range(0,0.05f)]
    public float delay = 0.1f;
    public string fullText;
    string currentText = "";

    private void Start() {
        //StartCoroutine(ShowText());
    }

    private void Update() {
    }

    public IEnumerator SlowText() {
        Debug.Log("playing");
        for (int i = 0; i < fullText.Length + 1; i++) {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    public void Ayy() {
    }
}
