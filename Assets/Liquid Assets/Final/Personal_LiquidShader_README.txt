README on how the my personal "Final_Liquid" Shader/

----------------- References from various "Liquid Shader" Links -----------------
1. Liquid#1: Unity Shader Graph - Liquid Effect Tutorial (Gabriel Aguiar Prod.)
- This shader's "Wobble" group can be use to allow the GameObject to have a wobble motion when moved or rotate.
- There is a "Remap" Nodes that can adjust the value of the "Fill" node so that there is liquid material when there is fill value.

2. Liquid#2: Potion Liquid Wobble Shader Graph - Easy Unity Tutorial (Binary Lunar)
- This shaders have "Color" and "Fill" Group nodes that i am use for my personal shader.
- This shader's "Wobble" group is simialr to "Liquid#1".

3. Liquid#3: Liquid Shader Breakdown | Unity URP + Built-in (MinionsArt)
- This shader have a "Liquid" Script to allow the gameobject to woddle but its too complicated for me.
- This shader have multipe group nodes like "Rim", "Foam" that i can use. 

Shader Graphs Nodes:
----------------- Main Controls -----------------
Fill Amount (Texture2D):
Fill Amount node is used to control the liquid amount of the GameObject.

Main Texture (Texture2D):
Main Texture node is for applying the Gradient Texture to the Liquid GameObject.

Surface Color (Texture2D):
Surface Color node is used to change surface color of the Liquid GameObject.

Liquid Color (Texture2D):
Liquid Color node is used to change liquid color of the Liquid GameObject.


----------------- Rim Controls -----------------
Fresnel Power (Texture2D):
Fresnel Power node is used to control the intensity of the rim light emission power.

Fresnel Color (Texture2D):
Fresnel Color node to used to change rim light color of the Liquid GameObject.


----------------- Foam Controls -----------------
Foam Width (Texture2D):
Foam Width node is used to adjust the width of the foam on the top edge of the Liquid GameObject

Foam Smoothness (Texture2D):
Foam Smoothess node is used to adjust the foam to blend in together with the Liquid GameObject from top to bottom.

Foam Color (Texture2D):
Foam Color node is used to change foam color of the Liquid GameObject.


----------------- Adjustments -----------------
Fill Threshold Control (Texture2D):
Fill Threshold Control node comprise of two values, "X and Y". Both are used to regulate the fill threshold of various Liquid GameObject. This ensures that as the "Fill Threshold Control" shifts from "0 to 1," the Liquid GameObject is either fully fill or fully empty.


----------------- Others -----------------
WobbleX (Texture2D):
WobbleX node is used by the "Wobble Script" to allow the Liquid GameObject to have that wobble effect when the gameobject is being rotated or moved.

WobbleZ (Texture2D):
WobbleX node is used by the "Wobble Script" to allow the Liquid GameObject to have that wobble effect when the gameobject is being rotated or moved.

Wobble Script:
Max Wobble:
Increase the value make the Liquid GameObject more vicicious.
Max Wobble is used to adjust the viscoity of the Liquid GameObject.

Wobble Speed:
Wobble Speed is used to adjust the wobbling speed of the liquid as it move left and right.

Recovery:
Recovery is used to adjust the time it takes for the Liquid GameObject to calm down.
----------------- Thin Liquid -----------------
Max Wobble: (0.03)

Wobble Speed: (0.5)

Recovery: (1)

----------------- Thick Liquid -----------------
Max Wobble: (0.03)

Wobble Speed: (2)

Recovery: (1)
