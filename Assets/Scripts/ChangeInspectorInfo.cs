using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInspectorInfo : MonoBehaviour
{
    private Texture texture;
    private Rect rect;
    private string remark;
    private float sliderValue = 0.5f;
    private bool isOpen = true;
    private EDirection direction = EDirection.up;
    private float value1;
    private float value2;
    private bool isAdd;

    public Texture Texture
    {
        get { return texture; }
        set { texture = value; }
    }

    public Rect Rect
    {
        get { return rect; }
        set { rect = value; }
    }

    public string Remark
    {
        get { return remark; }
        set { remark = value; }
    }

    public float SliderValue
    {
        get { return sliderValue; }
        set { sliderValue = value; }
    }

    public bool IsOpen
    {
        get { return isOpen; }
        set { isOpen = value; }
    }

    public EDirection Direction
    {
        get { return direction; }
        set { direction = value; }
    }

    public float Value1
    {
        get { return value1; }
        set { value1 = value; }
    }

    public float Value2
    {
        get { return value2; }
        set { value2 = value; }
    }

    public bool IsAdd
    {
        get { return isAdd; }
        set { isAdd = value; }
    }
}

public enum EDirection
{
    up,
    down,
    left,
    right
}