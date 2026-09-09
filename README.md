# Unity Game Development Summary

| Field | Detail |
|---|---|
| **Project Name:** |**Dante's Journey**|
| **Names:**|**Matthew C, Jude L**|
| **Course/Class:**|**Computer Technology Yr10**|
| **Repository:**|**https://github.com/TempeHS/2026CT_GameDesign_DantesJourney_Matthew.C**|
| **Unity Version:** |**6000.0.58f1**|
| **Document Version:** | **0.4269** |
| **Date:**|**27/8/2026** |

---

## Table of Contents
1. [Game Overview](#1-game-overview)
2. [Video Walkthrough](#2-video-walkthrough)
3. [Game Mechanics](#3-game-mechanics)
4. [Visual Features](#4-visual-features)
5. [Audio Design](#5-audio-design)
6. [User Interface & HUD](#6-user-interface--hud)
7. [Scene & Level Design](#7-scene--level-design)
8. [Scripts & Programming](#8-scripts--programming)
9. [Development Techniques & Tutorials Acknowledged](#9-development-techniques--tutorials-acknowledged)
10. [Third-Party Content Acknowledgements (NOT APPLICABLE)](#10-third-party-content-acknowledgements)
11. [Challenges & Solutions](#11-challenges--solutions)
12. [Branch Development Summary (NOT APPLICABLE)](#12-branch-development-summary)

---

## 1. Game Overview

### 1.1 Genre
2D Platformer

### 1.2 Target Audience
Teens


### 1.3 Game Summary
Dante's Journey is a 2D Platformer about travelling through the 9 circles of hell from Dante's Inferno. There are obstacles like moving saws trying to stop you from continuing forward, jump past them and dive deeper into hell.


### 1.4 Win / Loss Conditions
| Condition | Description |
|---|---|
| Win | Reach end of circle (level) |
| Loss | Lose all 3 hearts |

### 1.5 Platform & Build Settings
| Setting | Detail |
|---|---|
| Target Platform | PC |
| Resolution | 1920 x 1080 |
| Build Type | Windows 64-bit |

---

## 2. Video Walkthrough

### 2.1 Full Gameplay Walkthrough

<!--
  Embed a YouTube/Vimeo video or link to a file in the repository.
  YouTube embed syntax:
  [![Video Title](https://img.youtube.com/vi/VIDEO_ID/0.jpg)](https://www.youtube.com/watch?v=VIDEO_ID)

  OR link to a local file:
  [Watch Walkthrough Video](./docs/video/walkthrough.mp4)
-->

| Field | Detail |
|---|---|
| **Video Title** | |
| **Link / Embed** | |
| **Duration** | |
| **Description** | |

### 2.2 Feature Highlight Clips

| Clip | Description | Link |
|---|---|---|
| | | |
| | | |
| | | |

---

## 3. Game Mechanics

### 3.1 Core Mechanics
| ID | Mechanic | Description | Implemented In (Script / Objects) |
|---|---|---|---|
| M-1 | Damage | Allows obstacles to move and damage the player | EnemyObstacle.cs / Saws and Spikes| 
| M-2 |Health| Gives player health and shows amount of health | Health.cs and HealthBar.cs |
| M-3 |Player Movement| Lets player jump and walk | PlayerMovement.cs |
| M-4 | Healing | Lets player heal damage | HealthHealing.cs |
| M-5 | Music and SFX | Lets music and SFX play in the game | AudioManager.cs |

### 3.2 Player Controls
| Action | Input (Keyboard / Controller) | Description |
|---|---|---|
| Jump | Space | Lets the player jump, holding down increases jump height |
| Walk Left | A or Left Arrow | Lets the player walk to the left |
| Walk Right | D or Right Arrow | Lets the player walk to the right |
|  |  |  |

### 3.3 Physics & Collision
| Feature | Description |
|---|---|
| Player | Player interaction with objects, player ground check for jump |
| Saws and Spikes | Moves left,right,up and down (Saw), uses circle collider with isTrigger on to deal damage on collide with player (Both)|
| Heart (In Stage) | Uses box collider with isTrigger on to heal on collide with player |

### 3.4 Game Loop 
| Stage | Description |
|---|---|
| Start / Initialisation | Main Menu Play Button |
| Core Loop | Platform through level |
| Win / End State | Beat Level |
| Restart | Restart Button in pause menu |

### 3.5 Scoring & Progression [Not Applicable in this Project]
| Element | Description |
|---|---|
| Scoring System |  |
| Difficulty Progression |  |
| Unlockables / Levels | |

---

## 4. Visual Features

### 4.1 Particle Effects [Not Applicable in this Project]

| Effect Name | Purpose | Screenshot |
|---|---|---|
| | | |
| | | |
| | | |
| | | |

> Add screenshot images using: `![Effect Name](./docs/screenshots/effect_name.png)`

---

### 4.2 Cut Scenes & Cinematics [Not Applicable in this Project]

| Cut Scene | Trigger | Description | Screenshot / Still |
|---|---|---|---|
| | | | |
| | | | |
| | | | |

> Add screenshot images using: `![Cut Scene Name](./docs/screenshots/cutscene_name.png)`

---

### 4.3 Animations

| Animation | Object / Character | Description | Screenshot |
|---|---|---|---|
|Player Walking| Player | Player sprite walks | |
|Sawblade Active|Saw|Saw spins around clockwise | |
|Player Death | Player | Player falls to his knees and burns | |
|Player Hurt | Player|Player flashes shades of red|

> Add screenshot images using: `![Animation Name](./docs/screenshots/animation_name.png)`

---

### 4.4 Lighting & Post-Processing [Not Applicable in this Project]

| Feature | Description | Screenshot |
|---|---|---|
| | | |
| | | |
| | | |

> Add screenshot images using: `![Feature Name](./docs/screenshots/lighting_name.png)`

---

### 4.5 Shaders & Materials [Not Applicable in this Project]

| Shader / Material | Applied To | Description | Screenshot |
|---|---|---|---|
| | | | |
| | | | |
| | | | |

> Add screenshot images using: `![Shader Name](./docs/screenshots/shader_name.png)`

---

### 4.6 Additional Visual Screenshots

<!--
  Add any other notable screenshots here.
  Syntax: ![Description](./docs/screenshots/filename.png)
-->

| Description | Screenshot |
|---|---|
| | |
| | |
| | |

---

## 5. Audio Design

### 5.1 Music
| Track | Scene / Trigger | Source / Composer |
|---|---|---|
| Title Screen | Main Menu | Jude L. |
| Limbo | Limbo | Jude L. |

### 5.2 Sound Effects
| Sound Effect | Trigger | Source |
|---|---|---|
|Jump| Press space (Jump button) | Jude L.|
|Heal/Pick Up Item|Player collides with pick up object (healing item) | Jude L. |
|Walk| UNUSED | Jude L. |


### 5.3 Audio Implementation [Not Applicable In Project]
| Feature | Description |
|---|---|
| Audio Mixer / Groups | |
| Spatial / 3D Audio | |
| Dynamic Audio | |

---

## 6. User Interface & HUD

### 6.1 HUD Elements
| Element | Purpose | Screenshot |
|---|---|---|
|Health Bar |Show player's current health | |


> Add screenshot images using: `![HUD Element](./docs/screenshots/hud_name.png)`

### 6.2 Menus
| Menu | Purpose | Screenshot |
|---|---|---|
| Main Menu | Settings, Play, Quit Game | |
| Pause Menu | Return to main menu, resume level, restart level | |
| Settings | No Current Purpose | |


> Add screenshot images using: `![Menu Name](./docs/screenshots/menu_name.png)`

---

## 7. Scene & Level Design

### 7.1 Scene List
| Scene Name | Purpose | Description |
|---|---|---|
| Limbo| Gameplay area of circle 1 | Begins with piles of books as tutorial to jump, enters castle area to introduce damage and healing |
| Main Menu| Allow player to change settings, quit game and begin game | Name of game and background image, button for settings, playing and quitting the game |


### 7.2 Level / Environment Screenshots
| Level / Area | Description | Screenshot |
|---|---|---|
| Limbo (Circle 1) | Begins with green grass area with books and ruined pillars, enters castle with saw and spike traps | |


> Add screenshot images using: `![Level Name](./docs/screenshots/level_name.png)`

### 7.3 Scene Management
| Feature | Description |
|---|---|
| Scene Loading Method | LoadSceneAsync, GetActiveScene().buildIndex |
| Persistent Data Between Scenes | NOT APPLICABLE |
| Scene Transition Effects | NONE |

---

## 8. Scripts & Programming

### 8.1 Script Summary
| Script Name | Attached To | Responsibility |
|---|---|---|
| AudioManager.cs | Object: Audio Manager / Scripts: HealthHealing.cs, StartMenu.cs, PlayerMovement.cs | Allow audio to be used when certain events happen (e.g. Space button is pressed) | 
| EnemyObstacle.cs / EnemyObstacleVertical.cs | Object: Saw, Spike / Scripts: Health |Lets obstacles move, damages player when colliding with damaging object | 
| Parallax.cs + ParallaxController.cs |Object: Background Objects| Makes background have parallax effect |
|StartMenu.cs|Scripts: AudioManager.cs|Main Menu for player to start, lets player enter stage, quit game and change settings| 
|PauseMenu.cs|Objects: Pause Menu, Pause button, Resume,Home,Restart buttons |Lets the player pause the game with the pause button, restart the level, resume the level and return to the main menu using buttons inside the pause menu| 
|Health.cs, HealthBar.cs, HealthHealing.cs|Object: Health Bar, Player, Healing Object / Scripts: Player|Adds health system to player, lets current health be displayed, lets player heal damage|

### 8.2 Key Algorithms / Logic
| Feature | Script | Description |
|---|---|---|
| | | |
| | | |
| | | |

### 8.3 Design Patterns Used
| Pattern | Where Applied | Justification |
|---|---|---|
| | | |
| | | |
| | | |

---

## 9. Development Techniques & Tutorials Acknowledged

> List every tutorial, course, video, or article that informed or guided your implementation. Include what you used it for and what you changed or adapted.

| # | Title | Author / Creator | URL / Source | What You Used It For | What You Changed / Adapted |
|---|---|---|---|---|---|
| 1 | 2D Player Movement In Unity | bendux | https://www.youtube.com/watch?v=K1xZ-rycYY8|Player Movement, jump | MINIMAL CHANGE |
| 2 | Make Your MAIN MENU Quickly!  Unity UI Tutorial For Beginners | Rehope Games|https://www.youtube.com/watch?v=DX7HyN7oJjE | Main Menu buttons |Used canvas for background to make main menu fit different resolutions|
| 3 |Unity 2D Camera Follow System |Rehope Games | https://www.youtube.com/watch?v=6p-VrQOj2KU|Camera following player | MINIMAL CHANGE |
| 4 |How to Create a PAUSE MENU in Unity !  UI Design Tutorial |Rehope Games |https://www.youtube.com/watch?v=MNUYe0PWNNs |Pause Button, pause menu, pause buttons | MININMAL CHANGE |
| 5 |How to Add MUSIC and SOUND EFFECTS to a Game in Unity  Unity 2D Platformer Tutorial #16 | Rehope Games|https://www.youtube.com/watch?v=N8whM1GjH4w |Adding music and sound effects on scene enter and event trigger | MINIMAL CHANGE |
| 6 |Unity 2D PARALLAX EFFECT Tutorial  Endless Scrolling Background |Rehope Games |https://www.youtube.com/watch?v=ZYZfKbLxoHI |Parallax effect for background| MINIMAL CHANGE |
| 7 |Unity 2D Platformer for Complete Beginners - #7 HEALTH SYSTEM | Pandemonium|https://www.youtube.com/watch?v=yxzg8jswZ8A |Health system (Health and Healthbar) and damage system| Added another script to allow for vertically moving obstacles |
---

## 10. Third-Party Content Acknowledgements [Not Applicable in this Project]

> All third-party assets (art, audio, fonts, scripts, packages) must be listed here with their licence. Using an asset without acknowledgement may constitute academic misconduct.

### 10.1 Visual Assets
| Asset Name | Type | Creator / Source | Licence | URL | Used For |
|---|---|---|---|---|---|
| | | | | | |
| | | | | | |
| | | | | | |

### 10.2 Audio Assets
| Asset Name | Type | Creator / Source | Licence | URL | Used For |
|---|---|---|---|---|---|
| | | | | | |
| | | | | | |
| | | | | | |

### 10.3 Scripts & Code Snippets
| Script / Snippet | Source | Licence | URL | Used For | Changes Made |
|---|---|---|---|---|---|
| | | | | | |
| | | | | | |
| | | | | | |

### 10.4 Unity Packages & Plugins
| Package Name | Version | Source | Licence | URL | Purpose |
|---|---|---|---|---|---|
| | | | | | |
| | | | | | |
| | | | | | |

### 10.5 Fonts
| Font Name | Creator / Source | Licence | URL |
|---|---|---|---|
| | | | |
| | | | |

---

## 11. Challenges & Solutions

| # | Challenge Encountered | How It Was Solved |
|---|---|---|
| 1 || |
| 2 | | |
| 3 | | |
| 4 | | |
| 5 | | |

---

## 12. Branch Development Summary [Not Applicable in this Project (forgot to use branches)]

> One section per feature branch. Add or remove sections to match your repository. Branches should be named for the feature they implement e.g. `feature/player-movement`. Link each branch name directly to the branch in your GitHub repository.

---

### Branch 1 — `main`

| Field | Detail |
|---|---|
| **Branch Name** | `main` |
| **Purpose** | Stable, releasable version of the game |
| **Merged From** | |
| **Final Commit** | |

---

### Branch 2 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built
<!-- Describe what this branch added or changed -->

#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
<!-- Add a screenshot of the feature working -->
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch 3 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built


#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch 4 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built


#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch 5 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built


#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch 6 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built


#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch Development Overview

> Complete this summary table once all branches are finished.

| Branch Name | Feature | Date Started | Date Merged | Status |
|---|---|---|---|---|
| `main` | Stable release | | | |
| `feature/` | | | | |
| `feature/` | | | | |
| `feature/` | | | | |
| `feature/` | | | | |
| `feature/` | | | | |

---

> **Student Declaration:** All work submitted is my own except where explicitly acknowledged above.