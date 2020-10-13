using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviour
{
    private void OnGUI()
    {
#if UNITY_EDITOR
        GUI.Label(new Rect(10, 10, 400, 20), "UNITY_EDITOR");
#endif


#if UNITY_ANDROID
        GUI.Label(new Rect(10, 22, 400, 20), "UNITY_ANDROID ");
#endif


#if UNITY_CLOUD_BUILD
        GUI.Label(new Rect(10, 34, 400, 20), "UNITY_CLOUD_BUILD");
#endif


#if UNITY_EDITOR_LINUX
        GUI.Label(new Rect(10, 46, 400, 20), "UNITY_EDITOR_LINUX");
#endif


#if UNITY_STANDALONE_LINUX
        GUI.Label(new Rect(10, 58, 400, 20), "UNITY_STANDALONE_LINUX");
#endif


#if UNITY_EDITOR_WIN
        GUI.Label(new Rect(10, 70, 400, 20), "UNITY_EDITOR_WIN");
#endif


#if UNITY_STANDALONE_WIN
        GUI.Label(new Rect(10, 82, 400, 20), "UNITY_STANDALONE_WIN");
#endif


#if UNITY_STANDALONE
        GUI.Label(new Rect(10, 94, 400, 20), "UNITY_STANDALONE");
#endif
    }
}
