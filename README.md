# super-garbanzo
Name says it all: Not just an ordinary Garbanzo! 

# Test Quest

## Items

Items are small objects that a player can use, and if there's an inventory system, take with them for later use.

## Weapon

Weapons in Test Quest help increase damage attacked for. Generally, weapons will be much stronger than armour, so you can still deal decent damage, even if enemies have strong armour. 
The only thing that a weapon does is deal attack damage to enemies, enhancing your attack's power. Whatever attack damage a weapon has is the damage that it will deal to enemies it's used on. Your basic attack damage is 2, until overridden by a weapon. 

## Armour

Armour in Test Quest helps reduce damage taken. Generally, armour will be much weaker than weapons, because else people wouldn't be able to take damage. 
The amount of damage that you take from an incoming attack is the incoming damage, minus the armour points you have. Your basic armour is 0. 

## Health Potion

Health potions are items that are able to increase a player's current HP. There is no max HP 

## Map

The map is a grid of squares called 'tiles'. Each tile can have at most one structure (chest/wall/door/player/enemy) on it.

## Structures

Every tile on the map can have at most one structure on it. You can programe any of the following structures (I suggest in the specified order):

## Player

The player is the character that a player of the game plays as.
Wall
The wall (for now) only exists to make sure players and enemies can't walk over certain tiles. It doesn't have any interaction.

## Enemy
Enemies are creatures that are controlled by the computer, to attack the player. (for now) Enemies don't have movement. They only attack if a player is in an adjacent tile.

## Chest

A player can look in a chest they are next to, to find items like keys, or better armour or weapons.
Door
A door is a way to get from one room to another. Doors mainly exist to make sure enemies can't travel, or to require a key from a player to get into another room.

## Player

There are a few properties a player has:

- Health Points help you survive. If you have any more than 0 HP, you survive. If not, you're dead. HP can be restored by using health potions.
- Attack damage helps you attack. However much your current attack damage is, is the amount of damage you deal to an enemy. Any armour points they have is the reduction of damage points they get on that damage. If you have a weapon, your attack damage is the damage of the weapon. If you don't, it's 2.
- Armour points help you defend. Whenever an enemy attacks you, their attack damage is the amount of damage they deal to you. Your armour points are subtracted from that, and that final number is the amount of damage you take. If you have armour, your armour points are the amount that your armour has. If you don't have armour, it's 0.

There are a few things players can do:

- A player can step into an adjacent empty tile
- A player can attack an enemy in an adjacent tile
- A player can open a chest in an adjacent tile
- A player can open a door in an adjacent space, if they have all required keys

When a player finds armour or a weapon in a chest, they can choose to equip it, or not. If not, the equipment is lost. If yes, the old equipment is lost.

## Combat

When someone attacks someone else, they are attacked for the attacker's attack damage. When someone gets damaged, they take the amount of damage, minus their armour points. That is subtracted from their health points. 

## Duration of the game

The player starts a game without any weapons or armour, with 10 HP. Then they venture through different rooms with chests, doors, and enemies, to become stronger, and beat the dungeon.
