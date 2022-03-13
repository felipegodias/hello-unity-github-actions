using System.IO;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public static class HelloUnityBuilder
{
    [MenuItem("Build/iOS")]
    public static void BuildIOS()
    {
        Debug.Log("Called!");

        string locationPathName = Path.Combine(Path.GetDirectoryName(Application.dataPath), "Builds", "iOS");
        
        
        var buildPlayerOptions = new BuildPlayerOptions
        {
            target = BuildTarget.iOS,
            targetGroup = BuildTargetGroup.iOS,
            locationPathName = locationPathName,
            options = BuildOptions.Development
        };
        
        BuildReport buildReport = BuildPipeline.BuildPlayer(buildPlayerOptions);
        Debug.Log($"locationPathName: {locationPathName}");
        Debug.Log($"result: {buildReport.summary.result}");
    }
}