using UnityEngine;
using System;
using System.Reflection;

public static class Clipboard
{
    public static PropertyInfo _systemCopyBufferProperty = null;
    public static PropertyInfo GetSystemCopyBufferProperty()
    {
        if (_systemCopyBufferProperty == null)
        {
            _systemCopyBufferProperty = typeof(GUIUtility).GetProperty("systemCopyBuffer", BindingFlags.Static | BindingFlags.NonPublic);
            if (_systemCopyBufferProperty == null)
                throw new Exception("Нет доступа к 'GUIUtility.systemCopyBuffer'. Возможно он удален или переименован");
        }
        return _systemCopyBufferProperty;
    }

    public static string GetAsString()
    {
        return (string)GetAsObject();
    }

    public static object GetAsObject()
    {
        return GetSystemCopyBufferProperty().GetValue(null, null);
    }

    public static void Set(object value)
    {
        GetSystemCopyBufferProperty().SetValue(null, value, null);
    }
}