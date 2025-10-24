using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public class PlayModeStartScene
{
    private const string MENU_PATH = "Tools/Always Start From First Scene";
    private const string PREF_KEY = "AlwaysStartFromFirstScene";

    static PlayModeStartScene()
    {
        EditorApplication.playModeStateChanged += OnPlayModeChanged;
    }

    [MenuItem(MENU_PATH)]
    private static void ToggleStartScene()
    {
        bool isEnabled = EditorPrefs.GetBool(PREF_KEY, true);
        EditorPrefs.SetBool(PREF_KEY, !isEnabled);
    }

    [MenuItem(MENU_PATH, true)]
    private static bool ToggleStartSceneValidate()
    {
        Menu.SetChecked(MENU_PATH, EditorPrefs.GetBool(PREF_KEY, true));
        return true;
    }

    private static void OnPlayModeChanged(PlayModeStateChange state)
    {
        // Özellik kapalıysa çık
        if (!EditorPrefs.GetBool(PREF_KEY, true))
            return;

        if (state == PlayModeStateChange.ExitingEditMode)
        {
            // Build Settings'de sahne var mı kontrol et
            if (EditorBuildSettings.scenes.Length == 0)
            {
                Debug.LogWarning("Build Settings'de sahne yok!");
                return;
            }

            string firstScenePath = EditorBuildSettings.scenes[0].path;
            string currentScenePath = EditorSceneManager.GetActiveScene().path;

            // Zaten ilk sahnedeyse bir şey yapma
            if (currentScenePath == firstScenePath)
                return;

            // Değişiklikleri kaydet
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();

            // İlk sahneyi aç
            EditorSceneManager.OpenScene(firstScenePath);
        }
    }
}