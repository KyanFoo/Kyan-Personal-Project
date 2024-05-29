README on how the my personal "Final_Dissolve" Shader/

----------------- References from various "Dissolve Shader" Links -----------------
1. Dissolve#1: DISSOLVE using Unity Shader Graph (Brackeys)
- Using the "Time Node" to simulate the dissolve motion of the GameObject is a nice idea. WIth just a click of a button, the GameObject will dissolve like putting on a camoflauge, but i don't know how to control it. (Keep this idea)

2. Dissolve#2: Dissolve Effect in Unity Shader Graph (Daniel Ilett)
- This shader does not the components that i need.

3. Dissolve#3: How to Make a Dissolve Shader Unity (Updated 2023) (Rigor Mortis Tortoise)
- This shader does not the components that i need, it too simple.

4. Dissolve#4: Easy Dissolve Shader for Unity Tutorial (supports Emission maps) (The Game Dev Cave)
- Using the "Texture2D Node" to place the material textures onto the GameObject.
- Copy the nodes of how they get the dissolve edge for the Shader Graph.

5. Dissolve#5: Unity Shader graph - Dissolve Effect Tutorial (Unity Magic)
- Using the "Time Node" to simulate the dissolve motion of the GameObject is a nice idea. WIth just a click of a button, the GameObject will dissolve like putting on a camoflauge, but i don't know how to control it. (Keep this idea)

6. Dissolve#6: Dissolve effect in Shader Graph (PabloMakes)
- Using the "Texture2D Node" to place the material textures onto the GameObject.

7. How to Scale Texture in Unity using Shader Graph (Vikings Devlogs)
- Integrate the "Tiling and Offset" node into the simple noise nodes.


Shader Graphs Nodes:
----------------- Textures -----------------
Albedo Texture (Texture2D):
Albedo Texture node is for applying the Albedo Texture to the GameObject.

Normal Texture (Texture2D):
Normal Texture node is for applying the Normal Texture to the GameObject.

Metallic Texture (Texture2D):
Metallic Texture node is for applying the Metallic Texture to the GameObject.

Emission Texture (Texture2D):
Emission Texture node is for applying the Emission Texture to the GameObject.

Smoothness (Float):
Smoothness node is used to controls the smoothness of the texture, enabling the GameObject to have a reflective surface.


----------------- Noise Controls -----------------
Base Color (Color):
Base Color node is used to change base color of the GameObject.

Edge Color (Color):
Edge Color node is used to change the glowing edge of the dissolved GameObject.

Edge Width (Float):
Edge Width node is used to change the thickness of the glowing edge of the dissolved GameObject.

Threshold (Float):
Threshold node is used to control the dissolve threshold of the GameObject.

Noise Scale (Float):
Noise Scale node is used to control the scale of the "Simple Noise".

Emission Power (Float):
Emission Power node is used to control the intensity of the emission power.

Tilling & Offset (Vector2):
Tilling & Offset node is used to adjusts the tilling and offset of the "Simple Noise".


----------------- Noise Textures -----------------
IsTextureOn (Boolean):
IsTextureOn node is used check whether the GameObject uses the "Simple Noise" node as their Dissolve Texture or "Noise Texture".

Noise Texture (Texture2D):
Noise Texture node is for applying the Noise Texture for the dissolve of the GameObject.

Texture Scale (Float):
Texture Scale node is used to control the scale of the "Noise Texture".

Texture Offset (Vector2):
Texture Offset node is used to adjusts the tilling and offset of the "Noise Texture."


----------------- Adjustments -----------------
IsEmissionTexture (Boolean):
IsEmissionTexture node is used to check whether the GameObject has an "Emissive Material". If not, the Boolean is set to false.

Threshold Control (Vector2):
Threshold Control node comprises of two values, "X and Y". Both are used to regulate the dissolve threshold of various game objects.This ensures that as the "Dissolve Threshold" shifts from "0 to 1," the game object fully dissolves.


Reverse (Boolean):
Reverse noode is used to check whether the GameObject's dissolve motion should occur in reverse, such as from up to down or left to right.
A motion where the GameObject dissolve from up to down and revert back from down to up.

False Threshold Control (Vector2):
False Threshold Control node has similar function as "Threshold Control node". It comprises of two values, "X and Y", they regulate the dissolve threshold of the GameObject when the "Reverse Node" is check false. This ensures that as the "Dissolve Threshold" shifts from "0 to 1," the game object fully dissolves.

True Threshold Control (Vector2):
True Threshold Control node has similar function as "Threshold Control node". It comprises of two values, "X and Y", they regulate the dissolve threshold of the GameObject when the "Reverse Node" is check true. This ensures that as the "Dissolve Threshold" shifts from "0 to 1," the game object fully dissolves.


