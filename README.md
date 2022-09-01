# Menuing Project Template for Unity

---

## READ THIS FIRST

---

This is using Unity 2021.3.7f1

Clone this repo and create a branch off of `main` before starting. All of your changes should be on that branch. Once you are done, create a Pull Request (PR). This will signify to us that you are complete.

## Overview

---

Your job is to create a simple menuing system using the provided design located in the `PSD` folder.

**Note:** the font used in the PSD can be downloaded [here](https://fonts.google.com/download?family=Manrope). You can also find it on [Google Fonts](https://fonts.google.com/specimen/Manrope?query=Manrope). I have also included the font files within the repo in `Assets/Fonts` 

## Requirements

---

- A Scene for the Loading screen from the provided design.
  
  - This should include the loading bar simulating a load. When the loading bar reaches 100% the game should pause for a second or so and then transition to the Main Menu Scene.

- A Scene for the Main Menu Screen from the provided design.
  
  - The Coin HUD in the top left of the screen should take in a value for the coins and set it when entering the Main Menu Scene.
  
  - The Lightning Button in the bottom middle of the screen should add coins to the Coin HUD when clicked.

- Settings Popup from the provided design.
  
  - The popup should include a toggle button that switches sprites when toggled between `ON` and `OFF`.
  - The popup should be closed  by clicking the `X` button below the popup.

- Ability to open the Settings Popup from the Gear Button in the top right of the screen.

- All UI should scale to any resolution. This means if there is UI in the top left corner, when you switch resolution, it should stay in the top left corner. 

## Nice to Haves

---

- Scene Transition Animations

- Popup Open and Close Animations

- Sound Effects

- Particles that fly from the Lightning Button to the Coin HUD when clicked.

## Included Assets

---

- A `PSD` located at `Assets/PSD/LightningDashMockup.psd` which has all of the assets needed to complete this task.

**USAGE IS OPTIONAL**

- A tweening engine called DOTween.

- An example scene and script showing how to use DOTween.

[DOTween Documentation](http://dotween.demigiant.com/documentation.php)
