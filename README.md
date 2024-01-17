Simple Pong Game in Unity!

The game allows 2 players to play Pong, "The First Commercially Successful Video Game"! The game is built in Unity using Unity Pre Built components and scripts for controls of different components including: Player, Ball (Pong Ball) and Screens. <br />
To Play:
The game provides 2 padsels for 2 players with the left paddle being player 1 and right paddle being player 2. <br />
The left paddle control for player 1 is implemented with: <br />
  Key Press "s": Moving the Paddle Down<br />
  Key Press "w": Moving the Paddle up.<br />
The right paddle control for player 2 is implemented with: <br />
  Key Press "down": Moving the Paddle Down<br />
  Key Press "up": Moving the Paddle up.<br />
The Pong ball bounces off automatically on start and when one player scores. Player scores are automatically updated after one fails to keep the Pong ball on screen or within boundary.<br />

Infrastructure:
Screen: Main Game screen holding camera and providing interface for the Whole Game using a Canvas. <br />
Components: Unity 2D pre built shapes, physics and colliders are implementated to create walls, pong ball, goals and implement simple physics: Collison, Vector for movement and functionality.<br />
Control: Paddle controls are implemented through Unity settings setting seperate keypresses for movement of paddles.<br />
Scripts:<br />
Ball: The Ball script is implementated to enable automatic Pong Ball movement and reset when any player scores.<br />
Goal: Monitor which player is scoring and then call gamemanager for score update.<br />
Gamemanager: Update player scores, set players to default position after each score.<br />
Paddle: Enable paddle movements through project preset controls.
