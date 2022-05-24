using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        float z = Input.GetAxis("Vertical") * 0.1f;
        float x = Input.GetAxis("Horizontal") * 0.1f;
        float y = 0;
        if (Input.GetKeyDown(KeyCode.Space) && this.transform.position.y < 0.26f)
        {
            y = 5;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Menu");

        Rigidbody rg = this.GetComponent<Rigidbody>();
        rg.AddForce(new Vector3(x, y, z), ForceMode.VelocityChange);
    }
}
