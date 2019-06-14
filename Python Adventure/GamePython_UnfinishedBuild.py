# -*- coding: utf-8 -*-

import random
import numpy as np

###############################################################################
###############################################################################        
##############                     CLASSES                       ############## 
###############################################################################      
###############################################################################

class Start():
    def __init__(self):
        self.text = [("starting area text"), 
                      ("secondary starting text")]

class Secret():
    def __init__(self):
        self.text = [("secret 1"),
                      ("secret 2"),
                      ("secret 3"),
                      ("secret 4"),
                      ("secret 5")]
        self.solution = [("solution1"),
                         ("solution2"),
                         ("solution3"),
                         ("solution4"),
                         ("solution5")]
        self.rewardtext = [("Reward text 1"),
                           ("Reward text 2"), 
                           ("Reward text 3"),
                           ("Reward text 4"),
                           ("Reward text 5")]
        self.reward = [("Reward 1"),
                       ("Reward 2"),
                       ("Reward 3"),
                       ("Reward 4"),
                       ("Reward 5")]
    def Reward(self, n):
        PC.Inventory.append(self.reward[n])
        if n == 1:
            PC.attack += 2
        elif n == 2:
            PC.defense += 2
        elif n == 3:
            PC.agility += 2
        elif n == 4:
            PC.hp += 5
        else:
            levelup()
            
class ZoneClass:
    def __init__(self):
        self.safex = np.array([1,2,3])
        self.safey = np.array([[0,0,0],[6,4,5],[3,0,2]])
        self.start = np.array([0,2])
        self.map = np.empty(shape=(8,5), dtype=object)
        self.map = [Secret(),
                    Start(),
                    Secret(),
                    Town(),
                    Town(),
                    Secret(),
                    Town(),
                    Secret(),
                    Secret()]
        #self.directions = np.array([[]])
###############################################################################
class Plains:
    def __init__(self):
        self.battletext = [("\nYou wander through fields of grass so unkempt that you struggle to see above it. You trip on something but manage to regain your balance, unfortunately however, the \"something\" turns out to be a hostile creature!"),
                           ("\nYou travel across a lush green stretch of land but after a while you feel a little fatigued and decide to take a quick rest, unfortunately you happen to fall asleep and are soon abruptly awakened by the incoming blows of enemies!"),
                           ("\nWhilst travelling across a strech of flat land you spot enemies in the distance, unfortunately they spot you too. You prepare yourself for combat!")]
        self.text = [("\nThe field spans out ahead of you, a mixture of lush green and yellow sun spots. There is a gentle breeze as you decide in which direction to travel."),
                     ("\nYou find yourself in a large stretch of flat land, the air is cool and refreshing under the bright hot sun."),
                     ("\nYou look out across the long flat stretches of grassland, small areas of brush dot the landscape.")]
        self.wintext = [("\nWith the final blow dealt to your foes, you take a moment to catch your breath, the thick tall grass before you seems endless and you would prefer to continue having rested."),
                        ("\nYour enemies slain, you take a moment to regain your bearings and recover from being awoken so abruptly. The air is temperate and a breeze blows the tall grass of the plains about you."),
                        ("\nAs the blood of your battered and defeated foes seeps into the earth you look out across the long flat stretches of grass and brush")]
###############################################################################
class Forest:
    def __init__(self):
        self.battletext = [("\nYou travel under the shelter of a lush woodland. Spotting a creek, you decide to stop for a sip of the fresh water, as you get closer however you realise that enemies have done the same and before you can hide they spot you and attack!"),
                           ("\nWhilst you travel through the dense woodland you hear the sounds of creatures, you stop to try and determine where the sounds are eminating from. Before long the sources seem to encircle you. As one creature emerges from behind a tree trunk you prepare yourself for combat but as you do another creature manages to sneak up behind you and land a blow!"),
                           ("\nWhilst you travel through the dense woodland you hear the sounds of creatures, you stop to try and determine where the sounds are eminating from. Fortunately you spot them as they approach and prepare yourself for combat!")]
        self.text = [("\nSunlight breaks through the canopy in shafts of golden glow, the woodland around you is littered with noise, all of it, thankfully, peaceful."),
                     ("\nThe ground of the woodland is littered with holes made by small creatures, a breeze permeates through the trees and the sounds of rustling leaves swells and diminishes."),
                     ("\nThe trees in this part of the woods seem much more aged than those you passed on your way in. You pause a moment to admire them before you continue on your journey.")]
        self.wintext = [("\nYour enemies slain, you finally manage to drink from the creek and wash the blood from your hands, before you continue on."),
                        ("\nForest win text 2"),
                        ("\nForest win text 3")]
###############################################################################
class Hill:
    def __init__(self):
        self.battletext = [("\nYou clamber up the tough slope of a hillside and finally reach the crest only to realise the summit is already occupied! Before you can retreat they see you and attack!"),
                           ("\nHaving made your way finally to the top of a rather steep hill you decide to sit and catch your breath. While you rest you are attacked from behind!"),
                           ("\nWhilst making your way down the slopes of a hillside a sound from behind alerts you, you turn to look and see something barreling down the hill at you! Aware that it's probably not friendly, you prepare for combat!")]
        self.text = [("\nHill text 1"),
                     ("\nHill text 2"),
                     ("\nHill text 3")]
        self.wintext = [("\nHill text 1"),
                        ("\nHill text 2"),
                        ("\nHill text 3")]
###############################################################################
class River:
    def __init__(self):
        self.battletext = [("\nYou find your travels blocked by a long river, fortunately a fallen tree has formed a makeshift bridge across it. You manage to clamber across carefully but as you do you are attacked!"),
                           ("\nYou stop at a stream and decide to quench your thirst on the fresh water, as you do you are attacked from behind!"),
                           ("\nYou pause a moment to admire the beauty of the river by which you travel, whilst gazing out you hear a strange sound from behind you and turn to see what it is and find yourself set upon by enemies!")]
        self.text = [("\nRiver text 1"),
                     ("\nRiver text 2"),
                     ("\nRiver text 3")]
        self.wintext = [("\nRiver win text 1"),
                        ("\nRiver win text 2"),
                        ("\nRiver win text 3")]
###############################################################################
class Lake:
    def __init__(self):
        self.battletext = [("\nlake battle text 1"),
                           ("\nlake battle text 2"),
                           ("\nlake battle text 3")]
        self.text = [("\nlake text 1"),
                     ("\nlake text 2"),
                     ("\nlake text 3")]
        self.wintext = [("\nlake win text 1"),
                        ("\nlake win text 2"),
                        ("\nlake win text 3")]
###############################################################################
class Player:
    def __init__(self, name):
        self.name = name
        self.level = 1
        self.hp = 10
        self.agility = 2
        self.attack = 2
        self.defense = 1
###############################################################################
class Goblin:
    def __init__(self, name, i):
        self.name = name
        self.id = i
        self.hp = 3
        self.agility = 1
        self.attack = 3
        self.defense = 1      
###############################################################################        
class Snake:
    def __init__(self, name, i):
        self.name = name
        self.id = i
        self.hp = 1
        self.agility = 3
        self.attack = 2
        self.defense = 1
###############################################################################
###############################################################################        
##############                 DEFINITIONS                       ############## 
###############################################################################      
###############################################################################
def levelup():
    PC.level += 1
    PC.agility += random.randint(1,3)
    PC.attack += random.randint(1,2)
    PC.defense += 1
    PC.hp += random.randint(2,3)
    
def EndScreen():
    print("GAME OVER")        
###############################################################################
def Gen_Enemy(ClassName, num):
    global Enemy_Num
    global Enemies
    if ClassName == "Goblin":
        for i in range(num):
            Enemies.append(Goblin("Goblin", i))
            Enemy_Num += 1
    if ClassName == "Snake":
        for i in range(num):
            Enemies.append(Snake("Snake", i))
            Enemy_Num += 1
###############################################################################
def InitiateEnemy(diff, x):
    global travelmode
    global combatmode
    travelmode = False
    combatmode = True
    print(Zone.map[zone[0],zone[1]].battletext[x])
    if x == 0:
        Gen_Enemy("Goblin", 1*diff)
        Gen_Enemy("Goblin Raider", 0.4*diff)
        Gen_Enemy("Gob")
        Instruct(diff)
    elif x == 1:
        Gen_Enemy("Snake", 2*diff) 
        Instruct(diff)
    else:
        Gen_Enemy("Goblin", 1*diff)
        Gen_Enemy("Snake", 1*diff)
        Instruct(diff, x)
###############################################################################        
def EncounterCheck(diff):
    x = random.randint(0,5)
    if x > 2:
        InitiateEnemy(diff, x-3)
    else:
        print(Zone.map[zone[0],zone[1]].text[x])
###############################################################################
def Enemy_Attacks():
    for i in range(len(Enemies)):
                print('[',str(i+1),']', Enemies[i].name, "attacks!\nYou take", Enemies[i].attack - PC.defense, "damage.")
                PC.hp -= Enemies[i].attack - PC.defense
                if PC.hp <= 0:
                    print("Oh no! You were slain by a", Enemies[i].name, ".\n Your adventure has come to a premature end..\n\n Would you like to try again?")
                    restart = str(input("Y/N:"))
                    if restart == "Y" or "y":
                        EntryPoint()
                    elif restart =="n" or "N":
                        EndScreen()
###############################################################################
def CombatRound(x):
    global combatmode, travelmode
    print("\n\n BATTLE STATS \n\n     ", PC.name, "  -  Hp:", PC.hp)
    print("\nEnemy Combatants:")
    for i in range(len(Enemies)):
        print('[',str(i+1),']', Enemies[i].name, "  -  Hp:", Enemies[i].hp)      
    print("\nWill you attack or flee?")
    instruction = str(input("Input:"))
    if (instruction == "Attack" or instruction =="attack"):
        if len(Enemies) != 1:
            print('Which enemy would you like to attack?')
            target = int(input('Input:'))
        else:
            target = 1
        Enemies[target-1].hp -= (PC.attack - Enemies[target-1].defense)
        if Enemies[target-1].hp <= 0:
            dead = Enemies[target-1:target]
            del Enemies[target-1]
            print(dead[0].name, "has been slain.")
            if len(Enemies) == 0:
                print("CONGRATULATIONS! You have won the battle!")
                
                print(Zone.map[zone[0],zone[1]].wintext[x])
                combatmode = False
                travelmode = True
        Enemy_Attacks()
            
    if (instruction == "Flee" or instruction == "flee"):
        escape_mod = PC.agility
        for i in range(len(Enemies)):
            escape_mod -= Enemies[i].agility
        escape = random.random()*10 + escape_mod
        if escape >= 5:
            del Enemies[:]
            print("You managed to escape!")
            print(Zone.map[zone[0],zone[1]].text[x])
            combatmode = False
            travelmode = True
        else:
            print("You failed to get away!")
            Enemy_Attacks()
###############################################################################
def GenerateZoneType():
    x = random.random()
    if x<= .35:
           Zone.map[zone[0],zone[1]] = Plains()
    elif x>.35 and x<=.55:
           Zone.map[zone[0],zone[1]] = Forest()
    elif x>.55 and x<=.75:
           Zone.map[zone[0],zone[1]] = Hill()
    elif x>.75 and x<=.90:
           Zone.map[zone[0],zone[1]] = River()
    else:
           Zone.map[zone[0],zone[1]] = Lake()
    return Zone.map[zone[0],zone[1]]
###############################################################################
def ZoneCheck(diff, y, x):
    global zone
    if zone[1] in Zone.safex and zone[0] in Zone.safey[:,zone[1]-1]:
        dosomething = 0
    elif (zone[1] < 0 or zone[1] > 4) or (zone[0] < 0 or zone[0] > 7):
        print("\nYou make your way into thick woods but lose your way, somehow you manage to escape the wilderness and emerge from the treeline back from whence you came.\n")
        zone -= np.array([y,x]) 
        Instruct(diff)
    else:
        if Zone.map[zone[0],zone[1]] is None :
            Zone.map[zone[0],zone[1]] = GenerateZoneType()
        EncounterCheck(diff)
        Instruct(diff)
###############################################################################
def Instruct(diff, x=0):
    global travelmode
    global combatmode
    global socialmode
    global zone
    if travelmode == True:
        print("Which direction would you like to travel?")
        instruction = str(input("Input:"))
        if (instruction == "North" or instruction == "north"):
            zone += np.array([-1,0])
            ZoneCheck(diff, -1,0)
        elif (instruction == "South" or instruction == "south"):
            zone += np.array([1,0])
            ZoneCheck(diff, 1,0)
        elif (instruction == "West" or instruction == "west"):
            zone += np.array([0,-1])
            ZoneCheck(diff, 0,-1)
        elif (instruction == "East" or instruction == "east"):
            zone += np.array([0,1])
            ZoneCheck(diff, 0,1)
    #if (instruction == "Talk" or instruction == "talk") ) and socialmode == True:
    #    Talk()
    #if (instruction =="Trade" or instruction == "trade") and socialmode == True:
    #    Trade()
    while combatmode == True:
        CombatRound(x)
###############################################################################                
def EntryPoint():
    global zone, combatmode, socialmode, travelmode, Enemy_Num, Enemies, PC, cont, Zone
    
    ####INITIALISATION####        
    zone = np.array([0,2])
    Zone = ZoneClass()
    combatmode = False
    socialmode = False
    travelmode = True
    Enemy_Num = 0 
    Enemies = []
    ####INITIALISATION####
    
    ####SPLASH SCREEN####
    print("Welcome to Snakes and Goblins!")
    player_Name = str(input("What is your name?\n"))
    PC = Player(player_Name)
    print("Good luck on your adventures", PC.name)
    cont = input("PRESS ENTER TO START")
    ####SPLASH SCREEN####
    
    ####Tutorial####
    print("You wake up in a small clearing in what looks like a dense forest. You have no idea how you got here or really where here is, but there is a path that seems to lead south, you decide to follow it and hope it will lead you to somewhere familiar..\n\nHint: To move, type the direction you wish to travel (Assuming it is available).")
    Instruct(PC.level)
    cont = input("end")
###############################################################################
###############################################################################        

EntryPoint()
