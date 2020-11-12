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
    public NavigationScript navigation;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            navigation.LoadScene("Gameplay");
        }
    }

    IEnumerator Timer()
    {
        for (int i = 10; i >= 0; i--)
        {
            timer.text = "00:00:0" + i;
            yield return new WaitForSeconds(1);
        }
        yield return new WaitForSeconds(25);
        navigation.LoadScene("Gameplay");
        //director.Play();
    }
}
