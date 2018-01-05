# MageFight Game Console App

**Author**: Ariel R. Pedraza <br />
**Version**: 0.7.0

## Overview
<b>Purpose:</b><br />
This application demonstrates the use of Interfaces. 
White, Black, and Red Mage all inherit from the Mage class. 
White and Red Mage implements White Magic interface. 
Black and Red Mage implements Black Magic interface.
<br /><br />
<b>Summary:</b><br />
MageFight is a game where you select 1 of 3 Mages, then an opponent Mage is chosen at random.
You select a move which consists of a Weapon attack or available magic abilities.
HP and/or MP is depleted or recovered depending on the move chosen. 
The game is finished when opponent HP drops to 0.
<br /><br />
<b>Game Details:</b><br />
White Mage starts with 100 HP and 100 MP<br />
Black Mage starts with 80 HP and 120 MP<br />
Red Mage starts with 120 HP and 80 MP<br />
White and Black Mages can attack with staffs, Red Mages can attack with a long sword.
Weapon attacks restore MP.<br />
Although Red Mages can use both White and Black magic, all spells cost 20% more MP.
<br /><br />
<b>Move Set:</b>
<br />Weapons:<br />
Long Sword: 8 DMG, +10 MP<br />
Staff: 4 DMG, +10 MP<br />
<br />Black Magic:<br />
Fire: 10 DMG, -5 MP<br />
Blizzara: 20 DMG, -15 MP<br />
Thundaga: 30 DMG, -40 MP<br />
<br />White Magic:<br />
Cure: +35 HP, -30 MP<br />
Holy: 20 DMG, +15 HP, -40 MP<br />
Reflect: Prevents DMG received during opponent's next move and applies that DMG to opponent's HP<br />
<br />
<b>Bugs/Not Yet Implemented:</b><br />
Chosing an ability your mage can not perform currently results in you losing your turn.
Game does not prevent you from using magic even when MP drops below 0.
Although there is a starting HP, a MAX HP is not implemented.
Opponent AI not implemented, and thus will not attack back.
Reflect magic spell is not implemented and will not reflect damage during next turn.

## Getting Started
The following is required to run the program.
1. Visual Studio 2017 
2. The .NET desktop development workload enabled 

## Example

```
Program starting...

Welcome to Mage Fight! Pick a Mage to battle with:
1. White Mage
2. Black Mage
3. Red Mage
4. Exit Game
Enter selection: 3

You are fighting a Black Mage!
Choose Attack!:
 White Mage attack selection: 1. Weapon  2. Cure  3. Holy  4. Reflect
 Black Mage attack selection: 1. Weapon  2. Blizzara  3. Fire  4. Thundaga
 Red Mage attack selection: 1. Weapon  2. Blizzara  3. Cure  4. Fire  5. Holy  6. Reflect  7. Thundaga
Enter selection: 2

Attacked Black Mage with blizzara for 20 points of damage! Black Mage Health: 60
Red Mage Health: 120 MP: 62
Choose Attack!:
 White Mage attack selection: 1. Weapon  2. Cure  3. Holy  4. Reflect
 Black Mage attack selection: 1. Weapon  2. Blizzara  3. Fire  4. Thundaga
 Red Mage attack selection: 1. Weapon  2. Blizzara  3. Cure  4. Fire  5. Holy  6. Reflect  7. Thundaga
Enter selection:
```

## Class Diagram
![Class Diagram](401_Lab06.png)

## Architecture
This application is created using ASP.NET Core 2.0 Console applicaitons. <br />
*Language*: C# <br />
*Type of Applicaiton*: Console Application <br />