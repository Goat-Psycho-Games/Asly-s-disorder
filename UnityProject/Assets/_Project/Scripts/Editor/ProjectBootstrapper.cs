using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

namespace AslysDisorder.EditorTools
{
    public static class ProjectBootstrapper
    {
        private const string SettingsPath = "Assets/_Project/Settings";
        private const string ScenesRoot = "Assets/_Project/Scenes";
        private const string RenderPipelineAssetPath = SettingsPath + "/AslysDisorder_URP.asset";
        private const string Renderer2DDataPath = SettingsPath + "/AslysDisorder_2DRenderer.asset";

        [MenuItem("Asly's Disorder/Bootstrap Project")]
        public static void BootstrapProject()
        {
            EnsureDirectories();
            ConfigureRenderPipeline();
            CreateBaseScenes();
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private static void EnsureDirectories()
        {
            EnsureDirectory("Assets/_Project/Scripts/Editor");
            EnsureDirectory(SettingsPath);
            EnsureDirectory(ScenesRoot + "/Boot");
            EnsureDirectory(ScenesRoot + "/MainMenu");
            EnsureDirectory(ScenesRoot + "/Prototypes");
        }

        private static void ConfigureRenderPipeline()
        {
            var asset = AssetDatabase.LoadAssetAtPath<UniversalRenderPipelineAsset>(RenderPipelineAssetPath);
            if (asset == null)
            {
                asset = UniversalRenderPipelineAsset.Create();
                AssetDatabase.CreateAsset(asset, RenderPipelineAssetPath);
            }

            var rendererData = AssetDatabase.LoadAssetAtPath<Renderer2DData>(Renderer2DDataPath);
            if (rendererData == null)
            {
                rendererData = ScriptableObject.CreateInstance<Renderer2DData>();
                AssetDatabase.CreateAsset(rendererData, Renderer2DDataPath);
            }

            AssignDefaultRenderer(asset, rendererData);
            GraphicsSettings.defaultRenderPipeline = asset;
            QualitySettings.renderPipeline = asset;
        }

        private static void AssignDefaultRenderer(UniversalRenderPipelineAsset asset, ScriptableRendererData rendererData)
        {
            var serializedAsset = new SerializedObject(asset);
            var rendererDataList = serializedAsset.FindProperty("m_RendererDataList");
            if (rendererDataList != null)
            {
                rendererDataList.arraySize = Mathf.Max(rendererDataList.arraySize, 1);
                rendererDataList.GetArrayElementAtIndex(0).objectReferenceValue = rendererData;
            }

            var defaultRendererIndex = serializedAsset.FindProperty("m_DefaultRendererIndex");
            if (defaultRendererIndex != null)
            {
                defaultRendererIndex.intValue = 0;
            }

            serializedAsset.ApplyModifiedPropertiesWithoutUndo();
            EditorUtility.SetDirty(asset);
        }

        private static void CreateBaseScenes()
        {
            var boot = CreateSceneIfMissing(
                ScenesRoot + "/Boot/Boot.unity",
                "Boot",
                includeCamera: false);

            var mainMenu = CreateSceneIfMissing(
                ScenesRoot + "/MainMenu/MainMenu.unity",
                "MainMenu",
                includeCamera: true);

            var prototype = CreateSceneIfMissing(
                ScenesRoot + "/Prototypes/Prototype_M1.unity",
                "Prototype_M1",
                includeCamera: true);

            EditorBuildSettings.scenes = new[]
            {
                new EditorBuildSettingsScene(boot, true),
                new EditorBuildSettingsScene(mainMenu, true),
                new EditorBuildSettingsScene(prototype, true)
            };
        }

        private static string CreateSceneIfMissing(string path, string rootName, bool includeCamera)
        {
            if (File.Exists(path))
            {
                return path;
            }

            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            scene.name = rootName;

            _ = new GameObject(rootName + "_Root");

            if (includeCamera)
            {
                var cameraObject = new GameObject("Main Camera");
                var camera = cameraObject.AddComponent<Camera>();
                camera.orthographic = true;
                camera.orthographicSize = 5f;
                camera.backgroundColor = new Color(0.08f, 0.08f, 0.09f);
                camera.tag = "MainCamera";
            }

            EditorSceneManager.SaveScene(scene, path);
            return path;
        }

        private static void EnsureDirectory(string path)
        {
            if (!AssetDatabase.IsValidFolder(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
