# Cubster-Game

A 3D obstacle-dodging game developed using Unity and C#.

## Overview

Cubster-Game is a simple 3D arcade-style game where the player controls a cube that continuously moves forward through an obstacle-filled environment.

The objective is to avoid obstacles, maintain movement, and reach the end of each level.

## Gameplay Features

- Continuous forward player movement.
- Horizontal movement to dodge obstacles.
- Rigidbody-based player movement.
- Obstacle collision detection.
- Game-over and restart functionality.
- Distance-based scoring system.
- Level completion and scene transitions.
- Camera following system.

## Controls

| Key | Action |
|---|---|
| A | Move Left |
| D | Move Right |

## Technical Implementation

The project uses Unity's built-in components and C# scripts to implement its core gameplay systems.

### Core Scripts

| Script | Responsibility |
|---|---|
| `PlayersMovement.cs` | Controls player movement and physics interactions. |
| `PlayerCollision.cs` | Handles obstacle collision detection. |
| `GameManager.cs` | Manages game-over, restart, and level-completion states. |
| `EndTrigger.cs` | Detects level completion through trigger interactions. |
| `Score.cs` | Updates the distance-based score display. |
| `FollowPlayer.cs` | Keeps the camera positioned relative to the player. |
| `LevelComplete.cs` | Handles transitions to the next level. |
| `Start.cs` | Loads the gameplay scene. |
| `Credits.cs` | Handles application exit functionality. |

## Technologies Used

- **Game Engine:** Unity
- **Programming Language:** C#
- **Physics:** Unity Rigidbody and Collider components
- **UI:** TextMesh Pro
- **Scene Management:** Unity Scene Management API

## Project Structure

```text
Cubster-Game/
│
├── Assets/
│   ├── Animation/
│   ├── Material/
│   ├── Prefab/
│   ├── Scenes/
│   ├── Scripts/
│   └── TextMesh Pro/
│
├── Packages/
├── ProjectSettings/
├── .gitignore
└── README.md
```

## Development Notes

The project demonstrates fundamental Unity game development concepts, including:

- Rigidbody-based movement and physics.
- Collision and trigger event handling.
- Game state management.
- Scene loading and transitions.
- UI score updates.
- Camera tracking.

The repository also contains subsequent code improvements to the original gameplay scripts.

## Setup

1. Clone or download the repository.
2. Open the project folder using Unity Hub.
3. Allow Unity to resolve the project's package dependencies.
4. Open the appropriate gameplay scene.
5. Run the project through the Unity Editor.

## Requirements

- Unity Editor (version compatible with the project's `ProjectVersion.txt`).
- Unity Hub.
- TextMesh Pro, as referenced by the project scripts and assets.

## License

No license has been specified for this repository.
