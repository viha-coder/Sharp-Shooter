# Sharp Shooter

[![Unity Version](https://img.shields.io/badge/Unity-2022.3+-blue.svg)](https://play.unity.com/en/games/330ef413-5a66-42d0-93d4-e87eea9326bc/sharp-shooter)
[![Desktop Version](https://img.shields.io/badge/Download-V1.0-red.svg)](https://github.com/viha-coder/Sharp-Shooter/releases/tag/V1.0)
[![C#](https://img.shields.io/badge/C%23-9.0-purple.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

A first-person shooter (FPS) built with Unity and C#, created as my fifth game development project.

The goal of Sharp Shooter was to combine concepts learned throughout my previous projects while exploring new systems for weapons, shooting, enemies and level design.

---

## Gameplay


<img width="800" height="450" alt="Sharp Shooter Gameplay" src="https://github.com/user-attachments/assets/db6ac3b6-bc2e-4c3c-aca4-06ca0b02187b" />

Sharp Shooter is a first-person shooter where the player fights enemies across a level using different weapons.

The final version includes:

- First-person shooting
- Multiple weapon types, including Machine Gun and Sniper
- Sniper scope system
- Weapon pickups throughout the level
- Configurable weapon data
- Raycast-based shooting and hit detection
- Enemy health and damage system
- Enemy navigation and behavior
- Muzzle flash and hit effects
- Weapon animations
- Fire-rate cooldown
- Enemy counter
- Game completion flow
- Level designed with ProBuilder

---

## Technologies & Concepts

| Concept | Implementation |
|---|---|
| **Weapon Data** | ScriptableObjects (`WeaponSO`) |
| **Shooting** | `Physics.Raycast()` for hit detection |
| **Weapons** | Machine Gun, Sniper and weapon pickups |
| **Sniper Scope** | Custom aiming/scope system |
| **Effects** | Particle Systems for muzzle flash and hit effects |
| **Enemy System** | `EnemyHealth` with damage handling |
| **Enemy Navigation** | NavMesh |
| **Level Design** | ProBuilder |
| **Version Control** | Git & GitHub |

---

## What I Learned

### Weapon System

Created a `WeaponSO` to store weapon-specific information such as damage, fire rate and hit effects.

Separating weapon data from the shooting logic made it easier to create and configure different weapons without changing the core shooting system.

### Raycast Shooting

Implemented shooting using `Physics.Raycast()` to detect what the player is aiming at.

The system can detect enemy hits, apply damage and create visual effects at the point of impact.

### Sniper Scope

Implemented a scope system for the Sniper, creating a different aiming experience from the other weapons.

### Enemy System

Created an enemy health system for receiving and processing damage, together with navigation and behavior for enemies that can move toward the player.

The robot can also self-destruct when it reaches the player.

### Weapon Pickups

Implemented weapon pickups throughout the level, allowing the player to find and switch weapons during gameplay.

### Level Design

Used ProBuilder to create and prototype the level, allowing me to focus on gameplay layout and player movement while building the environment.

### Visual Feedback

Added muzzle flashes, hit effects and weapon animations to make the player's actions more visually responsive.

---

## Enemy Counter

The game includes an enemy counter that tracks the remaining enemies in the level.

The count is updated when enemies are defeated, including when an enemy self-destructs.

When all enemies are eliminated, the game triggers the completion state.

---

## Project Structure

```text
Sharp-Shooter/
├── Assets/
│   ├── Animations/
│   ├── Imported Assets/
│   ├── Materials/
│   ├── Prefab/
│   ├── Resources/
│   ├── Scenes/
│   ├── Scriptable Objects/
│   └── Scripts/
│       ├── ActiveWeapon.cs
│       ├── EnemyHealth.cs
│       ├── Robot.cs
│       └── Weapon.cs
├── Packages/
└── ProjectSettings/
```

---

## How to Play

1. Clone the repository:

```bash
git clone https://github.com/viha-coder/Sharp-Shooter.git
```

2. Open the project in **Unity 2022.3 or newer**.

3. Open the main scene from:

```text
Assets/Scenes/
```

4. Press Play and use the controls to move, aim, shoot and interact with weapon pickups.

---

## Customization

### Creating a New Weapon

Create a new `WeaponSO` from:

```text
Project → Create → ScriptableObjects → weaponSO
```

Then configure properties such as:

- Damage
- Fire Rate
- Hit VFX

For example:

```text
Damage: 2
Fire Rate: 0.15
```

### Adjusting Enemy Health

Select an enemy GameObject and modify its **Max Health** value in the `EnemyHealth` component.

---

## About the Project

Sharp Shooter is my **fifth Unity and C# project**.

The project was created to bring together concepts practiced throughout my previous games while introducing new systems such as raycast shooting, weapon management, enemy navigation, pickups and level design.

It was also an opportunity to work on a more complete FPS, combining gameplay mechanics, visual feedback and multiple interconnected systems in a single project.

---

## Connect with Me

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/guilherme-medeiros-b4a26520a)

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/viha-coder)
