using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField]
    float radious = 0;
    [SerializeField]
    string new_text = "test";
    bool is_showed = false;
    GameObject player = null;
    GameObject text = null;
    GameObject input = null;
    void Awake()
    {
        player = GameObject.Find("Cube");
        text = GameObject.Find("Text");
        input = GameObject.Find("InputField"); //TMP_InputField
    }
    void Start()
    {
        if (input.activeSelf)
        {
            input.SetActive(false);
        }
    }
    void Update()
    {
        float delta_x = player.transform.position.x - this.transform.position.x, delta_z = player.transform.position.z - this.transform.position.z;
        if (delta_x * delta_x + delta_z * delta_z <= radious * radious) {
            if (Input.GetKeyDown(KeyCode.E) && !input.GetComponent<TMP_InputField>().isFocused) {
                if (!is_showed) {
                    text.GetComponent<TextMeshPro>().text = new_text;
                    input.GetComponent<TMP_InputField>().text = "";
                    input.SetActive(true);
                    is_showed = true;
                } else {
                    text.GetComponent<TextMeshPro>().text = "";
                    input.SetActive(false);
                    is_showed = false;
                }
            }
            if (Input.GetKeyDown(KeyCode.Return) && input.GetComponent<TMP_InputField>().text != "") {
                new_text = input.GetComponent<TMP_InputField>().text;
                text.GetComponent<TextMeshPro>().text = new_text;
                input.SetActive(false);
            }
                
        }
        else if (is_showed) {
            text.GetComponent<TextMeshPro>().text = "";
            input.SetActive(false);
            is_showed = false;
        }
    }
}
