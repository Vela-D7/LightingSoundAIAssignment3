# Abyss: The Forbidden Quest-Experience Prototype

# Lighting, Sound, and AI Assignment 3

## Overview

This project is a Unity-based game assignment that incorporates lighting, sound, AI, and animations to create an immersive gameplay experience. The project focuses on implementing features like mummy behavior, animations, and player interaction within an Egyptian-themed environment.

## Features

- **Mummy AI**: 
  - Mummies patrol, chase the player, and attack when within range.
  - Behaviors include idle, chase, attack, threaten, take damage, and die.
  
- **Player Interaction**:
  - Sword-based combat system.

- **Environment**:
  - Egyptian-themed level design with dynamic lighting and sound effects.

- **Lighting**:
  - A mix of baked and real-time lights for performance and realism.
  
- **Sound Effects**:
  - Ambient and interactive sound effects enhance the experience.

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Vela-D7/LightingSoundAIAssignment3.git
   ```
2. Open the project in Unity (version 2022.3.x recommended).
3. Ensure you have the necessary Unity packages installed:
   - NavMesh Components
   - XR Interaction Toolkit
   - Yarn Spinner

## How to Play

1. Navigate the Egyptian ruins.
2. Engage with mummies using the sword.

## Key Scripts

- **MummyBehavior.cs**: Handles AI logic for the mummies.
- **PlayerController.cs**: Manages player movement and interactions.

## Known Issues

- Occasionally, animations may not sync with AI behavior. Ensure animator parameters are correctly named.
- Performance dips may occur on lower-end systems. Optimize lighting settings if necessary.

## Credits

- **Developer**: Vela-D7
- **Tools**: Unity 3D, C#, NavMesh, XR Interaction Toolkit, Yarn Spinner
