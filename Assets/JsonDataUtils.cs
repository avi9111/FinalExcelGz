using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonDataUtils
{
    public static List<ExcelTask> ReadJson()
    {
        //var reader = new LitJson.JsonReader();
        
        var text = Resources.Load<TextAsset>("Excel2Json/tasks");
        var tasks = JsonUtility.FromJson<List<ExcelTask>>(text.text);
        Debug.LogError("tasks count=" + tasks.Count);
        return tasks;
    }
}
