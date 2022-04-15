using System.Collections;
using UnityEngine;

public class BlackFadeIntro : MonoBehaviour
{
    public float fadeSpeed = 0.6f;
    private bool removeBlackScreen;

    void Start()
    {
        removeBlackScreen = false;
        StartCoroutine(RemoveBlackScreen());
    }

    IEnumerator RemoveBlackScreen()
    {
        yield return new WaitForSeconds(1);
        removeBlackScreen = true;
    }

    void Update()
    {
        if(removeBlackScreen)
        {
            Color c = gameObject.GetComponent<MeshRenderer>().material.color;
            if (c.a < 0)
                gameObject.SetActive(false);
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(c.r, c.g, c.b, c.a - fadeSpeed * Time.deltaTime);
            fadeSpeed += 0.35f * Time.deltaTime;
        }
    }
}
