using UnityEngine;

public class TitleText : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            switch (gameObject.name)
            {
                case "ViewOrbits":
                    GameObject.Find("GameManager").GetComponent<GameManager>().GoToOrbitsSection();
                    break;
                case "CompareSizes":
                    GameObject.Find("GameManager").GetComponent<GameManager>().GoToSizesSection();
                    break;
                case "Infos":
                    GameObject.Find("GameManager").GetComponent<GameManager>().ShowInfosMenu();
                    break;
                case "Quit":
                    Application.Quit();
                    break;
            }
        }
    }
}
