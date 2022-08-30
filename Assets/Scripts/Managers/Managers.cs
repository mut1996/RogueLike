using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instnace;
    private static Managers Instance { get { Init(); return s_instnace; } }




    private static void Init() 
    {
        if (s_instnace == null) 
        {
            GameObject go = GameObject.Find("@Managers");

            if (go == null) 
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instnace = go.GetComponent<Managers>();
        
        }
        
        
    } 
}
