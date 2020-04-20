
# EnterTheDungeon

This file contains the documentation for Enter the Dungeon.

# Table of Contents

## Introduction
[Overview](#overview)

[Proposal](#proposal)

## Controls
[Control Map](#controls-1)

## Puzzle Design
[Puzzle Documentation](#puzzle-design-1)

[Section 1 - The Start](#section-11--section-12)

[Section 2 - Going Deeper](#section-2)

[Solution](#solution)

## Process
[Process](#process-1)

[Technical Documentation](#technical-documentation)

[Art Documentation](#art-and-visuals)

[Playtesting](#playtesting-notes)

[To-Do](#to-do-list)

## Asset List
[Assets](#assets)

## Sources
[Sources](#sources-1)



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
product may be. I would rather end up with a completed project than an unfinished project that is longer. 

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
 
# Puzzle Design
For this project I decided to utilize a design formula I have developed for creating a lock-and-key puzzle structure. This structure involves a core, linear path that the player follows all the way to the end (think of a straight line, or the trunk of a tree). That is, the player's path through the game, inevitably, is a linear experience. However, each section of this tree trunk is divided up into parts, and these parts can be stacked on top of one another to create a more modular way of designing. For example, the Start Room is the bottom section of the trunk, and features the easiest puzzle: `take key` -> `use key` -> `go north`. This immediately leads to the End Room, which has no puzzle and simply concludes the game.

The trunk of this puzzle tree can now be elongated (or shortened) as much as is needed, thus allowing the game to always be in somewhat of a 'completed' state but easily built upon.  Furthermore, to introduce more complexity into the puzzles, each section of trunk can have a limitless amount of 'branches'. In this case, the Start Room, Section 1, is a section of trunk with no branches. Section 2, however, is a section of trunk with one branches, with branches following the formula `# of branches = # of keys needed to complete the section - 1`. For example, Section 1 needs 1 key to complete it, `1-1 = 0` branches. Section 2 needs 2 keys to complete it (drawbridge lever, gargoyle eye), `2-1 = 1` branch. 


## Section 1.1 & Section 1.2
I put the first section into two parts as a 'section' is defined by moving up the 'trunk' of the puzzle tree. Section 1.1, although one room long, moves directly up the trunk of the tree (no branches), so I define it as one very small section. The stars on this diagram represent 'keys' needed to enter another room. Stars found within rectangles indicate that key is found within that room. Stars on lines indicate that specific key is needed to reach the connecting room.
![Diagram1](https://github.com/Headlesser/enterthedungeon/raw/master/images/diagram_section_1.png)

## Section 2
Section 2 is a larger puzzle with twice as many rooms. Having finished this section, going forward, I think I will try to keep the room count to a minimum, as setting up alternate versions of rooms take an exceptionally long time and makes the implementation process difficult. This section is intended to play upon the strangeness of the dungeon a bit more as certain objects or things that need to be bypassed and used are not as conventional as they were in the first section (eg. using mucous for 'glue').
![Diagram2](https://github.com/Headlesser/enterthedungeon/raw/master/images/diagram_section_2.png)

## Solution

Below is the walkthrough for the solutions to both sections 1 and 2. They will not include any steps involving the 'examine' keyword.

### Section 1 Solution
In the room with the locked gate
- Take `key`
- Use `key`
- Go `north`
	
In the gargoyle room
- Go `west`
	
In the skeleton room
- Take `rod`
- Go `east`
	
In the gargoyle room
- Go `east`
	
In the bridge room
- Use `rod`
- Go `north`
	
In the pedestal room
- Take `gemstone`
- Go `south`
	
In the bridge room
- Go `west`
	
In the gargoyle room
- Use `gemstone`
- Go `north`
	

*Section 1 complete*

### Section 2 Solution
*Note: It is technically possible to finish the puzzle in more than one exact order. This is the most straight forward one that takes the least amount of backtracking.*
*Note 2: I had testers check for bugs or game-breaking solutions and have fixed as many as I could find. If you encounter a bug that prevents you from going forward, it was one I was unable to find or replicate. If you remember the order in which you moved, please send me a note about it! Following the instructions below should lead to a successful victory.*

In the hallway
- Go `north`
	
In the main gate room
- Take `torch`
- Go `east`
	
In the ring room
- Take `ring`
- Go `west`
	
In the main gate room
- Go `west`
	
In the tree room
- Go `west`
	
In the circular doorway room
- Use `ring`
- Go `north`
	
In the incubation room
- Use `torch`
- Take `mucous`
- Go `south`
	
In the circular doorway room
- Take `keystone`
- Go `east`
	
In the tree room
- Go `east`
	
In the main gate room
- Go `east`
	
In the ring room
- Use `keystone`
- Go `east`
	
In the tool room
- Take `shovel`
- Take `branch`
- Go `west`
	
In the ring room
- Use `shovel`
- Go `north`
	
In the axe room
- Use `mucous`
- Use `branch`
- Take `axe`
- Go `south`
	
In the ring room
- Go `west`
	
In the main gate room
- Go `west`
	
In the tree room
- Use `axe`
- Take `meat`
- Go `east`
	
In the main gate room
- Use `meat`
- Go `north`

*Section 2 complete*


# Process
I began this project on January 20th, 2020, which began as a few sketches of ideas in my notebook. At first I thought of making a 2D point-and-click puzzle game. I was very into games such as [Deep Sleep](https://scriptwelder.itch.io/deep-sleep) and [Don't Escape: 4 Days to Survive](https://dont-escape.com/) by *scriptwealder*, and started writing up some notes in my sketchbook seen here:
![Page1](https://github.com/Headlesser/enterthedungeon/raw/master/images/p3.png "My first idea for the game")

In addition to this I thought about the idea of a non-game related project. I wanted to make a python application for storing character information in a sort of digital encyclopedia where artists, writers, or other story-creators could store all their bios and narrative design notes.

![Page2](https://github.com/Headlesser/enterthedungeon/raw/master/images/p2.png "Character encyclopedia idea")

My third idea is inevitably the one I settled on, which came to fruition after trying to think of a way to scope down the point-and-click puzzle game idea.

![Page3](https://github.com/Headlesser/enterthedungeon/raw/master/images/p1.png "My first idea for the game")

After solidifying my idea, I began work on creating the framework for this game by following Unity's online learning Text Adventure tutorial series. Seeing as this is a project to stress puzzle creation and writing skills, I did not want to have to spend too long debugging or creating game code. 

After completing the Unity tutorial I began taking notes on a list of adjustments and additions I wanted to make to the basic framework before continuing forward. I know I wanted to have image and audio support at the very least, which I knew I would have to expand upon myself as the tutorial only provided the textual functionality. To accomplish this, I made a few small changes to the tutorial code which can be found [here](#technical-documentation).

After reaching the halfway point of the project (approximately 7 weeks in), I went back and reviewed my work thus far. I created a brief presentation to describe my progress, concerns, and questions to address for the final sprint, which can be viewed [here](https://github.com/Headlesser/enterthedungeon/raw/master/documentation/midwayreview.pdf). I found it to be incredibly helpful to create a [To-Do](#to-do-list) list section for myself to help me keep track of what tasks I had to finish, as well as to help pace myself so I could visually see how much progress I am making each week. I would give myself approximately 2-3 specific, concrete tasks to finish each week as a way to keep from falling behind and better estimate how much time I have left to complete what I intend, and make adjustments should the workload prove to be too much.

### As of March 23rd, I had completed the first puzzle section of the game. All subsequent sections will be developed during the coronavirus epidemic in a work-from-home environment.

After quarantine began, progress on the game slowed a bit as adjustments had to be made. Playtesting became increasingly difficult as, while online playtesting was possible, being able to speak in person and watch players react to certain things (or more importantly, not interact at all) is incredibly helpful information that I could no longer accurately collect. That being said, I made the switch to online testing and returned with helpful feedback before moving on to designing section 2. Some of the most important information I gathered involved:
	- Players unable to read the text because it was too small/the color was too dark
	- Players unable to read some text because they picked up something and you cannot scroll the text back up
	- Players forgot some of the controls and wanted a reference
	- First puzzle was fairly easy but sparked curiosity to play more

With this information from my round of online playtests, I made some adjustments to the text, added a 'main menu' and also a few new commands that players can type in (like key words) to reference controls, re-print room text, and even quit the game. I did it this way because I wanted the game to remain true to the text adventure style, rather than adding a full-fledged menu system with sprites/buttons.

After designing section 2 I also ran a second series of playtests with some of the same people and some new with a focus on finding bugs and determining the difficulty of the puzzle. Overall feedback in regards to the puzzle and art was good, though more adjustments had to be made to the text and a few bugs related to room organization had to be fixed to prevent a 'soft lock' (that is, the player could not continue forward due to doing something in the 'wrong' order).

Rewinding a bit: I began the design work for section 2 in the beginning of April, and sketched out a rough idea (seen below) which was eventually adjusted into the final design.

![Initial design for section 2](https://github.com/Headlesser/enterthedungeon/raw/master/images/section_2_sketch.png "Initial design for section 2")

I tried to separate my design into a few different lists: one for ```ActionResponses```, one for Items, and a map to visualize the overall layout of the dungeon.

While implementing and creating all the assets for section 2, I ran into an unsuspected number of issues, most of which pertained to the organization of rooms. Whenever a player uses an item and 'teleports' (or 'unlocks' something) to a new room, every other room must be given an 'alternate' version of itself that leads to that new, 'unlocked' version of the room. This exponentially grew the number of ```Room``` objects I had to create, and made it hard to keep track of which rooms were attached to which exits. I tried to sketch out the problem first to try and understand it better, as seen below.

![Sketch of rooms](https://github.com/Headlesser/enterthedungeon/raw/master/images/section_2_keypaths.png) "Sketch of how a 'new' map had to be made every time an item was used"

Eventually, I made a series of folders in my project to separate each map of rooms into even smaller sections which can also be seen below.

![Directories](https://github.com/Headlesser/enterthedungeon/raw/master/images/room_organization.png) "Inspector directories"

While still difficult, this made it easier to keep track of which rooms connected to which exits, and helped separate the problem into smaller chunks rather than filing through a giant list of room objects, searching for the one that had the wrong connections.

After finishing the design for puzzle 2 and writing the descriptions, I was informed that my audio designer could not make any more tracks for me due to other responsibilities. For section 2 I had to resort to re-using other tracks and mixing a few of my own using free tracks from freesound.org. I also did not have enough time to go back and add more 'clutter' items to the puzzles (items that do nothing, but can be examined none the less) due to all the time spent debugging rooms and making the audio clips.

As this project reaches its 'academic' deadline, I am glad to have completed two whole sections with a few elements of polish, having essentially reached my goal of completing a playable demo as stated in my proposal. If I continue the project into the summer, I plan on making another pass at all the dialogue, adding clutter elements, remixing some better sounds, and adding more sections.



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
Similar to above, in Room.cs I added a new reference for a public AudioClip variable `audio`, which will store the audio file that is to be played in the particular room it is assigned to.
```csharp
public AudioClip audio;
    //This variable stores the soundtrack of the specific room it is assigned to. Should fade in/out and 
    //change to the next looping clip as player moves between rooms.
```
There were a few small changes I also had to make between incorporating audio and how I incorporated image support. For example, I also wanted the `use` action to be accompanied by a sound, indicating to the player that they successfully did something or made some kind of change to the room. For this, I went into ChangeRoomResponse.cs and added a second public variable `public AudioClip actionSound`, which would store the sfx to play whenever the `use` InputAction specifically was successful.
```csharp
public  AudioClip  actionSound;
```
Additionally, I added a brief statement within `DoActionResponse` which is set up to play `actionSound` one time rather than looping.
```csharp
if(actionSound != null)
{
	controller.actionAudioSource.PlayOneShot(actionSound);
	//actionSound = null; to remove the old sound?
	//Plays the 'activation' sound ONCE.
	//This will only be for the 'use' functionality
	//Things such as jingling of key, scraping gargoyle statue, etc. Stuff that indicates 'that input was successful'
	//Put within a != null statement in case any room happens to not have an audio clip.
}
```
I put it within an `if` statement in the event that a `use` action, for whatever reason, doesn't have a sfx attached to it.

Furthermore, within Navigation.cs, I incorporated two extra lines within `AttemptToChangeRooms` which would update and play the correct image/audio clip if moving to a room was successful.

```csharp
public void AttemptToChangeRooms(string directionNoun)
{
	if(exitDictionary.ContainsKey(directionNoun))
	{
		//move to the next room if text was correct
		currentRoom = exitDictionary[directionNoun];
		controller.LogStringWithReturn("You go " + directionNoun);
		controller.DisplayRoomText();
		controller.DisplayRoomImage(); //Add image transition
		controller.PlayRoomSound(); //Add audio transition
}
```

Then finally, in GameController.cs, I added two variables to store the `AudioSource` components that would be responsible for playing the assigned sound. Since I wanted both background music and an sfx for `use` to be playing at the same time, I created a separate empty game object as a child to GameController and gave it an `AudioSource` component. This object `ActionAudioSource` would store the information for the `use` audio clip, while GameController's `AudioSource` component would track the audio information for `room`s.

```csharp
public AudioSource audioSource;
public AudioSource actionAudioSource;

void Awake()
{
interactableItems = GetComponent<InteractableItems>();
roomNavigation = GetComponent<Navigation>();
audioSource = GetComponent<AudioSource>(); //GameController's audio source
actionAudioSource = GetComponentInChildren<AudioSource>(); //ActionAudioSource's audio source
}

void Start()
{
DisplayRoomText();
DisplayLoggedText();
DisplayRoomImage(); //Change the room's image
PlayRoomSound(); //Play the room's music
}

...

public void PlayRoomSound()
{
//Set the audio clip to play to the room's audio clip
//Debug.Log(roomNavigation.currentRoom.audio);
audioSource.clip = roomNavigation.currentRoom.audio; //Set the GameController's audioClip value to the current room's audioClip
audioSource.Play(); //Play the clip, looping.
}
```

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

### Debugging & Adding 'ActionResponses' to the 'Take' Keyword
One mechanic that I wanted to implement for the final stretch of this project was allowing other keywords, not just `use`, to allow for ActionResponses. That is, I wanted the `Take` keyword to have the ability for events to occur. Specifically, I wanted to be able to have a room's sprite change after taking an item from it, to visualize the act of taking something and make it clearer for the player (such as taking the shovel from the room in section 2).

This proved difficult at first as originally I tried expanding on the ```ActionResponse``` logic itself by creating a new class inheriting from ```ActionResponse``` that was almost identical to `ChangeRoomResponse`.

```
public class ChangeRoomImage : ActionResponse
{
    public Sprite changeImageTo;
    public AudioClip actionSound;
    //The sound to play after performing the use action.

    public override bool DoActionResponse(GameController controller, string[] separatedInputWords)
    {
        if(controller.roomNavigation.currentRoom.roomID == requiredString)
        {
            controller.roomNavigation.currentRoom.sprite = changeImageTo; //problem, does not reset the images to their original ones after testing.
            controller.LogStringWithReturn(controller.TextVerbDictionaryWithNoun(controller.interactableItems.takeDictionary, separatedInputWords[0], separatedInputWords[1]));
            controller.DisplayRoomImage();
            //Debug.Log("Took the item, change the image");

            if(actionSound != null)
            {
                controller.actionAudioSource.PlayOneShot(actionSound);
                //actionSound = null; to remove the old sound? 
                //Plays the 'activation' sound ONCE.
                //This will only be for the 'use' functionality
                //Things such as jingling of key, scraping gargoyle statue, etc. Stuff that indicates 'that input was successful'
                //Put within a != null statement in case any room happens to not have an audio clip.
            }
            return true;
        }
        return false;
    }

}
```

As I worked, however, I concluded that this was a bit overkill for what I wanted to accomplish. Instead, I made a small function in the ```InteractableItem``` script,

``` 
public void ChangeImage(string noun)
    {
        //Debug.Log("begin change image...");
        //check it the old fashioned way. If the noun given was taken, change the current room's sprite value
        //ONLY IF that object is supposed to.
        InteractableObject target = GetInteractableObjectFromUsableList(noun);
        //Debug.Log(target + " This is the object found.");
        if(target.changeSprite == true)
        {
            //Debug.Log("This object is set to true to switch images");
            controller.roomNavigation.currentRoom.sprite = target.changeTo;
            controller.DisplayRoomImage();
            //Debug.Log("Change the image.");
        }
    }
  ```
and made a small addition to the ```InteractableObject``` class,

```
public class InteractableObject : ScriptableObject
{

    public string noun = "name";
    [TextArea]
    public string description = "Description of item in the room";
    public Interaction[] interactions;
    public bool changeSprite; //This variable is ONLY true if the item needs to have its image changed

    public Sprite changeTo; //This variable is ONLY used if the particular item needs to have an image changed

}
```

to have a boolean that checks whether or not this object should trigger a sprite change, and a sprite object that stores an image to 'change to' should that be true.

# Art and Visuals
The visual aesthetic of Enter the Dungeon is intended to be simple, pixelated and and primarily restricted to a color palette of black and white only (with some few exceptions). I inevitably decided on this approach due to the time constraints on the project and estimating ahead of time how long I thought I would have to both complete the tutorial, build upon it, design puzzles, and incorporate art and sound within a roughly 3 month period.

 I looked at classic text-based games such as Zork, and other games such as Undertale, The Oregon Trail, etc for reference while exploring different options.

 - [Screenshot from Zork](https://www.mobygames.com/game/apple2/zork-the-great-underground-empire/screenshots/gameShotId,305672/). I know I wanted a similar setup with white text on a black background.
![zork](https://github.com/Headlesser/enterthedungeon/raw/master/images/zork.png "Screenshot of the introduction in Zork")

 - [Screenshot from The Oregon Trail](https://classicreload.com/oregon-trail.html?__cf_chl_captcha_tk__=cb1462cf9da207f8e5900c80be6efb68a1d3e319-1583281001-0-ARbV5-5zHTjJ-CI3KctSuhVV0C3Ta38QGyMnjdGbsAxYzVIAY1k1JOU7zvyckd-ifHNgOFo8RPkmYNrvpJuVJN2oxzn_zPuxjCopCUw08DsV2njfdHPvSjYRxUscAMx3kY4DQjJ6qjrcNwnJR8tCdWER1tlAxZ339XdYn9Da9Hf1Ud3vOJHUM-FsxgoIZG1N3pEPKlL-1uFiMkDhskrtqPXSXJkiEBi4tyHnSWVlzx0JBnRTlpPtspsjhTgj7_oTNx-3FKOHRSkiCzWX1HgWiSPQhb3XJJKNmV6qNJYWd11PG_yLVlOnLOgcDVGJWekaQl6EwhhoWYaKNRCMLaP-_1MGEN5-MaLmAIVBOu-ZwpcUtYxWkMvewVb5-_jKNXwFmTy2ZGOVecROXLv0VGOu65tbBuQZ5jzClcZiDLTrFvaKfSN9CpfNPLw-UsCfQnAELIBAwLSsEFgovwXeP4w7tYHe2YZfnptpGHMmjhFLdTcr5X93Xm-JD6O4zziCaR5WEvBmFTuAtSHAUGC8kxasXIg). I knew I didn't want to have art as detailed as shown, but the overall organization of the screen with interactions on the bottom and image on the top was what I wanted to go for.
![oregontrail](https://github.com/Headlesser/enterthedungeon/raw/master/images/oregontrail.png)
 
 - [Screenshot from Undertale](https://www.kotaku.com.au/2015/12/undertale-as-told-by-123-screenshots/). Again, I liked the layout of the screen, with text on the bottom and the image on top, which would change depending on where you were in the game.![undertale](https://github.com/Headlesser/enterthedungeon/raw/master/images/undertale.jpg)

I began work making some sprites and decided that rather than create an entire layout of a room, I would only draw what was absolutely necessary for the player to see visually, as I did not want the writing to be given a back seat. I also thought that this would be a good idea because it could help players recognize exactly what items or objects were important, which would, in turn, allow them to better understand the layout of their surroundings and potentially give visual clues as to the solution of a puzzle.

For example, the start room is the simplest puzzle: the player must pick up a key, and use it on the door so they can leave the room. For this, I decided that the only real important thing to show was the door with a keyhole, indicating that the key they pick up must go to this door (although it is hard to skip over regardless considering there are no other options to take).

![Start Room Sprite](https://github.com/Headlesser/enterthedungeon/raw/master/images/Door.png)

# Assets
[An excel document containing the list of assets per section can be found here.](https://docs.google.com/spreadsheets/d/1_scVRSXG6_j4dud2x9jJDUqPNOE1y2HsckKVOYKUXjU/edit?usp=sharing)

[Links to audio used in testing and final product can be found here.](#audio)

# Playtesting Notes
First playtest session conducted with 4 adults ages 22-30. Mixed familiarity with experience playing games.
- Scraping stone sound doesn't stop after leaving the final room
- One player did not like item descriptions in room appearing below exit descriptions, 'were easy to forget about or miss'
- Players complained about the text being too small or too dark to read
- The puzzle was easy
- Players wanted more objects to look at that may or may not have anything to do with the puzzle itself (clutter items/flavor text)
- Players enjoyed the audio, though some placeholder tracks were too loud/were not cut properly

# To Do List
 - POSTMORTEM ESSAY
 - FINISH DOCUMENTATION (INDICATE COVID AND ANY POSSIBLE BUGS, AS WELL AS THE SOLUTION TO THE GAME)
  	- Add maps for all puzzle sections (1 and 2)
  	- Attribute Justin for audio clips
  	- Attribute playtesters (Dylan, Gaby, Mara)
  	- Add notebook notes to process & discuss them
  	- State how COVID made playtesting/feedback resources difficult to acquire
  	- ~~Add citations for unity tutorials, 'designing puzzles' video~~
 - ~~Design section 2 puzzle~~
 - Create audio assets for section 2
 - ~~second pass text for section 2~~
 - third pass text for section 2
 - ~~Second pass text for section 1~~
 - ~~Ditch scrollbar idea, have 'typewriter text'. Ask for help w/ this.~~
 	- Decided against any text effects
 - ~~Create audio assets for section 1~~
 - ~~Finalize goals for deadline submission (3 completed sections)~~
 	- Had to cut down to 2 completed sections
	
*Covid-19 quarantine began around here. All items above this note were completed while quarantine was in effect*

 - ~~Fix things w/ playtest 1 feedback~~
 - ~~Make it so text does not scroll infinitely up over the sprite. 'Lock' size of the text area, make scroll bar.~~
 - ~~Create art assets for section 1~~
 - ~~Make it so you can ONLY examine an item if it is either PRESENT IN THE CURRENT ROOM or IS IN YOUR INVENTORY. If an item is ever used, it should be REMOVED from all dictionaries and cannot be examined. If player returns to a room where they took an item, they should NOT be able to examine the 'ghost' of that item.~~
 - - ~~Create map layout for section 1.~~
 - ~~Make it so, after using an item, it doesn't repeat the old room description again? (Replace it w/ the new one after triggering an event. I will have to clear the log before printing).~~
 - ~~Make sure sprite sizes are standardized.~~

# Sources
### Tutorials
[Unity Documentation & User Manual](https://docs.unity3d.com/Manual/index.html)
[Full Unity Text Adventure tutorial](https://learn.unity.com/tutorial/recorded-video-session-text-adventure-game-part-1)

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
 
 [Unity Tutorial for Typewriter Effect](https://www.youtube.com/watch?v=1qbjmb_1hV4)
 [Youtube video on puzzle design tips](https://www.youtube.com/watch?v=EDt6XXsRXag)
 
 ### Images
 [Screenshot from Zork: The Great Underground Empire](https://www.mobygames.com/game/apple2/zork-the-great-underground-empire/screenshots/gameShotId,305672/)
 
 [Screenshot from Undertale](https://www.kotaku.com.au/2015/12/undertale-as-told-by-123-screenshots/)
 
 [Screenshot from The Oregon Trail](https://classicreload.com/oregon-trail.html?__cf_chl_captcha_tk__=cb1462cf9da207f8e5900c80be6efb68a1d3e319-1583281001-0-ARbV5-5zHTjJ-CI3KctSuhVV0C3Ta38QGyMnjdGbsAxYzVIAY1k1JOU7zvyckd-ifHNgOFo8RPkmYNrvpJuVJN2oxzn_zPuxjCopCUw08DsV2njfdHPvSjYRxUscAMx3kY4DQjJ6qjrcNwnJR8tCdWER1tlAxZ339XdYn9Da9Hf1Ud3vOJHUM-FsxgoIZG1N3pEPKlL-1uFiMkDhskrtqPXSXJkiEBi4tyHnSWVlzx0JBnRTlpPtspsjhTgj7_oTNx-3FKOHRSkiCzWX1HgWiSPQhb3XJJKNmV6qNJYWd11PG_yLVlOnLOgcDVGJWekaQl6EwhhoWYaKNRCMLaP-_1MGEN5-MaLmAIVBOu-ZwpcUtYxWkMvewVb5-_jKNXwFmTy2ZGOVecROXLv0VGOu65tbBuQZ5jzClcZiDLTrFvaKfSN9CpfNPLw-UsCfQnAELIBAwLSsEFgovwXeP4w7tYHe2YZfnptpGHMmjhFLdTcr5X93Xm-JD6O4zziCaR5WEvBmFTuAtSHAUGC8kxasXIg)
 
 ### Audio
 [Wind audio clip from freesound.org](https://freesound.org/people/florianreichelt/sounds/459977/)
 
 [Water dripping audio clip from freesound.org](https://freesound.org/people/IPaddeh/sounds/422873/)
 
 [Stone sliding audio clip from freesound.org](https://freesound.org/people/Rooms_Boxes/sounds/424169/)
 
 [Rushing water audio clip from freesound.org](https://freesound.org/people/eardeer/sounds/443869/)
 
 [Testing 'beep' audio clip from freesound.org](https://freesound.org/people/thisusernameis/sounds/426888/)
 
 [Wind chimes audio clip from freesound.org](https://freesound.org/people/MrCisum/sounds/336664/)
 
 [Key jingling audio clip from freesound.org](https://freesound.org/people/Joao_Janz/sounds/485116/)
 
 [Metallic cranking audio clip from freesound.org](https://freesound.org/people/arnaud%20coutancier/sounds/468500/)
 
 ### Attributions
 *Justin Hatfield - Sound Designer - Created ambient dungeon and water rapids audio tracks*
 
 *Gaby Benninghoff - Playtester - Gave good advice during the design process and also playtesting feedback*
 
 *'Mara' Christie - Playtester - Gave good feedback for playtesting online*
 
 *'Janet' Dylan - Playtester - Gave good feedback for playtesting online*
 
 *Jordan Hannon - Classmate - Had good discussions with him when class was in-person and also gave good feedback*
