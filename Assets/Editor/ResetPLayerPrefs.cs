using UnityEditor;
using UnityEngine;

public class PlayerPrefsTools
{
    [MenuItem("Tools/Reset PlayerPrefs")]
    public static void ResetPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("PlayerPrefs reseteados");
    }
}
