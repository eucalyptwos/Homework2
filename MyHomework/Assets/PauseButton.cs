using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    private bool isClicked = false;
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void sumPauseButton()
    {
        isClicked = !isClicked;
        if (isClicked)
        {
            gameObject.GetComponent<Image>().sprite = sprites[0];
            Time.timeScale = 0;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = sprites[1];
            Time.timeScale = 1;
        }
	}
}
