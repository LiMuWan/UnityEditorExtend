using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(ChangeObjInfo))]
public class EditorScene : Editor
{
    private void OnSceneGUI()
    {
        ChangeObjInfo obj = (ChangeObjInfo)target;//获取脚本对象
        Handles.Label(obj.transform.position + Vector3.up, obj.name + ":" +
            obj.transform.position.ToString());
        //开始绘制GUI 要在Handles里面绘制2dUI必须加beginGUI
        Handles.BeginGUI();
        GUILayout.BeginArea(new Rect(0, 0, 150, 200));//规定GUI显示的区域
        GUILayout.Label("选择颜色");
        GUI.color = Color.red;
        if(GUILayout.Button("红色"))
        {
            obj.GetComponent<Renderer>().sharedMaterial.color = Color.red;
        }
        GUI.color = Color.green;
        if(GUILayout.Button("绿色"))
        {
            obj.GetComponent<Renderer>().sharedMaterial.color = Color.green;
        }
        GUI.color = Color.blue;
        if(GUILayout.Button("蓝色"))
        {
            obj.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
        }

        Handles.Label(obj.transform.position + Vector3.up, obj.name + ":" +
            obj.transform.position.ToString());
        GUILayout.EndArea();
        Handles.EndGUI();
    }
}
