using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressablesManager : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] AssetReferenceGameObject myObject;
    [SerializeField] AssetReference myScene;
    [SerializeField] AssetReferenceSprite mySprite;

    public void AddressablesPrefab()
    {
        Addressables.InstantiateAsync(myObject);
    }

    public void AddressablesScene()
    {
        myScene.LoadSceneAsync(UnityEngine.SceneManagement.LoadSceneMode.Additive);
    }

    public void AddressablesSprite()
    {
        mySprite.LoadAssetAsync().Completed += OnSpriteLoaded;
    }

    void OnSpriteLoaded(AsyncOperationHandle<Sprite> handle)
    {
        image.sprite = handle.Result;
    }

}
