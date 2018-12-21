# AR-Cooking-Simulator-regrub

## Objective
In this simulation, your goal is to create the food items designated by the cookbook. You will follow instructions layed out on the screen in order to do so. You will create the tools necessary for cooking these items, as well as work with ingredients. For example, a pineapple pizza would be created by combining pineapple, cheese, bread, and tomato on a platter, then cooking the combination with a stove.

## Modes
There are 2 different modes you may use for the cooking simulation.

1. Editor Mode: Simply press the play button in the Unity Editor, or build it to the standard plaform: PC, Mac, & Linux Standalone.

2. Augmented Reality (AR) Mode: This can be done by disabling the platform in the Unity Editor, then building to the Universal Windows Platform. A Microsoft HoloLens is required for this.

## Getting Started
Navigate to the scene to open the project. It can be found in the directory: `Regrub-AR-Cooking-Simulator\Assets\Scenes\regrub.unity`. Opening this file will bring you to the Unity Editor. You will have to make sure to have Unity installed in order to do so. From here, you may simply get started in Editor Mode by pressing the play button. You are also free to make modifications to the project while in Editor Mode. 

Alternatively, you have AR mode. Follow the instructions above, then build to UWP to a folder. It will create the file `regrub.sln`, which you will then open. Once there, make sure to have a Microsoft HoloLens ready, as well as it's address. With the solutions file opened, on the toolbar at the top, change the Configuration to "Debug" and the Platform to "x86". Build to a remote machine, insert the address of the HoloLens device, run the file, and wait for it to compile onto the device. After a while, the HoloLens will have build the project, and you can enjoy the simulation!

## Controls
In AR Mode, you will scan your environment to create a spatial map of your surroundings. This enables computer generated objects to interact with the real-life environment. Movement is done simply by moving around in the environment. Looking around is done by looking around in the environment. An airtap gesture allows you to interact with objects, such as moving them around, changing their size and orientation, or performing specific tasks.

In Editor Mode, a platform will exist to hold all objects. WASD/Arrow keys enable movement, and the mouse allows you to change your camera view. You may interact with objects by doing Shift + Left Click. 

## Project Features
*Spatial Mapping* – It will be used to create physical space that ingredients, the cookbook, and cooking items (e.g. table, bowl, stove, etc.) can reside in.

*Unity Physics* – The items will behave like normal items in the real world would (e.g. gravity).

*Bounding Boxes* – This will enable the user to pick up and move objects around, as well as rescale their size if needed.

*UI Interface* – This will be the primary way to spawn items, as well as the means for performing most tasks.

*Scripts* – Self-explanatory, need a way to determine if the user is creating a food item correctly, as well as allow interactions between objects and button functionality.

## Credits
This was made possible by the HoloToolkits addon for Unity, and assets from the Unity Store and free3d.com.