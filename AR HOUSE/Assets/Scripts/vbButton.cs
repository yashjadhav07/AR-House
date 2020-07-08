using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;
public class vbButton : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject[] myButtons;
    public GameObject confirmPanel;
    public GameObject videoPlane;
    private bool isVideoPlaying=false;
    public static VideoPlayer video;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < myButtons.Length; i++)
        {
            myButtons[i].GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        }
        video=videoPlane.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.name=="buttonT3")
        {
            confirmPanel.SetActive(true);
        }
        if (vb.name == "buttonT1Start" && isVideoPlaying==false)
        {
            video.Play();
            isVideoPlaying = true;
        }

        if (vb.name == "buttonT1Stop" && isVideoPlaying == true)
        {
            video.Stop();
            isVideoPlaying = false;
        }
        if(vb.name=="removeRoof")
        {
            vb.gameObject.SetActive(false);
            myButtons[4].SetActive(true);
            houseScript.instance.toggleRoof();
        }
        if (vb.name == "replaceRoof")
        {
            vb.gameObject.SetActive(false);
            myButtons[3].SetActive(true);
            houseScript.instance.toggleRoof();
        }
        if(vb.name=="removeSecondFloor")
        {
            vb.gameObject.SetActive(false);
            myButtons[6].SetActive(true);
            houseScript.instance.toggleSecondFloor();
        }
        if (vb.name == "replaceSecondFloor")
        {
            vb.gameObject.SetActive(false);
            myButtons[5].SetActive(true);
            houseScript.instance.toggleSecondFloor();
        }
        if(vb.name=="Daytime")
        {
            vb.gameObject.SetActive(false);
            myButtons[8].SetActive(true);
            houseScript.instance.toggleLights();
        }
        if (vb.name == "Nightime")
        {
            vb.gameObject.SetActive(false);
            myButtons[7].SetActive(true);
            houseScript.instance.toggleLights();
        }
        if(vb.name=="openGarage")
        {
            vb.gameObject.SetActive(false);
            myButtons[10].SetActive(true);
            houseScript.instance.toggleGarage();
        }
        if (vb.name == "closeGarage")
        {
            vb.gameObject.SetActive(false);
            myButtons[9].SetActive(true);
            houseScript.instance.toggleGarage();
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}
