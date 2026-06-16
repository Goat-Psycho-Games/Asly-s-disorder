using System.IO;
using AslysDisorder.Player;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AslysDisorder.EditorTools
{
    public static class PrototypeGameplayBootstrapper
    {
        private const string PrototypeScenePath = "Assets/_Project/Scenes/Prototypes/Prototype_M1.unity";
        private const string PlayerSpritePath = "Assets/_Project/Art/Characters/PrototypePlayer.png";
        private const string PlayerPrefabPath = "Assets/_Project/Prefabs/Player/PrototypePlayer.prefab";

        [MenuItem("Asly's Disorder/Bootstrap Prototype Gameplay")]
        public static void BootstrapPrototypeGameplay()
        {
            EnsurePrototypePlayerSprite();
            GameObject playerPrefab = EnsurePrototypePlayerPrefab();
            EnsurePrototypeScene(playerPrefab);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private static void EnsurePrototypePlayerSprite()
        {
            if (AssetDatabase.LoadAssetAtPath<Sprite>(PlayerSpritePath) != null)
            {
                return;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(PlayerSpritePath) ?? string.Empty);

            var texture = new Texture2D(32, 48, TextureFormat.RGBA32, false);
            var transparent = new Color32(0, 0, 0, 0);
            var coat = new Color32(68, 78, 92, 255);
            var face = new Color32(214, 176, 142, 255);
            var accent = new Color32(134, 42, 63, 255);

            for (int y = 0; y < texture.height; y++)
            {
                for (int x = 0; x < texture.width; x++)
                {
                    texture.SetPixel(x, y, transparent);
                }
            }

            Fill(texture, 10, 8, 22, 35, coat);
            Fill(texture, 11, 34, 21, 44, face);
            Fill(texture, 8, 38, 23, 46, accent);
            Fill(texture, 13, 4, 16, 8, coat);
            Fill(texture, 17, 4, 20, 8, coat);
            texture.Apply();

            File.WriteAllBytes(PlayerSpritePath, texture.EncodeToPNG());
            Object.DestroyImmediate(texture);
            AssetDatabase.ImportAsset(PlayerSpritePath, ImportAssetOptions.ForceSynchronousImport);

            var importer = (TextureImporter)AssetImporter.GetAtPath(PlayerSpritePath);
            importer.textureType = TextureImporterType.Sprite;
            importer.spritePixelsPerUnit = 32f;
            importer.filterMode = FilterMode.Point;
            importer.textureCompression = TextureImporterCompression.Uncompressed;
            importer.SaveAndReimport();
        }

        private static GameObject EnsurePrototypePlayerPrefab()
        {
            GameObject existingPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(PlayerPrefabPath);
            if (existingPrefab != null)
            {
                return existingPrefab;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(PlayerPrefabPath) ?? string.Empty);

            Sprite sprite = AssetDatabase.LoadAssetAtPath<Sprite>(PlayerSpritePath);
            var player = new GameObject("PrototypePlayer");
            var spriteRenderer = player.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
            spriteRenderer.sortingOrder = 10;

            var body = player.AddComponent<Rigidbody2D>();
            body.bodyType = RigidbodyType2D.Dynamic;
            body.gravityScale = 0f;
            body.freezeRotation = true;

            var collider = player.AddComponent<BoxCollider2D>();
            collider.size = new Vector2(0.55f, 1.2f);
            collider.offset = new Vector2(0f, 0.6f);

            player.AddComponent<PlayerSideMovement>();

            GameObject prefab = PrefabUtility.SaveAsPrefabAsset(player, PlayerPrefabPath);
            Object.DestroyImmediate(player);
            return prefab;
        }

        private static void EnsurePrototypeScene(GameObject playerPrefab)
        {
            Scene scene = EditorSceneManager.OpenScene(PrototypeScenePath, OpenSceneMode.Single);

            GameObject player = GameObject.Find("PrototypePlayer");
            if (player == null)
            {
                player = (GameObject)PrefabUtility.InstantiatePrefab(playerPrefab, scene);
                player.name = "PrototypePlayer";
            }

            player.transform.position = Vector3.zero;

            Camera camera = Camera.main;
            if (camera == null)
            {
                var cameraObject = new GameObject("Main Camera");
                camera = cameraObject.AddComponent<Camera>();
                cameraObject.tag = "MainCamera";
            }

            camera.transform.position = new Vector3(0f, 0.75f, -10f);
            camera.orthographic = true;
            camera.orthographicSize = 4f;
            camera.clearFlags = CameraClearFlags.SolidColor;
            camera.backgroundColor = new Color(0.08f, 0.08f, 0.09f);

            EnsureGround(scene);
            EditorSceneManager.MarkSceneDirty(scene);
            EditorSceneManager.SaveScene(scene);
        }

        private static void EnsureGround(Scene scene)
        {
            GameObject ground = GameObject.Find("PrototypeGround");
            if (ground == null)
            {
                ground = new GameObject("PrototypeGround");
                SceneManager.MoveGameObjectToScene(ground, scene);
                ground.AddComponent<BoxCollider2D>();
            }

            ground.transform.position = new Vector3(0f, -0.15f, 0f);
            ground.transform.localScale = new Vector3(9f, 0.2f, 1f);
        }

        private static void Fill(Texture2D texture, int minX, int minY, int maxX, int maxY, Color32 color)
        {
            for (int y = minY; y < maxY; y++)
            {
                for (int x = minX; x < maxX; x++)
                {
                    texture.SetPixel(x, y, color);
                }
            }
        }
    }
}
