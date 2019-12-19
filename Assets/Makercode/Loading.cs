﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Loading : MonoBehaviour
{
    GameObject obj, prefab1, prefab2, prefab3;
    // Start is called before the first frame update
    void Start()
    {
        prefab1 = GameObject.Find("New Sprite (1)");
        prefab2 = GameObject.Find("New Sprite (2)");
        prefab3 = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Button()
    {
        StreamReader F = new StreamReader("E:\\github\\Client\\names.txt");
        string str = F.ReadLine();
        while(str != null)
        {
            string[] split = str.Split(new char[] { ' ', '\n' });
            int type = int.Parse(split[0]);
            float x = float.Parse(split[1]);
            float y = float.Parse(split[2]);
            float z = float.Parse(split[3]);
            if (type == 1)
            {
                obj = Instantiate(prefab1) as GameObject;
            }
            else if (type == 2)
            {
                obj = Instantiate(prefab2) as GameObject;
            }
            else if (type == 3)
            {
                obj = Instantiate(prefab3) as GameObject;
            }
            obj.transform.position = new Vector3(x, y, z);
            str = F.ReadLine();
        }
        F.Close();
    }
}
