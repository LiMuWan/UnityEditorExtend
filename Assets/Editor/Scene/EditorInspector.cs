using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(ChangeInspectorInfo))]
public class EditorInspector : Editor
{
    bool groupEnable = false;
 
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        //让Inspector显示脚本组件的扩展字段
        ChangeInspectorInfo obj = (ChangeInspectorInfo)target;
        obj.Texture = EditorGUILayout.ObjectField("选择贴图", obj.Texture,
            typeof(Texture), true) as Texture;
        obj.Rect = EditorGUILayout.RectField("窗口坐标", obj.Rect);
        obj.Remark = EditorGUILayout.TextField("备注", obj.Remark);
        //绘制滑动条
        obj.SliderValue = EditorGUILayout.Slider("进度值", obj.SliderValue, 0f, 1f);
        obj.IsOpen = EditorGUILayout.Toggle("开启", obj.IsOpen);
        obj.Direction = (EDirection)EditorGUILayout.EnumPopup("方向", obj.Direction);

        EditorGUILayout.LabelField("********以下是附加设置********");
        groupEnable = EditorGUILayout.BeginToggleGroup("是否开启附加设置", groupEnable);
        obj.Value1 = EditorGUILayout.FloatField("value1", obj.Value1);
        obj.Value2 = EditorGUILayout.FloatField("value2", obj.Value2);
        obj.IsAdd = EditorGUILayout.Toggle("开启", obj.IsAdd);
        EditorGUILayout.EndToggleGroup();

    }
}
