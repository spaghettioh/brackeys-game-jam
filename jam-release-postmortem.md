

# ECHO CHAMBER v1.0 postmortem

*Mar 17, 2019*

***Status: In progress***

## Summary

ECHO CHAMBER is a single player game with "split-brain" controls to be played at your own pace. The player simultaneously controls two discs with separate controls with the aim of joining the two discs at a single goal in order to move on to the next level. Each disc can send "echoes" that reveal the route for the other disc, which can also uncover blocked paths and keys which unlock gates blocking the other's path.

Development of ECHO CHAMBER completed February 23, 2019 using the Unity IDE, and it was submitted for the second game jam held by the YouTube channel, Brackeys, held from February 16th, 2019 at 3:00 AM to March 17th, 2019 at 3:00 AM. The theme of the jam was "love is blind," and the submission deadline was one week.

This postmortem is meant to analyze the successes & failures encountered during devlopment, and feedback collected during the rating period of that version 1.0 release.

## Reception

ECHO CHAMBER ranked 41st overall of 330 submissions to the jam, with above-average scores in all categories.

Feedback was generally positive, with praise to the music, conceptual idea, and overall feeling of the game.

Negative feedback was reported over the lack of intuitive controls and general guidance of game play (e.g. not knowing how to echo, or generally what to do in the game).

The resulting scores of the game were as follows:

| Criteria	 | Rank	| Score*| Raw Score|
| ----------- | ---- | ----- | --- |
| **Overall** | **41** | **3.515** | **3.515** |
| Audio | 22 | 3.773 | 3.773 |
| Innovation | 40 | 3.545 | 3.545 |
| Game design | 57 | 3.500 | 3.500 |
| Fun | 69 | 3.364 | 3.364 |
| Theme | 72 | 3.545 | 3.545 |
| Graphics | 108 | 3.364 | 3.364 |

[Ranking page source](https://itch.io/jam/brackeys-2/rate/374979)

\* *Ranked from 22 ratings. Score is adjusted from raw score by the median number of ratings per game (7) in the jam.*

## Goals

The ultimate focus during development was the delivery of a completed, playable game using an overly simple visual style, gameplay mechanics, and controls. Polish was a primary goal to be met before the release of the game, which meant a clear visual theme, the inclusion of audio in the form of music and sound effects, and a generally clean look and feel.

## Motivations

Submissions to the jam were meant to be developed from the ground up, which meant the use of third party assets (other than development aids) was prohibited. This limited the scope of development to focusing on only things that I could create myself. I believe this lead to a more coherent and complete version of the vision which I could proudly call my own.

## Result

v1.0 was published to GitHub and submitted to the jam. I was unsure of how to actually upload/submit the game, and ultimately missed the deadline. A few minutes later I found that there was a submit button in the rules of the jam, reached out to a moderator in the jam's discord channel, and was granted a link to manually create the submission. v1.0 was submitted with a Mac build, and later the next day updated to include WebGL and Windows versions.

## Action Items

| Action Item | Type | Status |
| ----------- | ---- | -----|
| ~~Swap key order in last level (8)~~ | bug | **done** |
| ~~Reduce goal collider size~~ | polish | **done** |
| ~~Echo recharge animation~~ | bug | **done** |
| ~~Add tutorial prompt in level 1 (movement)~~ | bug | **done** |
| ~~Add tutorial prompt in level 3 (echo)~~ | bug | **done** |
| Add tutorial prompt in level 6 (keys) | bug | not started |
| Add "finished" prompt - Any button triggers next level | feature | not started |
| Movement sound | polish | not started |
| Add colliders for moving past the goal | bug | not started |
| Require a ping from each disc to start game *re-evaluate after tutorial implementation* | feature | not started |
| Key and door graphics | feature | not started |
| Menu item sfx | polish | not started |

## Lessons Learned

### What went well

**Ideation**
I took a few days to explore various game ideas that could fit the theme, and attempted to both prop them up as well as cut them down to end up with a concept that I felt would be easy enough to build as a lone amateur developer.

**Prototyping**
I built a working prototype within in the first couple of days to ensure that the concept could be met knowing that I wanted to put a high amount of polish on the submitted game. This meant that I could hastily write garbage code with the understanding that I would have time to completely rewrite the mechanics using proper coding best practices (to my knowledge).

**Building a timeline for polish**
TODO:

**Use of simple visuals**
TODO:

### What went wrong
**Time management**
* Too much time spent exploring dead end ideas
	* include examples
* Too much time spent stagnating on figuring out how things work
	* should have moved on sooner rather than scratching head for multiple hours
* Too much time spent on polish before a playable and beatable game was completed

### Where I got lucky
**Unity features discovered on accident**
* TODO: give examples

## Timeline
*Times in EST*

| Time  | Description |
| ----- | ----------- |
| ?? | Game jam announcement discovered |
| MM/DD/YYYY hh:mm | Theme announced |

## Supporting Information

* [GitHub repository](https://github.com/spaghettioh/brackeys-game-jam)
* [Submission guidelines](https://itch.io/jam/brackeys-2)
