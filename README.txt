Score Please

A 2D physics-based puzzle game inspired by Pull The Pin-style mechanics.
Players must strategically remove pins to guide balls into the basket while avoiding bombs and failure conditions.

Overview

Score Please is a 2D puzzle game developed in Unity where the player removes pins to control the flow of balls into a scoring basket.

The game focuses on:

Physics-based interactions

Risk–reward decision making

Clean and scalable level data structure

Each level challenges the player to think ahead before pulling pins, as bombs and failure states can cause instant loss.

Gameplay
Core Loop

Observe the level layout

Decide which pin to remove

Balls fall due to gravity

Avoid bombs

Score enough balls into the basket to win

Lose Conditions

Ball hits a bomb

Ball falls outside the play area

Required score not reached

Technical Highlights

This project was built to practice gameplay programming fundamentals and scalable architecture.

Architecture

Scene Management

Implemented using a Singleton pattern for global scene control.

Event System

Used C# Action delegates to implement a lightweight Observer pattern.

Game events (win, lose, score update) are broadcast using event-driven design.

Data-Driven Level System

Levels are stored as JSON files.

Level data is parsed and instantiated at runtime.

Makes it easy to scale to 50+ levels without hardcoding.

Input Handling

Simple click/tap-based interaction for pin removal.

UI System

Score display

Win/Lose panels

Retry functionality

Level Data Structure (example) 
{
  "levelPrefabIndex": 1,
  "mapPos": (3,2),
  "goalPosition": (2,3),
  "spawnDatas": [...],
  "ballToWin": 12
  "pinDatas": [...]
}

Levels are fully configurable through JSON, allowing fast iteration without modifying gameplay scripts.

What I Learned

Through this project, I gained hands-on experience with:

Designing a simple but complete gameplay loop

Applying Singleton and Observer patterns in Unity

Implementing event-driven architecture using C# Actions

Building a scalable JSON-based level loading system

Managing UI flow between game states

Handling physics-based interactions in 2D

Possible Improvements

Add more mechanics (locked pins, portals, gravity switch, etc.)


Playable build:
https://drive.google.com/file/d/15vU1uEYTlfXlbd6JSF_OOSsXeI0CWW15/view?usp=sharing

Built With

Unity (2D)

C#

Unity Physics 2D

JSON Serialization