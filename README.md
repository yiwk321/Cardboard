# Cardboard Projectile Aim Trainer
----------------------------------------------------------------
### Description
This VR game spawns the player in the middle of the scene. The player cannot move but are free to turn their perspective. Every 3 seconds, the game spawns a target sphere at random location around the player. The targets will move at random speed in one of three patterns: horizontal, vertical, and forward/backward. There will be at most 10 targets at any given time. If a target is not hit within 15 seconds, it will destroy itself. 

The player can shoot a projectile ball with falloff at a fixed speed from the center of the screen towards the direction the player is facing by tapping the screen. If the ball hits a target, the target will be destroyed and the player earns 1 point; otherwise, the miss counter will be increased by 1. 

There is a score board in the game that shows the player their score, their number of misses, and their accuracy so far. 

### Why is it a game? 
Using Juul's definition of game, this is a game becasue:
1. Fixed rules: the player is in a fixed position and can only shoot one projectile at a time.
2. Variable outcome: a shot can be either hit or a miss.
3. Valorization of outcome: hitting a shot is considered better than missing a shot.
4. Player effort: the player has to aim to hit the target.
5. Outcome associated to player: hitting the target makes the player happy and missing the target makes the player unhappy.
6. Optional consequences: there is no in-game consequences, but the player's happiness can be affected by their accuracy. 