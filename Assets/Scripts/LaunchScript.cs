/*
 * Script for controlling events within the scene
 * Main Editor: Shawn Grant
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;

public class LaunchScript : MonoBehaviour
{
    public TextMeshProUGUI timer;
    PlayableDirector director;

    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        for (int i = 10; i >= 0; i--)
        {
            timer.text = "00:00:0" + i;
            yield return new WaitForSeconds(1);
        }

        
        //director.Play();
    }
}
