using UnityEditor;
using System.IO;
public class SetFirstFolder : EditorWindow
{
    [MenuItem("Custom/CreateFolder")]
    static void CreateFolder()  //FolderName("フォルダ名");　で新しいフォルダ追加可能
    {

        if (AssetDatabase.IsValidFolder("Assets/CommonFolder"))
        {
            return;
        }

        FolderName("Animations");
        FolderName("AnimatorControllers");
        FolderName("Editors");
        FolderName("Textures");
        FolderName("Materials");
        FolderName("Prefabs");
        FolderName("Resources");
        FolderName("RenderTextures");
        FolderName("Scripts");
        FolderName("Scenes");
        FolderName("Shaders");

    }


    static void FolderName(string folderName)
    {
        string path = "Assets/" + folderName;

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        AssetDatabase.ImportAsset(path);
    }
}