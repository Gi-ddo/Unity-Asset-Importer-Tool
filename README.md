# Unity Asset Importer Tool
 A Unity Editor Tool that can change the import settings of assets when they are newly added to specific folders. The tool can run and apply the necessary changes to existing assets.

# Tool Features
- Ability to change the maximum texture size and anisotropic filtering level for
texture assets.(Ability to optionally override the texture size for the Android platform.)

- Ability to change the sample rate, compression format and load type of audio clip
assets.(Ability to optionally override these settings for the Android platform.)

# How to use
-The tool has a  configurable scriptable asset that will be used to configure the import settings of assets.

- You need to create an instance of the scriptable asset by navigating to Assets > Create > ImportConfig.
After creating it give it a suitable name it will be inside the asset folder.

- By clicking on the assset you will be able to see the different import settings on the inspector and an apply button to save changes made.

-After clicking apply you will recieve some feedback on the console "Import Settinngs applied". This means the settings have been successfully set.
The import settings will be applied to every texture and audioclip asset imported into the "SampleAssets" folder.

- Below I will provide a link to some example assets that can be used to test the tool's functionality.

https://drive.google.com/file/d/1xN1CzxyF-7GjcqH-Y8gs8f8BPnH4ZKCg/view?usp=sharing

# Future Improvements
- The tool has one flaw that I was not able to resolve in time. The tool does not automatically update assets that  already exist inside unity.
To update the settings to those set by the tool, the user will have to reimport the asset by choosing the reimport option when they right click on the respective asset.

 Examples of these include:
-After an initial import the import settings will apply within the respective folder("SampleAssets), however if a user desires to change the current settings they would have to apply the settings and reimport the asset inside the same folder.

-If an assets exists outside the "SampleAssets" folder, if the asset is moved to the "SampleAssets" folder they would have to reimport the asset to update the import settings to those set by the tool.

- How I plan to fix this?

I need to figure out a way to let Unity Know that an asset has been modified. To do this in Unity you need to set the target object to dirty, once it has been set to dirty
every time a user clicks on the apply button the button needs to be able to save and reimport the modified asset import settings to existing assets inside the target folder.
This approach will allow the assets to automatically update inside the target folder after a manual change to the tool's settings.







