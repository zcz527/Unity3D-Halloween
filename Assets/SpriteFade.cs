using UnityEngine;
using System.Collections;

public class SpriteFade : MonoBehaviour
{

    public float Duration = 2.0f;
    float elapse;
    // Use this for initialization
    void Start()
    {
        SetAlpha(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (elapse < Duration)
        {
            elapse += Time.deltaTime;
            SetAlpha(elapse / Duration);
        }
    }

    void SetAlpha(float a)
    {
        var sp = GetComponent<SpriteRenderer>();
        var c = sp.color;
        c.a = a;
        sp.color = c;
    }
}
