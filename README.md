# Programozási technológiák - 2021.tavasz

2021.06.11

Győri Zoltán - Gazdaságinformatikus levelező tanrend

Neptunkód: SREQ8K

## Factory method - létrehozási tervezési minta

#### A minta rövid leírása

A gyártómetódus (angolul: factory method) egy létrehozási tervezési minta. Ezzel a mintával lehet kiváltani a programunkban lévő rengeteg hasonló *new* utasítást. Ezt magyarul gyakran készít, angolul a *create* szóval kezdjük. A gyártómetódus a nevében magadott terméket adja vissza, tehát a készítKutya (angolul: createDog) egy kutyát, a készítMacska (angolul: createCat) egy macskát. Ez azért jobb, mint a new Kutya() vagy a new Macska() konstruktor hívás, mert itt az elkészítés algoritmusát egységbe tudjuk zárni. A legfőbb előnye az, hogy ha a gyártás folyamata változik, akkor azt csak egy helyen kell módosítani. Általában a gyártás folyamata ritkán változik, inkább az a kérdés mit kell gyártani, azaz ez gyakran változik, ezért ezt az OCP elvnek megfelelően a gyermek osztály dönti el.
Tehát az ősben lévő gyártómetódus leírja a gyártás algoritmusát, a gyermek osztály eldönti, hogy mit kell pontosan gyártani. 

Ezt úgy érjük el, hogy az algoritmus háromféle lépést tartalmazhat:

- <u>A gyártás közös lépései:</u> Ezek az ősben konkrét metódusok, általában nem virtuálisak, illetve Java nyelven final metódusok.
- <u>A gyártás kötelező változó lépései:</u> Ezek az ősben absztrakt metódusok, amiket a gyermek felülír, hogy eldöntse, hogy mit kell gyártani. A gyermek osztályok itt hívják meg a termék konstruktorát.
- <u>A gyártás opcionális lépései:</u> Ezek az ősben hook metódusok, azaz a metódusnak van törzse, de az üres. Ezeket az OCP elv megszegése nélkül lehet felülírni az opcionális lépések kifejtéséhez.

Az absztrakt ős és a gyermek osztályai IoC (angolul: Inversion of Control) viszonyban állnak. Azaz nem a gyermek hívja az ős metódusait, hanem az ős a gyermekét. Ezt úgy érjük el, hogy a gyártómetódus absztrakt-, illetve virtuális metódusokat hív. Amikor a gyermek osztály példányán keresztül hívjuk majd a gyártómetódust, akkor a késői kötés miatt ezen metódusok helyett az őket felülíró gyermekbéli metódusok fognak lefutni.

#### Példa kód

A választott *Gyártómetódus* létrehozási tervezési minta megvalósítása érdekében egy izzókat gyártó cég több különbféle paraméterrel rendelkező termékét vettem alapul. Elkészítettem a Termék osztályt, ami a "Bulb" nevet viseli és ezen belül létrehoztam az absztrakt mezőket, a *get* és *set* metódusukkal együtt, amelyeket később felüldefiniálok. Elkészítettem 3 konkrét termék, *Normál*, *Led* és *Halogén* Izzó osztályát a mezőivel, tulajdonságaival és metódusaival együtt. Ezeket leszármaztattam a "Bulb" osztályból. Rendre, "NormalBulb", "LedBulb", "HalogenBulb" nevet viselik. Ezt követően implementáltam az absztrakt gyárat, melyet "BulbFactory"-nak neveztem el.  Létrehoztam az izzóknak megfelelő gyártó osztályokat, azok mezőivel és metódusaival. Név szerint "HalogenBulbFactory", 'NormalBulbFactory", "LedBulbFactory". Ezen osztályokat leszármaztattam a "BulbFactory" absztrakt osztályból. A főprogramban elkészítettem 3 minta izzót.

#### A kód osztály diagramja

#### ![](https://github.com/gyoriz90/progtech_beadando/blob/main/pics/cd.png?raw=true)