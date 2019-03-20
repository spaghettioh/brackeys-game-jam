# ECHO CHAMBER v1.0 postmortem


## Mar 17, 2019


## **Status: In progress**


# Summary

ECHO CHAMBER is a single player game with "split-brain" controls to be played at your own pace. The player simultaneously controls two discs with separate controls with the aim of joining the two discs at a single goal in order to move on to the next level. Each disc can send "echoes" that reveal the route for the other disc, which can also uncover blocked paths and keys which unlock gates blocking the other's path.

Development of ECHO CHAMBER completed February 23, 2019 using the Unity game development platform. It was submitted for the second game jam hosted by the YouTube channel, Brackeys, from February 16th to March 17th, 2019 on itch.io. The theme of the jam was "love is blind," and the submission deadline was one week.

This postmortem is meant to analyze the successes and failures encountered during development, as well as feedback collected during the rating period for the three weeks following the submission.


# Reception

ECHO CHAMBER ranked 41st overall of 330 submissions to the jam, with above-average scores in all categories.

Feedback was mostly positive. The game received a lot of praise for the music and sound effects and how they contributed to the overall feel of the game. People enjoyed the conceptual idea and overall feeling of the game. Although it was the lowest ranking category, many comments praised the visuals and visual style.

Two constructive feedbacks were given around providing a visual cue as to when each disc's echo was recharged. Players found themselves just mashing the Shift keys instead of using the echoes more strategically.

Negative feedback was reported around the lack of tutorial. Until the rules were understood, players seemed to have a generally difficult time understanding what to do or how to do it (e.g. echo). There was also a recurring request for more levels, and that the game ends too quickly.

The resulting scores of the game were as follows:


<table>
  <tr>
   <td><strong>Criteria</strong>
   </td>
   <td><p style="text-align: right">
<strong>Rank</strong></p>

   </td>
   <td><p style="text-align: right">
<strong>Score*</strong></p>

   </td>
   <td><p style="text-align: right">
<strong>Raw score</strong></p>

   </td>
  </tr>
  <tr>
   <td><em>Overall</em>
   </td>
   <td><p style="text-align: right">
<em>41</em></p>

   </td>
   <td><p style="text-align: right">
<em>3.515</em></p>

   </td>
   <td><p style="text-align: right">
<em>3.515</em></p>

   </td>
  </tr>
  <tr>
   <td>Audio
   </td>
   <td><p style="text-align: right">
22</p>

   </td>
   <td><p style="text-align: right">
3.773</p>

   </td>
   <td><p style="text-align: right">
3.773</p>

   </td>
  </tr>
  <tr>
   <td>Fun
   </td>
   <td><p style="text-align: right">
69</p>

   </td>
   <td><p style="text-align: right">
3.364</p>

   </td>
   <td><p style="text-align: right">
3.364</p>

   </td>
  </tr>
  <tr>
   <td>Game design
   </td>
   <td><p style="text-align: right">
57</p>

   </td>
   <td><p style="text-align: right">
3.500</p>

   </td>
   <td><p style="text-align: right">
3.500</p>

   </td>
  </tr>
  <tr>
   <td>Graphics
   </td>
   <td><p style="text-align: right">
108</p>

   </td>
   <td><p style="text-align: right">
3.364</p>

   </td>
   <td><p style="text-align: right">
3.364</p>

   </td>
  </tr>
  <tr>
   <td>Innovation
   </td>
   <td><p style="text-align: right">
40</p>

   </td>
   <td><p style="text-align: right">
3.545</p>

   </td>
   <td><p style="text-align: right">
3.545</p>

   </td>
  </tr>
  <tr>
   <td>Theme
   </td>
   <td><p style="text-align: right">
72</p>

   </td>
   <td><p style="text-align: right">
3.545</p>

   </td>
   <td><p style="text-align: right">
3.545</p>

   </td>
  </tr>
</table>


_* Ranked from 22 ratings. Score is adjusted from raw score by the median number of ratings per game (7) in the jam._

[Ranking page source](https://itch.io/jam/brackeys-2/rate/374979)


# Goals

The ultimate goal during development was the delivery of a completed, playable game using an overly simple visual style, gameplay mechanics, and controls. Polish was a primary goal to be met before the release of the game, which meant a clear vision of development and a visual theme, the inclusion of audio in the form of music and sound effects, and a generally clean look and feel.


# Limitations

Of the few rules for the jam, submissions were meant to be created from the ground up. This meant the use of third party assets (other than development aids) was prohibited. This limited the scope of development to focusing on only things that I could create myself. I believe this lead to a more coherent and complete version of the vision which I could proudly call my own.


# Result

v1.0 was published to GitHub and submitted to the jam. v1.0 was submitted with a Mac build, and later the next day updated to include WebGL and Windows versions.

There are still a handful of things I would like to do to update the game. Primarily additional polish, a few more levels with new mechanics, and the final sound effects that I intended to include in the initial release.


# Action Items


<table>
  <tr>
   <td><strong>AI</strong>
   </td>
   <td><strong>Type</strong>
   </td>
   <td><strong>Status</strong>
   </td>
  </tr>
  <tr>
   <td><del>Swap key order in last level (8)</del>
   </td>
   <td><del>bug</del>
   </td>
   <td><del>done</del>
   </td>
  </tr>
  <tr>
   <td><del>Reduce goal collider size</del>
   </td>
   <td><del>polish</del>
   </td>
   <td><del>done</del>
   </td>
  </tr>
  <tr>
   <td><del>Echo recharge animation</del>
   </td>
   <td><del>bug</del>
   </td>
   <td><del>done</del>
   </td>
  </tr>
  <tr>
   <td><del>Add tutorial prompt in level 1 (movement)</del>
   </td>
   <td><del>bug</del>
   </td>
   <td><del>done</del>
   </td>
  </tr>
  <tr>
   <td><del>Add tutorial prompt in level 3 (echo)</del>
   </td>
   <td><del>bug</del>
   </td>
   <td><del>done</del>
   </td>
  </tr>
  <tr>
   <td>Add tutorial prompt in level 6 (keys)
   </td>
   <td>bug
   </td>
   <td>not started
   </td>
  </tr>
  <tr>
   <td>Add "finished" prompt - Any button triggers next level
   </td>
   <td>feature
   </td>
   <td>not started
   </td>
  </tr>
  <tr>
   <td>Movement sound
   </td>
   <td>polish
   </td>
   <td>not started
   </td>
  </tr>
  <tr>
   <td>Add colliders for moving past the goal
   </td>
   <td>bug
   </td>
   <td>not started
   </td>
  </tr>
  <tr>
   <td>Require a ping from each disc to start game *re-evaluate after tutorial implementation*
   </td>
   <td>feature
   </td>
   <td>not started
   </td>
  </tr>
  <tr>
   <td>Key and door graphics
   </td>
   <td>feature
   </td>
   <td>not started
   </td>
  </tr>
  <tr>
   <td>Menu item sfx
   </td>
   <td>polish
   </td>
   <td>not started
   </td>
  </tr>
</table>



# Lessons Learned


## What went well


### Ideation

I took a few days to explore various game ideas that could fit the theme, and attempted to both prop them up as well as cut them down to end up with a concept that I felt would be easy enough to build as a lone amateur developer.


### Prototyping

I built a working prototype within in the first couple of days to ensure that the concept could be met knowing that I wanted to put a high amount of polish on the submitted game. This meant that I could hastily write garbage code with the understanding that I would have time to completely rewrite the mechanics using proper coding best practices (to my knowledge).


### Building in a timeline for polish

I knew that I wanted this game to have a high amount of polish. The simple visuals, gameplay style, and controls allowed me get a lot of the core work done early in the process and spend a lot of time just tweaking everything. I think having a fairly solid vision up front before starting any coding really helped speed the development process along, especially when coupled with the initial time spent prototyping.


### Use of simple visuals

Using a minimal set of clearly identifiable colors, basic primitive shapes, and a stumbling rather quickly on a font that I liked meant that I could spend more time making simple things look great. In the past I think I've had elaborate ideas for base assets, and so a lot of time goes into just creating the thing rather than polishing it. Not having backgrounds helped, and I wonder if time spent on tools to build levels were spent on visuals instead, would I have even finished the game?


## What went wrong

In summary, time management.


### Fixation on non-breaking features

There were a couple of blocks of time each night during the jam window where I became fixated on a particular portion of development. Even if it was something that was absolutely necessary for the game to work as planned, it was never something that broken the game entirely. Some examples were:



*   Gravity well applied to the end goal. After finding a script that would work, I spent a lot of time trying to optimize it to work just the way I wanted it to, or I introduced minor bugs by implementing it in the first place and insisted on fixing and polishing it before moving on.
*    TODO

Additionally, I spent a lot of time making very small tweaks to make something look just a certain way, or behave in a particular fashion. One example is the end portal. I must've viewed five full videos just to create the swirling effect.


### Experimentation with new tools

 TODO


### Weak workflow for switching between OSs

 TODO 


### The game was submitted late

I was unsure of how to actually upload/submit the game, and ultimately missed the deadline. A few minutes later I found that there was a submit button in the rules of the jam.


## Where I got lucky


### Unity features discovered on accident

A number of features utilized in the game were actually stumbled upon by accident. Because my scripts and concepts were so focused, I think that made my search queries more narrow, which meant I could gain insight more quickly with a tutorial or documentation of a feature that was built directly into Unity. Some examples are...



*   Sprite masking. Used for the echo effect to light the paths of the other discs. I found this feature on accident while looking for ways to replicate the echo effect for sprites.
*   Trail renderer. Used for ghosting effect that appears behind a disc when it moves. I stumbled upon this feature looking for ways to effectively apply partical emitters to create the effect of movement. Mostly likely meant for different applications, this game object component has only a few settings to achieve the desired result.


### Strict rules around asset creation

I believe that the rule stating all assets must be created helped me maintain a more narrow focus instead of getting distracted by endless searching for prebuilt assets I could use. This was definitely an inspiration throughout the jam as well, as I could get excited about expressing creative freedom in all facets of development. This could've been a nightmare if I were creating anything more complex than what was released.


### Compartmentalized scripts

Though this not at all scalable, a small scope meant that I could apply small scripts with hyper-focused utility to individual game objects. This meant there wasn't much room for cascading issues. Once the prototyping phase was over, all scripts were recreated; shortened, optimized, and siloed to their particular task using public variables (which also reduced the likelihood of having to learn new syntax), rather than creating a multitude of dependencies present in larger games.


### Discord moderator saves the day

After arriving late to find the submission window closed, I reached out to a moderator in the jam's discord channel, and was granted a link to manually create the submission.


## What could've been done better

Ultimately I could have shifted my focus to do two things differently:



*   Moved on from feature development sooner rather than spending an hour or more trying to write code for relatively small designs. This would've included:
    *   Gravity well adjustments. The initial version of the script worked fine, but pulled the disc in from any distance, and changes I made to the script severely impacted and/or exaggerated the effect)
    *   Echo effect. This effect was initially built using a combination of lighting effects, which worked fine with the 3D primitives used during the protoype. When sprites were brought in to replace the placeholder 3D objects, the lighting effects stopped working as intended, and I fell down a rabbit hole that ultimately lead to the sprite-masking effect now in use.
*   Spent less or no time on polish after fixing bugs during feature development. I would sometimes fix bugs with new features right away, then spend the tail end spit-shining the final, working result. This would've included:
    *   Tweaking and polishing the gravity well parameters
    *   Optimizing sprite sizes and import settings to match pixel ratios
    *   Organizing the project folder (moving and renaming files and scripts, deleting old files, etc)


# Timeline

_Times in EST_


<table>
  <tr>
   <td><strong>Time</strong>
   </td>
   <td><strong>Description</strong>
   </td>
  </tr>
  <tr>
   <td>??
   </td>
   <td>Game jam announcement discovered & jam joined
   </td>
  </tr>
  <tr>
   <td>Feb 16, 2019, 3:00 am
   </td>
   <td>Theme announced
   </td>
  </tr>
  <tr>
   <td>Feb 17, afternoon
   </td>
   <td>Planning started
   </td>
  </tr>
  <tr>
   <td>Feb 17, 10:10 pm
   </td>
   <td>GitHub repo created
   </td>
  </tr>
  <tr>
   <td>Feb 19, 12:25 am
   </td>
   <td>Prototype completed
   </td>
  </tr>
  <tr>
   <td>Feb 23, 3:50 am
   </td>
   <td>Game submitted
   </td>
  </tr>
  <tr>
   <td>Feb 23, 4:02 pm
   </td>
   <td>Other OS versions uploaded
   </td>
  </tr>
  <tr>
   <td>Feb 28, 11:10pm
   </td>
   <td>Various updates uploaded
   </td>
  </tr>
</table>



# Supporting Information



*   [ECHO CHAMBER itch.io submission page](https://emofield.itch.io/echo-chamber)
*   [GitHub repository](https://github.com/spaghettioh/brackeys-game-jam)
*   [Game jam home page and rules](https://itch.io/jam/brackeys-2)
