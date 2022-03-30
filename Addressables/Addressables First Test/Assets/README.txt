- How to instantiate a GO by asset reference:
		1- Create or use a group
		2- Create a gameobject
		3- Turn it into addressables by checking the addressables checkbox or by dragging it to a group.		
		4- Create a script to intantiate the GO
		5- Drag it to the group
		6- Use the namespace: 
			using UnityEngine.AddressableAssets;
		7- Create a serializableField to hold the addressable reference:
			[SerializeField] AssetReferenceGameObject myObject;
		8- Create a method to call/spawn the addressable:
			public void AddressablePrefab()
			{
				Addressables.InstantiateAsync(myObject);
			}
		9- Drag the object to the myObject field on the script.
		10- Call this method from some place. In this tut we are calling from a button in the canvas.
	

- How to load a scene by asset reference?
		1- create or use a group
		2- Create a scene
		3- Turn it into addressables by checking the addressables checkbox or by dragging it to a group.
		4- Drag it to the group
		5- Create a script to intantiate the scene
		6- Use the namespace: 
			using UnityEngine.AddressableAssets;
		7- Create a serializableField to hold the addressable reference:
			[SerializeField] AssetReference myScene;
		8- Create a method to call/spawn the addressable:
			public void AddressablesScene()
			{
				myScene.LoadSceneAsync(UnityEngine.SceneManagement.LoadSceneMode.Additive);
			}
		9- Drag the scene to the myScene field on the script.
		10- Call this method from some place. In this tut we are calling from a button in the canvas.

- How to load a sprite by asset reference?
		1- create or use a group
		2- Create a sprite
		3- Turn it into addressables by checking the addressables checkbox or by dragging it to a group.
		4- Drag it to the group
		5- Create a script to intantiate the sprite
		6- Use the namespace: 
			using UnityEngine.ResourceManagement.AsyncOperations;
		7- Create a reference to a UI Image component:
			[SerializeField] Image image; //This is the gameobject on the canvas in this case.
		8- Create a serializableField to hold the addressable reference:
			[SerializeField] AssetReferenceSprite mySprite;
		9- Create a method to call/spawn the addressable:
			public void AddressablesSprite()
			{
				mySprite.LoadAssetAsync().Completed += OnSpriteLoaded;
			}
			void OnSpriteLoaded(AsyncOperationHandle<Sprite> handle)
			{
				image.sprite = handle.Result;
			}
		9- Drag the image to the image field on the script.
		9- Drag the sprite to the mySprite field on the script.
		10- Call this method from some place. In this tut we are calling from a button in the canvas.