using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSizesLabels : MonoBehaviour
{
	private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            gameManager.ToggleSizesLabels();
        }
    }
}
