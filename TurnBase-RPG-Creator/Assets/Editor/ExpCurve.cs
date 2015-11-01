﻿using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class ExpCurve : EditorWindow
{
    Formula curve;

    public void Init()
    {
        curve = new Formula();
    }

    void OnGUI()
    {        
        int i = 0;
        int graphHeight = curve.GetValue(Formula.MaxLevel) / 1000;

        foreach (var item in curve.GenerateCurve())
        {
            i++;

            GUI.Box(new Rect(i*10, graphHeight + 20, 10, -item/1000), "");
        }     
        
        EditorGUI.LabelField(new Rect(0, graphHeight + 60, 100, 20), "Base Value");
        curve.BaseValue = EditorGUI.IntSlider(new Rect(100, graphHeight + 60, 300, 20), curve.BaseValue, Formula.MinValue, Formula.MaxValue);

        EditorGUI.LabelField(new Rect(0, graphHeight + 80, 100, 20), "Extra Value");
        curve.ExtraValue = EditorGUI.IntSlider(new Rect(100, graphHeight + 80, 300, 20), curve.ExtraValue, Formula.MinValue, Formula.MaxValue);

        EditorGUI.LabelField(new Rect(0, graphHeight + 100, 100, 20), "Acceleration");
        curve.Acceleration = EditorGUI.IntSlider(new Rect(100, graphHeight + 100, 300, 20), curve.Acceleration, Formula.MinValue, Formula.MaxValue);

        for (i = 1; i <= Formula.MaxLevel; i = i+4)
        {
            EditorGUI.LabelField(new Rect(0, graphHeight + 120 + i*5, 300, 20), "Lv. " + i.ToString() + ": " + curve.GetValue(i) + " xp");
            EditorGUI.LabelField(new Rect(300, graphHeight + 120 + i*5, 300, 20), "Lv. " + (i+1).ToString() + ": " + curve.GetValue(i+1) + " xp");
            EditorGUI.LabelField(new Rect(600, graphHeight + 120 + i*5, 300, 20), "Lv. " + (i+2).ToString() + ": " + curve.GetValue(i+2) + " xp");

            if (i + 3 > 99)
                break;

            EditorGUI.LabelField(new Rect(900, graphHeight + 120 + i*5, 300, 20), "Lv. " + (i+3).ToString() + ": " + curve.GetValue(i+3) + " xp");
        }
    }

    void Update()
    {
        curve.UpdateValue();
    }
}