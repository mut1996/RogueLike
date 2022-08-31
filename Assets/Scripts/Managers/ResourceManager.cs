using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager 
{
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }


    public GameObject Instantiate(string path, Transform parent = null) 
    {
        GameObject orignal = Load<GameObject>($"Prefabs/{path}");

        if (orignal == null) 
        {
            Debug.Log($"Failed to laod Prefabs : {path}");
            return null;
        }

        GameObject go = Object.Instantiate(orignal, parent);

       
        go.name = orignal.name;
        return go; 
    }


    public void Destroy(GameObject go) 
    {
        if (go == null)
            return;

        Object.Destroy(go);
    }
        
}
