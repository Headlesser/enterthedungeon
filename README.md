# EnterTheDungeon

This file contains the documentation for Enter the Dungeon.

# Table of Contents

## Introduction
[Proposal](#proposal)

[Overview](#overview)

## Controls
[Control Map](https://github.com/Headlesser/enterthedungeon/wiki/Controls)

## Puzzle Design
[Puzzle Documentation](https://github.com/Headlesser/enterthedungeon/wiki/Puzzle-Design)

## Game Map
[Game Map](https://github.com/Headlesser/enterthedungeon/wiki/Game-Map)

## Development Diary
[Process](#process)

## Asset List
[Assets](https://github.com/Headlesser/enterthedungeon/wiki/Asset-List)

## To-Do List
[To-Do](#sticky_notes)

## Sources
[Sources](https://github.com/Headlesser/enterthedungeon/wiki/Sources)



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

# Sticky Notes

 - Make it so you can ONLY examine an item if it is either PRESENT IN THE CURRENT ROOM or IS IN YOUR INVENTORY. If an item is ever used, it should be REMOVED from all dictionaries and cannot be examined. If player returns to a room where they took an item, they should NOT be able to examine the 'ghost' of that item.
 - Make it so text does not scroll infinitely up over the sprite. 'Lock' size of the text area somehow.
 - Make it so, after using an item, it doesn't repeat the old room description again? (Replace it w/ the new one after triggering an event. I will have to clear the log before printing).
 - Make sure sprite sizes are standardized.
 - Create map layout for section 1.

# Process
### January 20, 2020
I began this project on January 20th, 2020, which began as a few sketches of ideas in my notebook. At first I thought of making a 2D point-and-click puzzle game. I was very into games such as [Deep Sleep](https://scriptwelder.itch.io/deep-sleep) and [Don't Escape: 4 Days to Survive](https://dont-escape.com/) by *scriptwealder*, and started writing up some notes in my sketchbook seen here:
![Page1](https://github.com/Headlesser/enterthedungeon/raw/master/images/p3.png "My first idea for the game")

In addition to this I thought about the idea of a non-game related project. I wanted to make a python application for storing character information in a sort of digital encyclopedia where artists, writers, or other story-creators could store all their bios and narrative design notes.

![Page2](https://github.com/Headlesser/enterthedungeon/raw/master/images/p2.png "Character encyclopedia idea")

My third idea is inevitably the one I settled on, which came to fruition after trying to think of a way to scope down the point-and-click puzzle game idea.

![Page3](https://github.com/Headlesser/enterthedungeon/raw/master/images/p1.png "My first idea for the game")

### January 24, 2020
I created my repository after settling on my idea for a text adventure game.

### January 26, 2020
I started the Unity Text Adventure tutorial parts 1, 2, and 3 which can be found here:

https://www.youtube.com/watch?v=jAf1I1UWo5Q

https://www.youtube.com/watch?v=dQ4jcxKwXM8

https://www.youtube.com/watch?v=TP4gLQmKOLo

I had trouble getting my .gitignore file to ignore the proper folders and put it on the to-do list.

