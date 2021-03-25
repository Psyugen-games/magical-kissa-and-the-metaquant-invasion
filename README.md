# Magical Girl Game Jam Project
## 13/02/2021-14/03/2021
### Domande fondamentali
- [x] Qual è il ruolo della fisica quantistica nella storia? 
  
- [X] Qual è il ruolo della fisica quantistica nelle meccaniche?
- [ ] Chi sono i MetaQuant?
  - [ ] a. *Particelle con due stati e tendenze diverse, con poteri speciali presi dalle varie tipologie di particelle quantizzate*
- [x] La bacchetta, nel contesto della fisica quantistica, cosa fa e come? 
  - *Può funzionare come un'onda elettromagnetica che distingue le due entità aliene coesistenti, e cioè avvia la misurazione della superposizione; è inoltre la sua arma a distanza*
- [ ] Come rendere lo spazio challenging? 
- [ ] Qual è l'obiettivo del formarsi una strada nello spazio ludico? 
- [ ] Vogliamo attenerci alle formule in maniera stretta o solo richiamarle?
  - [ ] a. _è possibile inizialmente tentare senza la formula reale, ma con una emulata
  - [ ] b. _potremmo semplificare al Livello 1 e complicare (cioè riprendere l'esatta formula) dal Livello 2
- [ ] Kissa ha solo una bacchetta? O si trasforma? 
- [ ] Intermittenza di " :angry: " e " :smile: " : una delle due deve essere sempre visibile o no?
- *Una sempre visibile*
### Tema
#### Concetti della fisica quantistica 
Fisica Classica  | Fisica Quantistica
------------- | -------------
Leggi del moto  | Probabilità
Logica | Creatività

Quantum-to-classical crossover teoricamente possibile

**Stato**: è calcolato da quattro numeri: 
- principal quantum number: livello di energia 
- angular quantum number: momento angolare dell'orbita che rimane costante, anche senza l'oggetto al punto d'origine del movimento
- magnetic quantum number: posizione nella sua orbita (alla base della posizione e del comportamento ad onda) 
- spin quantum number: momento orbitale intrinseco della particella, cioè su sé stessa. 
Excited state: il livello di energia è maggiore di 0 
Ground state: il livello di energia è pari a 0

#### Superposizione
Una particella ha almeno due stati nello stesso tempo: excited state e ground state, tale per cui: 

![](https://wikimedia.org/api/rest_v1/media/math/render/svg/0c70e3f4154d8f2974e8ab95d2bd7d6a022712ec) è la descrizione del qubit nel suo stato generale (superposto). 

Per determinare le oscillazioni tra questi stati (la cui distinzione tra excited e ground è per ridurre la complessità al minimo), è necessaria una misurazione nel tempo tramite un'interferenza di altre particelle nello stesso environment, le quali urtano la particella in superposizione. 
La misurazione determina un collasso della superposizione e una scelta casuale, ma comunque nel rispetto delle probabilità, di uno stato in un determinato tempo. La particella, durante la superposizione, ha fatto esperienza di tutti gli stati possibili, mantenendo le "informazioni" derivate anche dall'esterno: ciò vale anche per i qubit.

![](https://scontent-mxp1-1.xx.fbcdn.net/v/t1.0-9/150816225_5047686428634930_6091873499602434467_o.jpg?_nc_cat=106&ccb=3&_nc_sid=730e14&_nc_ohc=xGdqd0k7O34AX8dWxf4&_nc_ht=scontent-mxp1-1.xx&oh=b54021eecc926a8f52c6f82a418131e4&oe=60504381)
> La particella, vivendo entrambi gli stati (che includono la posizione), si estendono nello spazio rivelando la natura duale di onda-particella

------------
## Resa del tema nelle meccaniche
### Livello 1
Il livello 1 è un'introduzione alla storia e ai poteri dell'eroina. La superposizione qui è resa nella maniera più semplice, con la probabilità (i movimenti sono gli seguono un pattern prevedibile, e la divisione in stati è un semplice 50%).  
#### Tipologia A: combattimento
Due sfere, gli stati dell'alieno, in grado di attaccare l'eroina a grande velocità, correndo su una ellissi e apparendo in vari punti casualmente e alternate.
fase 0: superposizione, in cui i due stati si muovono in direzioni opposte e casualmente una sola compare, visibile, nell'orbita e attaccano indistruttibili la magical girl   
fase 1: misurazione di successo (3 lanci che colpiscano gli stati **sovrapposti**)
fase 2: uno dei due stati scompare e l'altro si blocca in uno dei punti di **sovrapposizione** (quando l'onda viene emanata e le due sfere si incrociano)  
fase 3a: la magical girl colpisce con successo e sconfigge l'alienetto  
fase 3b: la magical girl non colpisce l'alienetto in tempo: questo si rialterna con il vecchio stato e si ritorna alla fase 1.   

#### Tipologia B: interazione con l'environment 
Per aprire delle porte, Kissa ha bisogno di superare un alieno, i cui due stati sono relativi all'energia. 
a. se in ground state " :sleeping: " , Kissa può usare la sua bacchetta per attraversare l'alieno, e colpire un bottone altrimenti irraggiungibile 
b. se in excited state " :flushed: " , l'interazione di Kissa (che sia avvicinandosi troppo, attaccandolo, o usando la bacchetta) provoca l'alieno, che la danneggia con un attacco che ha lui stesso come centro; attacchi a distanza rimbalzano indietro.

![1838785fb5138d0](https://user-images.githubusercontent.com/77356049/110204818-6d013080-7e75-11eb-99a3-8bc8bcc69ccc.png)
> a.

![0fbcff94fb663e9](https://user-images.githubusercontent.com/77356049/110204532-d2ecb880-7e73-11eb-80fa-cfe2b8486933.png)
> b.

*alternativa: life-link, e cioè uno stato perde vita , l'altro la guadagna; per sconfiggere l'alienetto, la magical girl deve riuscire ad attaccare contemporaneamente entrambi nel momento in cui l'alternanza tra gli stati è stabile e ben intervallata
*alternativa: diverse tipologie di superposizione, una legata alla posizione (movimento ellittico) e una legata allo stato di energia (dormiente o attiva, cioè excited e ground state)

Questa meccanica richiede al giocatore riflessi, per evitare di subire attacchi e lanciare l'incantesimo della magical girl al momento giusto.

#### Prototipazione 
In questo prototipo ci concentriamo sullo **stato** nel senso di **posizione** all'interno di un'ellissi. I due stati sono separati da principio e compaiono a intermittenza in punti casuali dell'orbita. Nello specifico della fase 3b, testare se, a livello di esperienza di gioco, sia meglio costringere il giocatore a colpire o l'alienetto nello stato neutralizzato in precedenza, o il suo "gemello" che prima era scomparso. 
Due comandi separati per misurazione e attacco per la magical girl; la particella attacca con un singolo proiettile dalla fase 2, mentre durante la fase 1 genera un'onda quando i due stati si incontrano più spesso nell'orbita (da rendere anche semplicemente con un aumento del lancio di proiettili). Durante la misurazione, i proiettili della magical girl urtano quelli dell'alieno (non si trapassano a vicenda). 

##### Assets and graphics: 

+ Tileset 
   + https://apokalips123.itch.io/sci-ficyberpunk-tileset
   + 
+ Environment 
   + [Pixel Lab](https://zrghr.itch.io/pixel)
   + [Sci-fi Tilemap](https://moose-stache.itch.io/sci-fi-tilemap)
   + [Pixel Art Planets](https://helianthus-games.itch.io/pixel-art-planets)
+ Particles 
   + [Pixel-art Game Spell/Magic FX](https://ppeldo.itch.io/2d-pixel-art-game-spellmagic-fx)
   + [Explosion Spritesheet](https://craftpix.net/product/explosion-sprites/)
   + [10 MAGIC SPRITE SHEET EFFECTS](https://craftpix.net/product/10-magic-sprite-sheet-effects-pixel-art/)
   + [Free Enemy Spaceship](https://free-game-assets.itch.io/free-enemy-spaceship-2d-sprites-pixel-art)
+ Main Character 
   + 
+ MetaQuant
+ [MetaQuant Sketch](https://www.piskelapp.com/p/agxzfnBpc2tlbC1hcHByEwsSBlBpc2tlbBiAgOCk35j8Cww/view)
   + [Wraiths](https://craftpix.net/freebies/free-wraith-tiny-style-2d-sprites/)
   + [Monster 2D Game Items](https://craftpix.net/freebies/free-monster-2d-game-items/)
+   Objects 
   + [Free Enemy Spaceship](https://free-game-assets.itch.io/free-enemy-spaceship-2d-sprites-pixel-art) * spaceships as environmentals * 

### Livello 2 
Il livello 2 aggiunge alla meccanica del livello 1 l'entanglement, e quindi la concatenazione delle varie particelle le quali mantengono la memoria della superposizione. Ora la magical girl, a seconda di chi ha neutralizzato, potrà acquisire, nella sua scatola, i poteri dello stato dell'alieno. Questo gli servirà per muoversi nello spazio, in una meccanica di movimento che ancora devo ragionare ma che pensavo di riprendere dal gioco da tavolo "Labyrinth" e adattarlo (concettualmente) a superposizione ed entanglement. Dall'altra parte, ogni alienetto ha un indizio su come trovare il boss (non ho ancora pensato che tipo di indizio). 
Questa meccanica vuole caratterizzare la magical girl, sia riprendendo un piccolo "skill tree", sia a livello caratteriale: rispettando l'aura di dolcezza delle magical girl, e prendendo ispirazione da "Pesca la tua carta Sakura", così facendo gli alienetti sconfitti sono resi amici, o almeno alleati; dall'altra parte, dà un senso al viaggio con il mistero da risolvere per scovare il villain.
*alternativa: i poteri degli alienetti sono scelti casualmente, e vorticano attorno all'eroina e non chiusi nella scatola, visto che la m.g. è diventata il nuovo fulcro degli alieni che ha sconfitto (e conseguentemente attirato a sé)*

### Livello 3 
Il livello 3 ha in più la disiinzione tra i poteri dati degli stati (excited o grounded), quello della tipologia di alienetti-particelle: force o matter, e avere quindi degli attacchi in più e non solo qualcosa che agisce sul movimento. 
Quindi, l'intenzione è approfondire non solo il tema, pur in maniera umanamente progettabile in un mese e quindi in una resa assolutamente fantasiosa, ma anche il suddetto skill tree e la customization della magical girl in senso lato (anche estetico). 

### Livello 4 
Tutte le meccaniche testate e conosciute dal giocatore nei livelli precedenti, diventano gli strumenti contro il villain, che è potenziato da quelle particelle che, nel processo della superposizione e poi del collasso, la magical girl non ha inglobato. Il villain è composto quindi da tanti alienetti, lui stesso con vari "fulcri" (= particelle) che si muovono ed emanano i loro poteri verso l'esterno (= onde). Qui si riprenderebbe la meccanica pensata inizialmente: inversione della posizione delle particelle (esteticamente simili ai pixel) e quindi reindirizzamento dei poteri. Va approfondito e creato uno schema di possibili interazioni, sia tra gli alieni dentro il villain, che l'incontro tra questi e i poteri della magical girl.

## Resa del tema nella storia
Kissa è una studentessa d'arte, che un giorno visita il laboratorio dove è stato appena brevettato il primo computer in qubit. 
Il computer, nel momento in cui interagisce con la ragazza, le manda un messaggio da un'altra dimensione: il mondo da cui la contattano è stato attaccato e distrutto da degli alieni, chiamati MetaQuant, capaci di prendere il controllo del pianeta decomponendosi in particelle. Il motivo per cui è Kissa a ricevere il messaggio è perché in quella dimensione la sua "controparte" è una scienziata ed è stata lei a costruire il computer in qubit. Per il principio della superposizione, e quindi dell'entanglement, essendo loro legate l'una all'altra come "gemelle", la Kissa scienziata, morta durante l'attacco, può trasmettere alla pittrice le sue conoscenze ed evitare che anche il suo mondo venga distrutto. 
Kissa, quindi, si può trasformare in una magical girl (inoltre essere "sia viva che morta") e usare il computer in qubit per fermare gli alieni. 

Il loro leader, però, può usare solo il qubit per interagire in questo mondo: l'unico modo per poter uscire dal computer è azionare un congegno nascosto all'interno del computer e che lo ha rinchiuso, perché sia in grado di trasformarlo in un vero e proprio teletrasporto. Kissa, quindi, dovrà interagire con gli alienetti per togliere potere al mostro, trovare un modo (attraverso la soluzione di indovinelli) per entrare nel marchingegno, sconfiggere il leader degli alieni, disattivare il congegno e riuscire a scappare in tempo. Questo chiuderà il collegamento stretto con l'altra dimensione, ma i poteri donati a Kissa per la morte della sua controparte scienziata rimarranno. 

## Game Pitch 
#### Game Title 
"Magical Kissa and the MetaQuant Invasion"
#### Genre 
Side-scrolling platformer. 
#### Target 
From the age of 11 to 16 years old.
#### Synopsis 
Kissa is 15 years old and a wannabe painter and art student, who gets teleported into a quantum computer. There, the hologram of a scientist, who is her spitting image, tells her that an alien race invaded Earth in her dimension: the MetaQuant, able to decompose and split themselves into particles, this way travelling through space. Doctor Saski (that is her name) used her own creation, the quantum computer, to trap the aliens inside: she's giving Kissa magical powers to defeat the MetaQuant before they get out of there and destroy Earth. 
Before dying, Saski locked the leader of the MetaQuant in a box inside the quantum computer: Kissa will need to gain strength and ability in her journey to reach the box and save the world. 
##### Characters 
**Kissa** - ***player character***

Saski - *non-player character, she interacts with Kissa through dialogues in key moments of the story*

MetaQuant - *enemies*

MetaQuant Leader - *final boss*
##### World 
The interior of a quantum computer.
#### Art
2D Pixel art (32x32).
##### Environment 
Resembles the aesthetics of a quantum computer: tubes, long spirals, gold and silvery vertical wires from where platforms hang; plus, some flashing light runs on the background through the tubes. On Level 1, the environment is bright, but it gets darker and darker each Level. 
##### Main Character 
Long, wavy and brown hair; purple eyes with feline-shaped pupils. 
She wears headphones with robotic cat ears on the top; on the left side, however, the earbud is gone and there's only a microphone.
Light skin, she has scars on the left side of her body and her left cat ear is broken.  
Costume: sleeveless white open gown (similar to those used by scientists and artists to keep their clothes clean), tightended by a corset; heart-shaped top and flounce miniskirt, asymmetrical as it gets longer on the left leg, while it reveals lining shorts under it on the right side; she wears a single parisian sock on her right leg and short boots. 
Colourful, colours contrasting the background.
##### Kissa's Quarterstaff 
Magical quarterstaff which holds Kissa's and Saski's essence: it has one big brush on one side (that used to attack), and the particles nebulosa on the other (used to measure MetaQuant)
##### MetaQuant 
Draft: https://www.piskelapp.com/p/agxzfnBpc2tlbC1hcHByEwsSBlBpc2tlbBiAgOCk35j8Cww/view 
Best way to describe them is: between UFOs (since they have an elliptical shape, and their paws rotate as the lights on the bottom of the typical UFO), "emojis" (since their expressions are one of the most apparent features distinguishing one twin from the other, along with the colours, and at the same time represent the kind of skills they have), and their general stylized shapes are similar to the aliens from Space Invaders. 
##### Games to take inspiration from: 
- _Sword of Mana_: the main character's expressiveness and detailed pixel art.
#### Gameplay 
The mechanics are inspired upon quantum superposition and entanglement: for this reason, one alien is composed by two twins as superposition is explained as two opposed statuses of the same quantum. The MetaQuant simulate the particles' behaviour, in an increasing difficulty as the player moves forward.
Once entanglement is introduced as an additional mechanic, Kissa is able to increase and build her powers according to the typology of MetaQuant twin she's "entangled" with: this will change the MQ Leader fight skills depending on the alien who's not been linked to the player. 
Four levels.
Single Player, narrative storyline. 
#### Platform 
PC
