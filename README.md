
# EnterTheDungeon

This file contains the documentation for Enter the Dungeon.

# Table of Contents

## Introduction
[Overview](#overview)

[Proposal](#proposal)

## Controls
[Control Map](#controls)

## Puzzle Design
[Puzzle Documentation](#puzzle-design-1)

[Section 1 - Start](#section-1---start)

[Game Map](#game-map)

## Process
[Process](#process)

[Technical Documentation](#technical-documentation)

[Art Documentation[(#art-and-visuals)

## Asset List
[Assets](#assets)

## To-Do List
[To-Do](#to-do-list)

## Sources
[Sources](#sources)



# Overview

## Concept
Enter the Dungeon is a Text Adventure game where you find yourself waking up wet, cold, and alone in a decrepit dungeon and must find your way to the exit. Hearkening back to classic text adventure games such as Zork or The Fellowship of the Ring, Enter the Dungeon is a modern twist on a retro-fantasy genre, taking aspects of both horror and rpg titles to create a short but enthralling experience.

## Target Audience
The target audience for Enter the Dungeon is primarily young adults, people who like finding games through sources such as itch.io or other indie platforms as opposed to AAA titles. This game is intended to be accessible to people who are fluent in English and can read.

* People who like to role-play and read
* People who enjoy indie titles
* People who like the slowly building anticipation of horror genres

## Platform
Enter the Dungeon will be released for PCs running windows and will be available for free on itch.io.



# Proposal

[View in PDF format](https://github.com/Headlesser/enterthedungeon/raw/master/documentation/proposal.pdf)

## Overall Idea

> What is your overall idea?

I want to make a text adventure game using the Unity game engine. I want to
accomplish at least a working, playable demo for the game by the end of March. 
I want to use this project to work on my puzzle design and writing skills
primarily. I will be following the [Unity training Text Adventure tutorial part 1](https://learn.unity.com/tutorial/recorded-video-session-text-adventure-game-part-1#) and [part 2](https://learn.unity.com/tutorial/recorded-video-session-text-adventure-game-part-2#) to create the basic framework for this project.

## Multimedia Tools

> What tool(s) do you hope to learn (or become more proficient at) over the course of this project?

Unity Engine, C#, Visual Studio Code

> How familiar are you with your chosen tools?

I have used Unity for around 2 years, but most of what I know has been self-taught
and I am not familiar with the tool to the extent that I am using it every day. I have
never created a 2D game in Unity before, and I have yet to dive into text-parsing
programming as opposed to OOP.

> How proficient do you expect to become via using your tools by the end of the semester?

Unity is quite a complex tool that has a lot of options that are out of scope for this
project. Thus, I will be mostly scratching the surface of Unity’s full capabilities, 
although I will be focused primarily on the 2D Sprite/Canvas options the engine
provides to display images/interact with text.

> What do you imagine your final project deliverable(s) will be based off the tool(s) you use to create it?

My final project deliverable will be a short demo (5~ minutes?) of a text adventure
game (in the form of a Unity executable). Its exact length is incredibly dependent on
time available. 

> Do you think your stated final deliverable(s) are fair?

Yes. Games are often over-scoped and this one is no different. I would be very glad
to get a working and polished 5 minute demo by then. I expect the project to likely
take more than 2 hours per week, so scoping down may be necessary.

## Target User Group

> Who is your target user group?

People who enjoy games, particularly young adults who
are familiar with and enjoy indie game culture. A more niche audience overall—
people who like text adventure games, but who desire a little more visual/auditory
stimulation than plain text.

> Why are they your chosen target user group?

I believe, through some experience in games as well as a hunch, that this would be a
good user group to look for. Indie games garner a very specific audience, unlike
large budget AAA games who target mass populations. People who like indie games 
often are incredibly passionate about the games they play and thus have some sort
of emotional connection to them.

## Motivation & Goals

> What is your motivation for creating this project?

I am part of an indie company called Harbored Games LLC and we are planning to launch our title March 2020.  
I have worked on this game for two years and have come
to despise it.  I would like to try to make a game that I personally will enjoy working on, without having to worry about processing an official licensed release.

> What is your purpose?

My goal is to create a working demo of my game that is playable, polished, and representative of a potentially larger game in the future should I decide to continue the project.

> What are your initial plans on how to tackle doing research for your project?

Using what I know from my degree and experience in the industry.
There are lots of resources for playtesting and getting feedback from peers. I will be
looking to youtube for tutorials and tips on how to work the code and look at other
references for examples of good, engaging writing and puzzle design.

> What outcomes are you hoping for and/or foresee taking place?

I would like to see my project as something I can put on my portfolio, as well as
something I can happily point to when asked about my likes. I hope my target user
group finds a fun and engaging experience, regardless of how long or short the end
product may be. Sometimes even the shortest experiences, if they’re good, stick with
those who were able to enjoy them. 

# Controls
Enter the Dungeon uses entirely text-based controls. Typing controls follow a verb-noun format.
There are 5 primary input methods that allow the user to perform every action they need to complete the game.

 - Go 
`Allows the user to move between rooms by designating one of the four cardinal directions (north, south, east, west).`
 - Examine
 - `Allows the user to look at objects of interest and get more information. Used to provide hints to solve any given puzzle.`
 - Take
 - `Allows the user to take objects from rooms and add them to their inventory. Items cannot be used unless they are in the player's  possession.`
 - Use
 - `Allows the player to use items to unlock doors or reveal other secrets, provided they are in the correct room and are using the correct item.`
 - Inventory
 - `Displays every item that the player has taken and not used. Used items will be removed from the inventory. If an item is in the player's inventory, they can still examine it as if it were still inside of a room.`
 - 
# Puzzle Design
For this project I decided to utilize a design formula I have developed for creating a lock-and-key puzzle structure. This structure involves a core, linear path that the player follows all the way to the end (think of a straight line, or the trunk of a tree). That is, the player's path through the game, inevitably, is a linear experience. However, each section of this tree trunk is divided up into parts, and these parts can be stacked on top of one another to create a more modular way of designing. For example, the Start Room is the bottom section of the trunk, and features the easiest puzzle: `take key` -> `use key` -> `go north`. This immediately leads to the End Room, which has no puzzle and simply concludes the game.

The trunk of this puzzle tree can now be elongated (or shortened) as much as is needed, thus allowing the game to always be in somewhat of a 'completed' state but easily built upon.  Furthermore, to introduce more complexity into the puzzles, each section of trunk can have a limitless amount of 'branches'. In this case, the Start Room, Section 1, is a section of trunk with no branches. Section 2, however, is a section of trunk with one branches, with branches following the formula `# of branches = # of keys needed to complete the section - 1`. For example, Section 1 needs 1 key to complete it, `1-1 = 0` branches. Section 2 needs 2 keys to complete it (drawbridge lever, gargoyle eye), `2-1 = 1` branch. 


## Section 1 - Start

# Process
I began this project on January 20th, 2020, which began as a few sketches of ideas in my notebook. At first I thought of making a 2D point-and-click puzzle game. I was very into games such as [Deep Sleep](https://scriptwelder.itch.io/deep-sleep) and [Don't Escape: 4 Days to Survive](https://dont-escape.com/) by *scriptwealder*, and started writing up some notes in my sketchbook seen here:
![Page1](https://github.com/Headlesser/enterthedungeon/raw/master/images/p3.png "My first idea for the game")

In addition to this I thought about the idea of a non-game related project. I wanted to make a python application for storing character information in a sort of digital encyclopedia where artists, writers, or other story-creators could store all their bios and narrative design notes.

![Page2](https://github.com/Headlesser/enterthedungeon/raw/master/images/p2.png "Character encyclopedia idea")

My third idea is inevitably the one I settled on, which came to fruition after trying to think of a way to scope down the point-and-click puzzle game idea.

![Page3](https://github.com/Headlesser/enterthedungeon/raw/master/images/p1.png "My first idea for the game")

After solidifying my idea, I began work on creating the framework for this game by following Unity's online learning Text Adventure tutorial series. Seeing as this is a project to stress puzzle creation and writing skills, I did not want to have to spend too long debugging or creating game code. 

After completing the Unity tutorial I began taking notes on a list of adjustments and additions I wanted to make to the basic framework before continuing forward. I know I wanted to have image and audio support at the very least, which I knew I would have to expand upon myself as the tutorial only provided the textual functionality. To accomplish this, I made a few small changes to the tutorial code which can be found here.

## Technical Documentation
### Adding Image Support
In Room.cs I added a public Sprite variable `sprite` which would store the image representing the layout of whatever particular room object it is assigned to. This is essentially extending off of the variables the tutorial had already designated (`description`, `roomID`, etc).

```csharp
public  class  Room : ScriptableObject
{
//Scriptable Object
//Never get attached to game objects, exist as assets and run in memory, etc.
[TextArea]
public  string  description;
public  string  roomID;
public  Exit[] exits;
public  Sprite  sprite;
//Make it so this variable stores the 'image' of the room. Will change as player moves to
//different rooms.
public  InteractableObject[] interactableObjectsInRoom;
//Items found in the room that can be picked up/interacted with
}
```
To complete this functionality I also had to make a few small additions to GameController.cs. I declared a public Image `roomImage` which is assigned through script to call the room's `sprite`, thus displaying the correct image when moving between rooms. I created a small function to perform this action,
```csharp
public  void  DisplayRoomImage()
{
roomImage.sprite = roomNavigation.currentRoom.sprite;
}
```
and then added a call to it much like the system the tutorial set in place for displaying a room's `description` value when entering a new area.
```csharp
void  Start()
{
DisplayRoomText();
DisplayLoggedText();
DisplayRoomImage();
}
```

### Adding Audio Support

### Debugging `Use` Functionality
One issue I ran into after finishing the tutorial was that it did not initialize the `use` functionality that I had expected. A problem arose where, after the player would 'use' a particular item in their inventory, it would remain listed in their inventory after they would use it. This action also did not utilize the `textResponse` value that `take` and `examine` would, wherein after the player performs either of these inputs (for example: `take key`), the text logger would return that `InputAction`'s `textResponse`.

To fix the but involving the listing of items in the inventory, I revisited InteractableItems.cs and tried to find the section of code I would have to add to. I had difficulty navigating which script to work in at first due to the fact that following a tutorial essentially means you are trying to work on code someone else has created for you. I was able to read through the setup of classes and eventually made a small addition to ChangeRoomResponse.cs,
```csharp
public  override  bool  DoActionResponse(GameController  controller, string[] separatedInputWords)
{
if(controller.roomNavigation.currentRoom.roomID == requiredString)
{
	controller.roomNavigation.currentRoom = roomToChangeTo;
	controller.interactableItems.nounsInInventory.Remove(separatedInputWords[1]); //Added this
	controller.DisplayRoomText();
	return  true;
}
return  false;
}
```
where I simply added in a line that, upon the player using an item in the correct room, would remove that item from their inventory list after use. This, I thought, would make it less confusing to the player as to what items they had on hand, and also make the inventory list less populated with unnecessary information.

To fix the issue with `textResponse` not working with the `use` action, I first went back and revisited the definitions and set-up for the `take` and `examine` `InputActions` so I could reverse-engineer the same functionality that I wanted in `use`. Following a similar process to the first problem, I adjusted ChangeRoomResponse.cs and added
```csharp
controller.LogStringWithReturn(controller.TextVerbDictionaryWithNoun(controller.interactableItems.useDictionaryResponse, separatedInputWords[0], separatedInputWords[1])); 
```
to
 ```csharp
DoActionResponse()
```
as well, which logged the `textResponse` value identical to the way `take` and `examine` had been initially set up.

# Art and Visuals

# Assets
[An excel document containing the list of assets per section can be found here.](https://docs.google.com/spreadsheets/d/1_scVRSXG6_j4dud2x9jJDUqPNOE1y2HsckKVOYKUXjU/edit?usp=sharing)

# To Do List
 - Make it so text does not scroll infinitely up over the sprite. 'Lock' size of the text area, make scroll bar.
 - Create art assets for section 1
 - Create audio assets for section 1
 - ~~Make it so you can ONLY examine an item if it is either PRESENT IN THE CURRENT ROOM or IS IN YOUR INVENTORY. If an item is ever used, it should be REMOVED from all dictionaries and cannot be examined. If player returns to a room where they took an item, they should NOT be able to examine the 'ghost' of that item.~~
 - - ~~Create map layout for section 1.~~
 - ~~Make it so, after using an item, it doesn't repeat the old room description again? (Replace it w/ the new one after triggering an event. I will have to clear the log before printing).~~
 - ~~Make sure sprite sizes are standardized.~~

# Sources
### 2/02/2020
Full Unity Text Adventure tutorial
https://learn.unity.com/tutorial/recorded-video-session-text-adventure-game-part-1
Youtube Playlist version:

 - [Part 1 Section 1](https://www.youtube.com/watch?v=jAf1I1UWo5Q&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4)
 - [Part 1 Section 2](https://www.youtube.com/watch?v=dQ4jcxKwXM8&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=2)
 - [Part 1 Section 3](https://www.youtube.com/watch?v=TP4gLQmKOLo&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=3)
 - [Part 1 Section 4](https://www.youtube.com/watch?v=-LlAahTMtjw&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=4)
 - [Part 1 Section 5](https://www.youtube.com/watch?v=m7Sl9NLv4HI&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=5)
 - [Part 1 Section 6](https://www.youtube.com/watch?v=g9Pjv-BWpso&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=6)
 - [Part 1 Section 7](https://www.youtube.com/watch?v=XLDrIBaxHKg&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=7)
 - [Part 1 Section 8](https://www.youtube.com/watch?v=Mb7SHYZ65Xo&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=8)
 - [Part 2 Section 1](https://www.youtube.com/watch?v=Bak8azAM_cA&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=9)
 - [Part 2 Section 2](https://www.youtube.com/watch?v=_6vqKgIwv18&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=10)
 - [Part 2 Section 3](https://www.youtube.com/watch?v=PJmodQ1VG0A&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=11)
 - [Part 2 Section 4](https://www.youtube.com/watch?v=BrKzV0M3o_Q&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=12)
 - [Part 2 Section 5](https://www.youtube.com/watch?v=MNe2WMFL3EA&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=13)
 - [Part 2 Section 6](https://www.youtube.com/watch?v=-adAYJTf288&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=14)
 - [Part 2 Section 7](https://www.youtube.com/watch?v=kzMJWWI3Lrw&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=15)
 - [Part 2 Section 8](https://www.youtube.com/watch?v=G7c0x7ibjQ0&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=16)
 - [Part 2 Section 9](https://www.youtube.com/watch?v=SqoPJ2-gDwc&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=17)
 - [Part 2 Section 10](https://www.youtube.com/watch?v=WewuY--upVw&list=PLX2vGYjWbI0RfcpqpKlmLEy7NteIog8g4&index=18)
