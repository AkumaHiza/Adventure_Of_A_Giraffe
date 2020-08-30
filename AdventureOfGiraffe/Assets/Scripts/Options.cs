using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public void Click_to_exit()
    {
           Application.Quit();
    }
         
    public void Start_change_scene(string scene_name)
    {
      SceneManager.LoadScene(scene_name);
    }

    public Image image;
 
    void Start() 
    {
       if(image != null) image.enabled = false;
    }
 
    public void Creators_click()
     {
       if(image != null) image.enabled = !image.enabled;
    }
}
