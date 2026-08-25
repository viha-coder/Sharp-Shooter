#  Sharp Shooter

A first-person shooter (FPS) built with Unity and C#, created as my fifth game development project.

The goal of Sharp Shooter is to combine concepts learned throughout my previous projects while introducing new systems for weapons, shooting, enemies and level design.

---

## Gameplay

Sharp Shooter is a first-person shooter where the player uses a weapon to fight enemies across the level.

The project currently includes:

* First-person shooting
* Weapon system with configurable weapon data
* Raycast-based shooting and hit detection
* Enemy health and damage system
* Muzzle flash and hit effects
* Fire-rate cooldown
* Level prototyping with ProBuilder

---

## Technologies & Concepts

| Concept             | Implementation                                    |
| ------------------- | ------------------------------------------------- |
| **Weapon Data**     | ScriptableObjects (`WeaponSO`)                    |
| **Shooting**        | `Physics.Raycast()` for hit detection             |
| **Effects**         | Particle Systems for muzzle flash and hit effects |
| **Enemy System**    | `EnemyHealth` with damage handling                |
| **Level Design**    | ProBuilder for rapid prototyping                  |
| **Version Control** | Git & GitHub                                      |

---

## What I Learned

### Weapon System

Created a `WeaponSO` to store weapon-specific information such as damage, fire rate and hit effects.

This keeps weapon data separate from the shooting logic, making it easier to create and adjust different weapons without changing the core shooting system.

### Raycast Shooting

Implemented shooting using `Physics.Raycast()` to detect what the player is aiming at.

The system can detect enemy hits, apply damage and create visual effects at the point of impact.

### Enemy Health System

Created an `EnemyHealth` system responsible for receiving and processing damage.

This separates the enemy's health logic from the weapon system and makes the interaction between different gameplay systems easier to manage.

### Level Prototyping

Used ProBuilder to quickly create and test the level layout before focusing on visual details.

This allowed me to experiment with the gameplay space and adjust the environment while keeping development focused on the core mechanics.

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
Assets/Scenes/MainScene.unity
```

4. Press Play and use the left mouse button to shoot.

---

## Customization

### Creating a New Weapon

Create a new `WeaponSO` from:

```text
Project → Create → ScriptableObjects → weaponSO
```

Then configure properties such as:

* Damage
* Fire Rate
* Hit VFX

For example:

```text
Damage: 2
Fire Rate: 0.15
```

### Adjusting Enemy Health

Select an enemy GameObject and modify its **Max Health** value in the `EnemyHealth` component.

---

## Next Steps

The project is still under development. Planned improvements include:

* Enemy AI with patrol, chase and attack behaviors
* Multiple weapon types, such as pistol, rifle and shotgun
* Player health and ammunition systems
* UI for gameplay information
* Additional levels
* Sound effects and music

---

## About the Project

Sharp Shooter is part of my ongoing journey to build a stronger foundation in C# and Unity through practical projects.

With this project, I am bringing together concepts practiced in my previous games while exploring new systems such as raycast-based shooting, weapon management and enemy gameplay mechanics.

---

## Connect with Me

[Linkedin](https:www.linkedin.com/in/guilherme-medeiros-b4a26520a)

[Github](https://github.com/viha-coder)

##
