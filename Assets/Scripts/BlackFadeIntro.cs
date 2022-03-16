using UnityEngine;

public class BlackFadeIntro : MonoBehaviour
{

    // Update is called once per frame
    public float fadeSpeed = 0.6f;
    void Update()
    {
        Color c = gameObject.GetComponent<MeshRenderer>().material.color;
        if (c.a < 0)
            gameObject.SetActive(false);
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(c.r, c.g, c.b, c.a - fadeSpeed * Time.deltaTime);
        fadeSpeed += 0.35f * Time.deltaTime;
    }
}
