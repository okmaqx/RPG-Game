# RPG-Game
Script Description

This project contains two main components: HealthComponent and Player, which handle the character’s health system, healing, and movement.

🩸 HealthComponent

This script manages the health system of a game object.

Features:

Stores current (hp) and maximum (maxHp) health values

Receives damage via the GetDamage(int damage) method

Destroys the game object when health reaches zero or below

Restores health using the Heal(int healCount) method

Prevents health from exceeding the maximum value

This component is designed to be reusable and can be attached to any game object.

🎮 Player

This script controls the player character.

Features:

Player movement using W / A / S / D keys

Smooth rotation towards the movement direction

Uses CharacterController for movement

Healing system using potions:

Heal is triggered by pressing the H key

Each potion restores a fixed amount of health

The number of potions is limited

The script interacts with HealthComponent to restore the player’s health.

🧩 Technologies Used

Unity Engine

C#

CharacterController

Component-based architecture
