# Noctis Mod RoR2
Noctis Lucis Caelum mod for Ror2 https://thunderstore.io/package/TeaL/NoctisMod/


## Noctis
Adds Noctis from Final Fantasy XV, a technical melee focused surivor, switching between different weapons for different situations.
#### Multiplayer works (hopefully). CustomEmotesAPI compatibility. Risk of Options support.
#### Message me on the Risk of Rain 2 Modding Discord if there are any issues- teal5571.
#### <a href="https://ko-fi.com/tealpopcorn"><img src="https://user-images.githubusercontent.com/93917577/160220529-efed5020-90ac-467e-98f2-27b5c162d744.png"> </a>
If you enjoy my work, support me on Ko-fi!
## Popcorn Factory
<details>
<summary>Check out other mods from the Popcorn Factory team!</summary>	
<div>
    <a href="https://thunderstore.io/package/PopcornFactory/ShigarakiMod/">
        <img src="https://user-images.githubusercontent.com/93917577/168004591-39480a52-c7fe-4962-997f-cd9460bb4d4a.png"><br>
        <p>ShigarakiMod (My other Mod!)</p>
    </a>
</div>	
<div>
    <a href="https://thunderstore.io/package/PopcornFactory/Arsonist_Mod/">
      <img width="130" src="https://cdn.discordapp.com/attachments/928130606662049892/1088442099432706068/PopcornFactory-Arsonist_Mod-1.png"/>
      <p>Arsonist Mod (Popcorn Factory Team)</p>
    </a>
</div>	
<div>
    <a href="https://thunderstore.io/package/PopcornFactory/Rimuru_Tempest_Mod/">
      <img width="130" src="https://cdn.discordapp.com/attachments/399901440023330816/1033003173759164467/unknown.png"/>
      <p>Rimuru Tempest Mod (Popcorn Factory Team)</p>
    </a>
</div>
<div>
    <a href="https://thunderstore.io/package/PopcornFactory/DarthVaderMod/">
      <img width="130" src="https://user-images.githubusercontent.com/93917577/180753359-4906ca0b-6ce5-4ff7-9962-bdec3329682c.png"/>
      <p>Darth Vader Mod (Popcorn Factory Team)</p>
    </a>
</div>
<div>
    <a href="https://thunderstore.io/package/PopcornFactory/DittoMod/">
        <img src="https://user-images.githubusercontent.com/93917577/168004690-23b6d040-5f89-4b62-916b-c40d774bff02.png"><br>
        <p>DittoMod (My other Mod!)</p>
    </a>
</div>
<div>
    <a href="https://thunderstore.io/package/TeaL/DekuMod/">
        <img src="https://cdn.discordapp.com/attachments/399901440023330816/960043614036168784/TeaL-DekuMod-3.1.1.png.128x128_q95.png"><br>
        <p>DekuMod (My other Mod!)</p>
    </a>
</div>
<div>
    <a href="https://thunderstore.io/package/Ethanol10/Ganondorf_Mod/">
        <img src="https://cdn.discordapp.com/attachments/399901440023330816/960043613428011079/Ethanol10-Ganondorf_Mod-2.1.5.png.128x128_q95.png"><br>
        <p>Ganondorf Mod (Ethanol 10)</p>
    </a>
</div>
<div>
    <a href="https://thunderstore.io/package/BokChoyWithSoy/Phoenix_Wright_Mod/">
        <img src="https://cdn.discordapp.com/attachments/399901440023330816/960054458790850570/BokChoyWithSoy-Phoenix_Wright_Mod-1.6.2.png.128x128_q95.png"><br>
        <p>Phoenix Wright Mod (BokChoyWithSoy)</p>
    </a>
</div>
<div>
    <a href="https://thunderstore.io/package/PopcornFactory/Wisp_WarframeSurvivorMod/">
        <img src="https://cdn.discordapp.com/attachments/399901440023330816/960043613692239942/PopcornFactory-Wisp_WarframeSurvivorMod-1.0.2.png.128x128_q95.png"><br>
        <p>Wisp Mod (Popcorn Factory Team)</p>
    </a>
</div>
</details>

## Latest Changelog, Next update(s)

- 1.4.0- Lots of changes
    - Bug fixes
        - Fixed issue with Polearm Double Dragoon Thrust when used during a jump cancel- only worked when polearm was set to primary, not secondary or special.
        - Fixed issue with Noctis' voice playing over Shigaraki (my other mod) at times.
        - Also updated Miro link to allow people to view instead of join the team
    - Changes- Overall these changes were done to help improve Noctis' flow of combat
        - Warpstrike can now be fast canceled much like all other weapon attacks and swap attacks- this means the animation time will be shorter as well. It also grants invincibility while using as well for increased safety.
        - Reworked movement speed calculations for most skills so they don't get as absurd scaling like previously. Sword swap forward should move less.
        - Sword swap aerial and Polearm aerial also don't increase in speed and decrease in duration based on attackspeed anymore. Instead, attackspeed increases damage and proc much like other skills. 
        - Swapped Polearm backward (the backhop) and Polearm swap backward (the polearm throw) inputs. Now polearm backward will throw the polearm with the fast animation, and now does less damage instead. 
        - Added 150 armor to all of Greatsword attacks to help with it's slow speed at times. 
        - Changed Greatsword neutral, swap neutral and swap aerials to new moves to help improve it's current moveset.
    - Additions
        - *NEW* replaced Greatsword neutral to a counter stance when held. If hit, retaliate with an AOE slam around you.
        - *NEW* replaced Greatsword swap neutral and Greatsword swap aerials to attacks that launch an enemy up. If the input is held and the enemy is still alive, Noctis will warp to the target and slam them downwards. Greatsword swap aerial will warp to the target indicator reticle much like warpstrike.
        - *NEW* added a new extra skill! Armiger consumes all of Noctis' mana but in turn for each 10 mana spent, grant 1 second of a buff that destroys all nearby projectiles. Can be stacked.
- 1.3.0-
    - Bug fixes
        - Previously not mentioned but Greatsword neutral properly sends enemies up, and attackspeed does not increase the amount of force for any attack anymore
    - Changes
        - Overall faster animations for most attacks- mainly greatsword attacks and some polearm attacks
        - *New* added weapon cancel animations- now when you're using a weapon swap attack to cancel an attack in it's duration, it will play an animation that starts immediately at the damage animation, making it a lot faster than before.
        - The aim of these change is to make the transition smoother as weapon swap attacks right after a normal attack presents a dangerous gap at times that could result in Noctis being in danger. 
- 1.2.0-
    - Bug fixes
        - Actually fixed Greatsword attacks not all applying vulnerability
        - Fixed vulnerability debuff not actually increasing damage
        - Fixed Greatsword swap attacks not stunning
        - Fixed Greatsword forward not doing damage as it has no radius
        - Fixed Warpstrike not aiming towards a target
        - Dash particle should appear as you use warpstrike now
        - Warpstrike damage scaling fixed, was doing too much damage before.
    - Changes
        - Warpstrike now freezes all enemies nearby on hit if the distance is greater than 50% of the max distance.
        - Improved sword swap forward timing and movement
        - lowered amount of particles when Noctis ground slams
- 1.1.0-
    - Bug fixes
        - Fixed polearm weapon description in lobby to appear under polearm not dodge.
        - Fixed Greatsword attacks not all applying vulnerability
        - Hid messages appearing when using sword attacks
        - Fixed sword swap forward not moving noctis far enough
        - Fixed the target lock on from being able to select players (meaning you could use warp strike to an ally, travelling towards them but also dealing damage.
    - Balance
        - Reduced max mana per level from 10->5. Reduced max mana given from stock based items: magazine- 10->5. lysate 15->10. afterburner 30->15. Reduced natural regen as well. Noctis was not having mana issues too fast, and through attacking gains a decent amount of mana already.
        - Changed window of using jump or dodge to cancel out of attacks to 50% earlier than what it was previously, this is to help some longer animation attacks not get Noctis killed due to enemy projectiles or puddles.
        - Using Dodge no longer resets his current weapon to 'None'. This means he can more easier access the weapon swap attacks.
        - Improved hitbox sizes in general, his rootedness meant he needed larger hitboxes to reach enemies.
        - Changed base damage from 10->12
        - Along with the bug fixes, should make Noctis more in line with other characters in general.
- 1.0.0- Release

- Next update(s)
    - Bug fixes. 
    - Balance? 
    - More Weapons?
      
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/39143b59-0050-4035-b437-c5028b7f88e0" height ="256" >
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/b92a3e3b-ac4d-44ff-86f0-da1366a5119c" height ="256" >
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/f5480f7b-d296-4581-9627-be8ef994c0f3" height ="256" >
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/890a73bf-ee33-4599-bd70-c2a9f6c36526" height ="256" >

## Known Issues

## Overview    
Attack speed doesn't scale Noctis' animations. 

Instead it adds 'extra' attacks. For example, 2.5 attack speed means you'll do 3 attacks- 2 attacks that deal 100% damage and proc, while the 3rd attack deals 50% damage and 50% proc. 

Each weapon has unique attributes to them.
    
    
## Skills
### Passive
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/e39be057-e49d-4a5f-94e6-91d802deca7d" height ="128" >

    Noctis has a mana bar which regenerates over time and through each hit. 
    He is able to jump cancel and dodge cancel his attacks, consuming 10 mana. 
    Attacks can also cancel into attacks.
    Noctis can sprint in any direction and has a double jump.

### Base Skills

#### Dodge 
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/1f212e12-74ec-4e41-8b69-dcebf63bfc21" height ="128" >

    Pressing dodge grants 300 armor during the duration. 
    Allows you to cancel the endlag for attacks.
    Costs 10 mana, reducible by CDR items.
    Using it in the air will have you airstep, gaining a little bit of height.

#### Jumping
Only usable after an attack.

    Pressing the jump button allows you to cancel the endlag for attacks at the same point of when dodges or attacks can cancel.
    Gain as much height as a normal jump approximately.
    Costs 10 mana, reducible by CDR items.
    Holding the jump key and the polearm button results in the Double Dragoon Thrust Swap attack. 

#### Warpstrike 
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/3f402b77-c2b7-495a-a90d-bfe9abfb99ab" height ="128" >

    Warps Noctis towards the target or the direction you're looking at.
    When arriving at an enemy, deal damage, scaling with distance travelled.
    Costs 30 mana, reducible by CDR items.
    
#### Armiger 
<img src= "https://github.com/1TeaL/Noctis/assets/93917577/92dc53e7-45cb-40a8-b8be-4ea85ceb2e95" height ="128" >

    Consume all your mana- for every 10 mana add 1 second of the Armiger buff.
    While the buff is active, all nearby projectiles will be destroyed. 

#### Weapon combo routes Miro
[https://miro.com/welcomeonboard/VFdWblM1NlFXaWh6amxZbVNNYm8xbzh4N1JCQ1JUS251QVdpWXU4S3FxZVBXeXlTUFhQRlp0TktMOUYyMThBUHwzNDU4NzY0NTY3MDExNjcwNzY1fDI=?share_link_id=355693524661](https://miro.com/app/board/uXjVNZppqMY=/?share_link_id=610619879576)

#### Sword- Faster attacks. Swap attacks have invincibility. All attacks have proc of 1.
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/71e6552a-8ce3-4cfa-9dbc-44d976edcf39" height ="128" >
<table>
<thead>
  <tr>
    <th>Sword input</th>
    <th>Description</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td>Neutral</td>
    <td>3 Hit Combo dealing 200%, 100% and 400% damage.</td>
  </tr>
  <tr>
    <td>Forward</td>
    <td>Leap forward and slash, dealing 200% damage.</td>
  </tr>
  <tr>
    <td>Backward</td>
    <td>Backflip into the air, dealing 200% damage.</td>
  </tr>
  <tr>
    <td>Aerial</td>
    <td>Dash and slash towards a target, dealing 200% damage.</td>
  </tr>
  <tr>
    <td>Swap Neutral</td>
    <td>Invincibility. Slash up then down, dealing 2x200% damage.</td>
  </tr>
  <tr>
    <td>Swap Forward</td>
    <td>Invincibility. Dash forward very quickly, dealing 2x200% damage to enemies behind you.</td>
  </tr>
  <tr>
    <td>Swap Backward</td>
    <td>Invincibility. Backflip into the air, dealing 200% damage.</td>
  </tr>
  <tr>
    <td>Swap Aerial</td>
    <td>Invincibility. Dash and slash in a direction. Flip back on contact, dealing 200% damage.</td>
  </tr>
</tbody>
</table>

<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/84a61f86-f532-45d0-bd97-60de87048ec3" height ="256" >

#### Greatsword- Slow but high damage. Have 150 armor during all attacks. All attacks apply 'Vulnerability'- each stack causes an enemy to take 25% additional damage additively. Swap attacks have stun. All attacks have proc of 2. 
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/1f298eb6-e15a-4729-b24c-e1d1639e92c5" height ="128" >
<table>
<thead>
  <tr>
    <th>Greatsword input</th>
    <th>Description</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td>Neutral</td>
    <td>Vulnerability. Hold the button to enter a counter stance, gaining an additional 150 armor.<br>When hit, counter with a slam on the ground, dealing 800% damage. Invincible during the slam.</td>
  </tr>
  <tr>
    <td>Forward</td>
    <td>Vulnerability. Leap and slam the ground, dealing 400% damage.</td>
  </tr>
  <tr>
    <td>Backward</td>
    <td>Vulnerability. Charge your greatsword. <br>On release, swing in front of you, knocking enemies back deal 400%-1200% damage based on charge.</td>
  </tr>
  <tr>
    <td>Aerial</td>
    <td>Vulnerability. Swing your greatsword while falling, dealing 400% damage.<br>Deal damage based on how long you were falling when you hit the ground.</td>
  </tr>
  <tr>
    <td>Swap Neutral</td>
    <td>Vulnerability. Stun. Uppercut an enemy infront of you, launching them up for 400% damage.<br>Continue to hold the input to warp to the target and slam them down, dealing 400% damage.</td>
  </tr>
  <tr>
    <td>Swap Forward</td>
    <td>Vulnerability. Stun. Do a fast overhead swing, dealing 1000% damage.</td>
  </tr>
  <tr>
    <td>Swap Backward</td>
    <td>Vulnerability. Stun. Charge your greatsword. <br>On release, leap and slam the ground, dealing 400%-1200% damage based on charge.</td>
  </tr>
  <tr>
    <td>Swap Aerial</td>
    <td>Vulnerability. Stun. Warp and Uppercut the Target, launching them up for 400% damage.<br>Continue to hold the input to warp to the target and slam them down, dealing 400% damage.</td>
  </tr>
</tbody>
</table>
<img src= "https://github.com/1TeaL/Noctis/assets/93917577/e360325a-59a3-4c09-a736-ff805b2e6c60" height ="256" >

#### Polearm- Long range. Base attacks hit 2x minimum. Swap attacks hit 3x. Unique input of holding jump and attack. All attacks have proc of 0.3. 
<img src= "https://github.com/1TeaL/NoctisRoR2/assets/93917577/dfabccc1-e92f-4786-a160-83e020274b9f" height ="128" >
<table>
<thead>
  <tr>
    <th>Polearm input</th>
    <th>Description</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td>Neutral</td>
    <td>Thrust forward, dealing 2x150% damage.</td>
  </tr>
  <tr>
    <td>Forward</td>
    <td>Charge, then dash and thrust forward, dealing 2x150% damage.</td>
  </tr>
  <tr>
    <td>Backward</td>
    <td>Throw your polearm, piercing and dealing 2x150% damage.</td>
  </tr>
  <tr>
    <td>Aerial</td>
    <td>Dash and thrust forward at your aim direction. Backhop on contact, dealing 2x150% damage.</td>
  </tr>
  <tr>
    <td>Aerial + Jump</td>
    <td>Dragoon thrust, descending down, dealing 2x150% damage.<br>Deal damage based on how long you were falling when you hit the ground.</td>
  </tr>
  <tr>
    <td>Swap Neutral</td>
    <td>Sweep your polearm from right to left, dealing 3x150% damage.</td>
  </tr>
  <tr>
    <td>Swap Forward</td>
    <td>Dash and thrust forward, dealing 3x150% damage.</td>
  </tr>
  <tr>
    <td>Swap Backward</td>
    <td>Backhop, dealing 3x150% damage.</td>
  </tr>
  <tr>
    <td>Swap Aerial</td>
    <td>Thrust forward, dealing 3x150% damage.</td>
  </tr>
  <tr>
    <td>Swap Aerial + Jump</td>
    <td>Double Dragoon thrust, descending down, dealing 3x150% damage.<br>Deal damage based on how long you were falling when you hit the ground.</td>
  </tr>
</tbody>
</table>
<img src= "https://github.com/1TeaL/Noctis/assets/93917577/b766659f-381c-4a86-914d-966c37464cb7" height ="256" >

## Numbers
##### Armor = 10 + 0.5 per level
##### Damage = 12 + 2.4 per level
##### Regen = 1 + 0.2 per level 
##### Health = 162 + 15 per level
##### Movespeed = 7

These stats are prone to change.

rest of changelog on github.
## Changelog

<details>
<summary>Click to expand previous patch notes:</summary>

Rest of changelog on Github
</details>

## Credits
##### HenryMod for the template.
##### Ethanol10(discord ethanol10) for weapon shader and partial attack logic
 
<details>
<summary>Click to expand for OG pictures:</summary>

## OG Pictures
![greatsword](https://github.com/1TeaL/NoctisRoR2/assets/93917577/1f298eb6-e15a-4729-b24c-e1d1639e92c5)
![dodge](https://github.com/1TeaL/NoctisRoR2/assets/93917577/1f212e12-74ec-4e41-8b69-dcebf63bfc21)
![warpstrike](https://github.com/1TeaL/NoctisRoR2/assets/93917577/3f402b77-c2b7-495a-a90d-bfe9abfb99ab)
![sword](https://github.com/1TeaL/NoctisRoR2/assets/93917577/71e6552a-8ce3-4cfa-9dbc-44d976edcf39)
![polearm](https://github.com/1TeaL/NoctisRoR2/assets/93917577/dfabccc1-e92f-4786-a160-83e020274b9f)
![Passive](https://github.com/1TeaL/NoctisRoR2/assets/93917577/e39be057-e49d-4a5f-94e6-91d802deca7d)
![armiger](https://github.com/1TeaL/Noctis/assets/93917577/92dc53e7-45cb-40a8-b8be-4ea85ceb2e95)

![Menu](https://github.com/1TeaL/NoctisRoR2/assets/93917577/39143b59-0050-4035-b437-c5028b7f88e0)
![noctisDragoonThrust](https://github.com/1TeaL/NoctisRoR2/assets/93917577/b92a3e3b-ac4d-44ff-86f0-da1366a5119c)
![noctisGSChargeSlash](https://github.com/1TeaL/NoctisRoR2/assets/93917577/f5480f7b-d296-4581-9627-be8ef994c0f3)
![noctisSwordAerialSlash](https://github.com/1TeaL/NoctisRoR2/assets/93917577/890a73bf-ee33-4599-bd70-c2a9f6c36526)

![SwordCombos](https://github.com/1TeaL/NoctisRoR2/assets/93917577/84a61f86-f532-45d0-bd97-60de87048ec3)
![GSCombos](https://github.com/1TeaL/Noctis/assets/93917577/e360325a-59a3-4c09-a736-ff805b2e6c60)
![PolearmCombos](https://github.com/1TeaL/Noctis/assets/93917577/b766659f-381c-4a86-914d-966c37464cb7)

</details>























