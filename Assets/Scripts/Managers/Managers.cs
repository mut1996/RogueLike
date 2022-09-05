using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instnace;
    private static Managers Instance { get { Init(); return s_instnace; } }

    private ResourceManager _resource = new ResourceManager();
    private InputManager _input = new InputManager();
   

    
    public static ResourceManager Resource { get { return Instance._resource; }}
    public static InputManager Input { get { return Instance._input; } }



    private void Start()
    {
        Init();
    }

    private void Update()
    {
        _input.OnUpdate();
    }

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
