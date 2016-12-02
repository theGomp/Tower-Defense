﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

   
	public void Play(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Quit() //When you press Quit, this quits Unity.
    {
       
        Application.Quit();
    }


}
