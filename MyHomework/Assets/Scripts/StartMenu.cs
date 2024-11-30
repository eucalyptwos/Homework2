using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Confined;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton()
    {
		SceneManager.LoadScene("SampleScene");
	}
    public void ExitButton()
    {
        Application.Quit();
	}
}
