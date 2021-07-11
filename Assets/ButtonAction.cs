using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using System.Threading;

public class ButtonAction : MonoBehaviour
{
    public VideoClip clip1;
    public VideoClip clip2;
    public GameObject world;
    public GameObject button1;
    public GameObject button2;
    public void changescene(){
        SceneManager.LoadScene("SampleScene");
    }

    public void showdance(){
        world.GetComponent<VideoPlayer>().clip = clip2;
        button1.SetActive(false);
        button2.SetActive(true);
    }
    public void showplace(){
        world.GetComponent<VideoPlayer>().clip = clip1;
        button1.SetActive(true);
        button2.SetActive(false);  
    }

}
