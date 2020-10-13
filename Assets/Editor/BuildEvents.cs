using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;


public class BuildSteps : IPreprocessBuildWithReport
{
    public int callbackOrder { get { return 0; } }
    public void OnPreprocessBuild(BuildReport report)
    {
        
#if UNITY_EDITOR
        Debug.Log("Building with UNITY_EDITOR");
#endif


#if UNITY_ANDROID
        Debug.Log("Building with UNITY_ANDROID");
#endif


#if UNITY_CLOUD_BUILD
        Debug.Log("Building with UNITY_CLOUD_BUILD");
#endif


#if UNITY_EDITOR_LINUX
        Debug.Log("Building with UNITY_EDITOR_LINUX");
#endif


#if UNITY_STANDALONE_LINUX
        Debug.Log("Building with UNITY_STANDALONE_LINUX");
#endif


#if UNITY_EDITOR_WIN
        Debug.Log("Building with UNITY_EDITOR_WIN");
#endif


#if UNITY_STANDALONE_WIN
        Debug.Log("Building with UNITY_STANDALONE_WIN");
#endif


#if UNITY_STANDALONE
        Debug.Log("Building with UNITY_STANDALONE");
#endif
    }
}