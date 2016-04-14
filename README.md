### Info

it is een 2D Platformer spel gemaakt in unity3D (https://unity3d.com/)  
unity3D voor linux distributies (http://forum.unity3d.com/threads/unity-on-linux-release-notes-and-known-issues.350256/)  
Maps, levels, zijn gemaakt met Tiled (http://www.mapeditor.org)  
De maps van tiled zijn naar Unity geïmporteerd naar unity met behulp van Tiled2Unity   (http://www.seanba.com/tiled2unity)  
Om het project te bekijken/uitvoeren volstaat een installatie van de nieuwste versie van unity3D (versie 5.3.X)
### Controls toetsenbord:
Q: Beweeg naar links  
D: Beweeg naar rechts  
Spatie: Spring (2x indrukken voor double jump)  
E: Knife (melee attack)  
Enter: werpsterren gooien  
Z: Wanneer je in een EXIT portaal staat duw je op Z om naar een volgend level te gaan  
Escape: Pauze menu  
Z of S: omhoog of omlaag klimmen op een ladder  

### Controls Xbox Controller
Left Stick links/rechts: bewegen  
A: Springen (2x indrukken voor double jump)  
RB: Werpsterren gooien  
LB: Knife (melee attack)  
Left Stick omhoog/omlaag: op een ladder klimmen en om naar volgend level te gaan indien je in een EXIT portaal staat  
START: Pauze menu  

### Tiled

Voor Tiled zelf moet je de volgende waarden gebruiken, File > New > Orthogonal > XML of CSV > Map size Width en height kan je kiezen, maar ik neem meestal W: 300px en H: 100px.  
Tile size moet W:20px en H:20px zijn.  
Bij Map > New Tileset > Browse > spritesheet.png > Tile W: 20px, H: 20px, margin  en spacing 3px.   
Drawing offset laat je op 0.  
Nu kan je door blokjes te selecteren de map tekenen.   
Ook moet je layers toevoegen, bv alle Ground onderdelen in New Tile Layer Ground.   
Decoratie in Decoration, enemies en andere dingen waaraan je sterft Hazard
Coins, etc.   
Daarna kan je aan elke layer properties geven, bijvoorbeeld unity:layer ground, maar dit werkt niet altijd.  
 Het belangrijkste is nog Collisions toevoegen,
dit doe je door 1 voor 1 een blokje te selecteren en met Shift CTRL O (Collision editor) de collisions over de blokjes te tekenen.  
Zet zeker ook Snap To Grid aan bij view, daar vind je de Collision editor ook.


### Tiled2Unity

Om Tiled2Unity te gebruiken kan je de .exe voor Windows downloaden, en voor Linux of Mac OS X een console Script (Tiled2UnityLite: http://www.seanba.com/introducing-tiled2unitylite.html)  
Zelf heb ik het enkel getest op Windows, maar hun site staat goed beschreven hoe het voor Linux werkt.

Open Tiled2Unity.exe en je Unity project.  
Voor eerste gebruik, als je nog geen Tiled2Unity in je project hebt geïnstalleerd (In dit project is dit wel het geval) ga je naar HELP > Import Unity Package To Project.  
Daarna wordt het automatisch geïnstalleerd in het openstaand project.  
Vervolgens zoek je de opgeslagen map gemaakt met Tiled (.tmx). Ga naar File > Open Tiled File om het bestand te laden.  
Ga naar je project > Assets > Tiled2Unity > en zoek Tiled2Unity.export

***Belangrijk*** Zet de Vertex Scale naar 0.05 en kruis het vakje ernaast AAN.  
Dit is de scale, grootte van de map die in je project wordt weergegeven.  
Om de Vertex Scale van je map te berekenen doe 1 gedeeld door het aantal pixels van de blokken, bij dit project is dit 20.   
Dus 1/20 = 0.05  
Ten slotte klik je op de Export knop en als er geen errors zijn werkt het.  
Je map staat in Unity bij Assets > Tiled2Unity > Prefabs. Je kan dit gewoon op je Scene slepen.

### Na het importeren

Om een nieuw level te maken/te testen kan je best bij File > Save Scene een kopie maken van het vorige level en dan daarin de nieuwe map zetten en het vorige verwijderen.   
Zo blijven de settings bij beide maps gelijk.   
Je moet ook nog de map die je er hebt ingesleepd selecteren en de Tag + Layer op Ground zetten, in de Inspector, meestal rechts boven op het scherm.  
Doe je dit niet kan je niet double jumpen en vallen de enemies door de map.  
Omdat de enemies scriptjes hebben die voordurend naar de Tag Ground zoeken, anders vallen ze van de map.


