using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    // Start is called before the first frame update
    float delta_x = 0, delta_z = 0, delta_y = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
            delta_x = -2;
        else 
            if (Input.GetKeyDown(KeyCode.D))
                delta_x = 2;
        if (Input.GetKeyDown(KeyCode.W)) 
            delta_z = 2;
        else 
            if (Input.GetKeyDown(KeyCode.S))
                delta_z = -2;
        
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Menu");
        if (Input.GetKeyUp(KeyCode.A) && delta_x == -2 || Input.GetKeyUp(KeyCode.D) && delta_x == 2) 
            delta_x = 0;
        if (Input.GetKeyUp(KeyCode.S) && delta_z == -2 || Input.GetKeyUp(KeyCode.W) && delta_z == 2) 
            delta_z = 0;
        if (Input.GetKeyDown(KeyCode.Space) && this.transform.position.y < 0.26f)
            delta_y = 5;
        if (delta_y <= 0 || this.transform.position.y > 1f) {
            delta_y = 0;
        } else {
            delta_y = 5.2f - this.transform.position.y;
        }
        this.transform.position = new Vector3(this.transform.position.x + delta_x * Time.deltaTime, this.transform.position.y + delta_y * Time.deltaTime, this.transform.position.z + delta_z * Time.deltaTime);
    }
}
