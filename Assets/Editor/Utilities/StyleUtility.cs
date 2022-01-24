using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public static class StyleUtility
{
    public static VisualElement AddStyleSheets(this VisualElement element, params string[] styleSheetNames)
    {
        foreach (string styleSheetName in styleSheetNames)
        {
            StyleSheet styleSheet = (StyleSheet)EditorGUIUtility.Load(styleSheetName);
            element.styleSheets.Add(styleSheet);
        }

        return element;
    }
}
