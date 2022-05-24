using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private AssetBundle bundle;
    private string[] paths;
    void Start () {
        print(this.transform.GetChild(0));
		Button btn = this.transform.GetChild(0).GetComponent<Button>();
		Button btn1 = this.transform.GetChild(1).GetComponent<Button>();
		btn.onClick.AddListener(OnClick);
		btn1.onClick.AddListener(OnClick1);
	}

	void OnClick(){
        SceneManager.LoadScene("Game1");
	}
    void OnClick1(){
        SceneManager.LoadScene("Game2");
	}
}
