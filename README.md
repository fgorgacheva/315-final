# 315-final

## ITERATION 1 NOTES

*********************************************
**    THOUGHTS FROM PREVIOUS PROTOTYPES    **
*********************************************
The most successful prototype was the obscure mysterious prototype4 in which players were not given the answers but the answer is clearly there. They must act quickly and think upon the initial clue/message they were displayed. I wanted to create a bigger game with different challenges that would include puzzles the players have to figure out how to solve and connecting them by making it so each item obtain from solving the puzzle is used to solve the next one. As for the final level design, I want to make the players have to make a moral decision but one that might not be expected (like if they feed the carrot to the bunny, it'll do something tht will force the player to kill the bunny, bt if they just kill it, then we can never know what would happen, open ended).

"Unexpectation" is usually successful in keeping players on the edge of their seats and to keep them thinking. Some levels are designed to make the player fail so they have to try again to find the answer, each playthrough allows them to understand what they have to do better.



**********************
**    HYPOTHESIS    **
**********************
How far can players go without explicit instructions in various scenarios? Do players prefer to put two and two together on their own? Will they keep trying if they feel like the answer is closer and closer?

- LVL1: find house and figure out you have to unlock it to get what's inside, give player incentive to explore and find out the answer alone
- LVL2: Mummies duplicate at a slower rate than the bunnies do in prototype4 because it's in a maze, the answer isn't obvious and will essentially force the player to get consequences on the first playthrough, forcing them to learn from consequences 




**********************
**      DESIGN      **
**********************
- LVL1: sword hidden in house, find key to get the sword
- LVL2: sword obtain previously will allow to get through next level, use sword to kill all mummies, last to die will drop a flashlight
- LVL3: use the flashlight to keep the monster away, light is the answer, find te light switch to annihilate the monster, it will drop a knife and a carrot
- LVL4: use either the carrot or the knife to kill the bunny, the final decision to make



**********************
**  PLAYTEST NOTES  **
**********************
- everyone likes exploring and solving things on their own. instructions make things too quick and too boring, there's no challenge there. 
- the variety and diversity of level designs keep things interesting so that patterns in thinking don't repeat, connection between the levels isn't clear enough, maybe hide the environment of the maze inside the house so on the outside it fit with environment 1, but inside alludes to environment 2.
- mystery keeps things interesting 




***************************
**    FOLLOW UP NOTES    **
***************************
the biggest thing is that most people have very different ways of reacting to things presented to them whether it's experience with games, or the way they were raised. For example, everyone always went for the bunny and didn't want to kill them and just watched them wreak havoc. Some prefered to sacrifice themselves to let the bunnies live, some started killing them when they had to pick between the bunnies and their own survival, and one immediately killed the bunny before it duplicated once. That guy had a very different upbringing, he loves animals but he's had to kill many as well so seeing the sword and the bunny was a no brainer for him. But he did mention that his mom, who has a bunny as a pet, would absolutely never even consider killing the bunny.

So, given that, there's only so much i can do to adapt the game to everyone's experience. Some will want to explore and find the key, some saw the house and said "where's the key, I don't understand what I have to do because i'm at the hosue and nothing is happening". All i can do, which is what i aim for with this game, is to play on human psychology as much as possible to guide them through the levels.




## ITERATION 2 NOTES

*************************
**    INITIAL NOTES    **
*************************
still going with the same idea, how far can people go without instructions, each level is meant to test that in a different way. the last level added was meant to test more specifically if the roles of shadow and light are obvious in and of themselves. 



**********************
**    HYPOTHESIS    **
**********************
- LVL3: monster follows you, is it intuitive that the light protects you and that you must turn on the lights? 



**********************
**      DESIGN      **
**********************
- dark room, only visibility is from flashlight, mimic monster slowly gets close to you
- INTENTION: the monster stops moving when in the flashlight's light (to show that it's weak to light) and then turning on the big light overwhelms and kills it
- WHAT I HAD: i couldn't add a collider so the mosnter continues to move towards the player even when the light is on it. Adding a collider makes the legs stop spawning/drawing... so idk what to do with this



**********************
**  PLAYTEST NOTES  **
**********************
- the door should indicate better that it's locked, trying to interact with the locked door should really give indication that a key is missing or that the player can't do that, with these cues, it'll make more sense to the player that they need to find something to unlock the door. without any visual or audio cues, the door just looks closed, not locked
- the last mummy dying and the sound playing is not clear they they had to look for something, it let them know that -something- happened but they couldn't see... the only reason they found the flashlight is because they happened to circle back to the middle and that's when they saw it and made the connection... the flashlight needs to drop on the last mummy.
- someone suggested HP instead of instant death.. but i don't know how to make that make sense in my game, i think when you fail you fail, failing is part of figuring out the puzzle itself, so HP would be too generous...
- the idea of not being told exactly what to do absolutely gave everyone a sense of accomplishment, it was a rewarding experience to find things on your own.
- going to different universes (because the aesthetic changeS) is very interesting, but it'd be even more interesting if it's indicated that it's intended rather than "it just so happens to be that way", not like "you are actually traversing universes". this itself gave players the insentive to continue to explore, see what comes next!
- ALSO JSUT AS INTENDED ocne everyone found the monster, when they turned on the light they all turned back around to look at it! so delaying the death to give the player the chance to look at it instinctively was the right move!
- not having direct instructions is definitely more athmospheric and interesting than being told what to do, obviously the cryptic messages need to be there to make everything make sense, without them, things are a little too free
- in lvl it would be nice to know that the light somewhat protects you that you're safe with the light (i know, it's not supposed to go through T-T)



***************************
**    FOLLOW UP NOTES    **
***************************
i pretty much wrote everything in the notes. I have to either make the monster drop the next items needed for level 4, feed or kill the bunny, make a moral decision and then open ending or end it somehow at the end of level 3 to keep it short? but if i end it there i have no idea how to make it end in a way that makes sense and that isn't just abrupt... but i also have way too much to do... Last thing, people did figure out their way around but SOME instructions are appreciated, or if not instructions, then make certain thing more obvious like the locked door, the flashlight, etc. lack of instructions needs to be done well and clever, or it can just be a little annoying...

