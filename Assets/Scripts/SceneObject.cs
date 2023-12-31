using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Always enable the gaze cursor
        PointerUtils.SetGazePointerBehavior(PointerBehavior.AlwaysOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSceneSwitch(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void OnKeywordQuit()
    {
        Application.Quit();
    }
}
