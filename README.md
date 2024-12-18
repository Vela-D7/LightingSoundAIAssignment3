# Abyss: The Forbidden Quest-Experience Prototype

# Lighting, Sound, and AI Assignment 3

## Abstract:
A VR narrative game combining ancient Egyptian mythology in a mining cave. The player navigates a single timeline, uncovering the timeless consequences of greed, with a twist linking past and future identities.

## Objective:
To create a deeply immersive VR experience, exploring themes of greed, immortality, and redemption.

## Narrative Core:
The player learns they are the reincarnation of Amunet, destined to confront Ra-Hotep across time, resolving the consequences of their actions within the mining cave.

## Synopsis:
In this VR narrative game, the player will on a adventurous and haunting  journey through a dark, ancient Egyptian mining cave, where greed and immortality have cursed both the living and the dead. As the reincarnation of Amunet, the player uncovers the tragic fate of Ra-Hotep, an ancient king doomed to mine for eternity due to his insatiable greed. The game intertwines the past and the present, with the player navigating a world where choices made centuries ago echo into their own existence. As they progress through the cave, the player must confront the consequences of greed, all while unraveling the connection between their past life and their present fate. The game challenges the player to explore themes of redemption, immortality, and the price of unchecked ambition.


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
