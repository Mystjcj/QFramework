﻿using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace QFramework
{
    public class OpenInFolder
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/5.打开文件夹")]
        private static void MenuClicked()
        {
            Application.OpenURL("file:///" + Application.dataPath);
        }
#endif
    }

}