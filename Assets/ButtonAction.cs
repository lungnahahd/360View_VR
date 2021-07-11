using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ButtonAction : MonoBehaviour
{
    public VideoClip clip1;
    public VideoClip clip2;
    public GameObject world;
    public void changescene(){
        SceneManager.LoadScene("SampleScene");
    }

    public void showdance(){
        world.GetComponent<VideoPlayer>().clip = clip2;

    }
    public void showplace(){
        world.GetComponent<VideoPlayer>().clip = clip1;
    }

}
