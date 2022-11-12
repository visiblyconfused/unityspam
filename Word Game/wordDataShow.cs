using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using System;

[CustomEditor(inspectedType: typeof(Board),editorForChildClasses:false)]
[CanEditMultipleObjects]
[System.Serializable]
public class wordDataShow : Editor
{
    private Board GameDataInstance => target as Board;
    private ReorderableList _dataList;

    private void OnEnable()
    {
        throw new NotImplementedException();
    }
 
}
