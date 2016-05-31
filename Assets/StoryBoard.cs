using UnityEngine;
using System.Collections;

public class StoryBoard : MonoBehaviour
{

    public GameObject particle;
    public GameObject face;
    public GameObject bat;
    public GameObject word;

    float[] timeArray = new float[] { 4, 6, 8, 10, 12 };

    int index;
    bool canClick;

    // Use this for initialization
    void Start()
    {
        particle.SetActive(false);
        face.SetActive(false);
        bat.SetActive(false);
        word.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //realtimeSinceStartup 开始到目前的时间秒数
        if (index < timeArray.Length && Time.realtimeSinceStartup > timeArray[index])
        {
            OnTime(index);
            index++;
        }
        if (canClick && Input.GetMouseButtonUp(0))
        {
            word.SetActive(true);
        }
    }

    private void OnTime(int index)
    {
        switch (index)
        {
            case 0:
                particle.SetActive(true);
                break;
            case 1:
                bat.SetActive(true);
                break;
            case 2:
                face.SetActive(true);
                break;
            case 3:
                face.GetComponent<AudioSource>().Play();
                break;
            case 4:
                canClick = true;
                break;
            default:
                break;
        }
    }
}
