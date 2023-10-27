# Prova di esame

## Testo

Esame di Programmazione C#

Durata: 3 ore

Titolo: ZooManager

L'applicazione "ZooManager" è un gestore che consente di gestire un database di animali e gabbie di uno zoo. 
L'applicazione ZooManager dovrà consentire agli utenti di gestire animali e gabbie di uno zoo, aggiungendo, cancellando e modificando le informazioni nel database. 
Inoltre, permetterà di registrare i pasti dati agli animali. 
L'applicazione salverà e caricherà lo stato del database da un file json per preservare i dati tra le diverse esecuzioni.

L'applicazione dovrà includere le seguenti classi:

1. "Animal": rappresenta un animale nello zoo e ha le seguenti proprietà: "Id" (identificativo dell'animale), "Name" (nome dell'animale), "Kind" (specie animale) e "Food" (tipologia di cibo mangiato). 

2. "Cage": rappresenta una gabbia nello zoo e ha le seguenti proprietà: "Id" (identificativo della gabbia), "Name" (nome della gabbia) e "Animals" (lista degli identificativi degli animali presenti nella gabbia).

3. "FoodLog": rappresenta un registro dei pasti dati agli animali e ha le seguenti proprietà: "AnimalId" (identificativo dell'animale), "Food" (tipo di cibo dato) e "Timestamp" (data e ora del pasto).

4. "Database": rappresenta il database dello zoo e ha le seguenti liste: "Animals" (lista degli animali presenti nello zoo), "Cages" (lista delle gabbie presenti nello zoo) e "Meals" (registro dei pasti degli animali).

5. "ZooManager": rappresenta il gestore dell'applicazione. Ha un percorso del file per il database come costante, un oggetto di tipo Database come variabile privata e include i seguenti metodi:

- "Load": carica lo stato del database dal file in formato JSON.
- "Start": avvia l'applicazione e richiede all'utente di inserire i comandi per interagire con il database.
- "Summary": mostra un riassunto della situazione attuale del database, incluso il numero di animali, il numero di gabbie, la gabbia con il maggior numero di animali e il numero di pasti registrati.
- "GetCommand": chiede all'utente di inserire un comando specifico.
- "Space": stampa una spaziatura vuota nella console.
- "SetCommand": invoca i metodi appropriati in base al comando scelto dall'utente.
- "AddAnimal": aggiunge un nuovo animale al database, richiedendo all'utente di inserire il nome dell'animale, il tipo di cibo e la specie animale.
- "DeleteAnimal": cancella un animale dal database, richiedendo all'utente di inserire il nome dell'animale da cancellare.
- "AddCage": aggiunge una nuova gabbia al database, richiedendo all'utente di inserire il nome della gabbia.
- "DeleteCage": cancella una gabbia dal database, richiedendo all'utente di inserire il nome della gabbia da cancellare.
- "AddAnimalToCage": aggiunge un animale a una gabbia, richiedendo all'utente di inserire il nome dell'animale da aggiungere e il nome della gabbia in cui aggiungerlo.
- "RemoveAnimalFromCage": rimuove un animale da una gabbia, richiedendo all'utente di inserire il nome dell'animale da rimuovere e il nome della gabbia in cui si trova.
- "FeedAnimal": registra un pasto dato a un animale, richiedendo all'utente di inserire il nome dell'animale da sfamare.
- "Save": salva lo stato attuale del database su un file in formato JSON.

Buon lavoro!


## Possibili classi

Il codice deve rappresentare un'applicazione per la gestione di uno zoo. 

L'enum `FoodType` rappresenta le possibili tipologie di cibo che un animale può mangiare: Onnivoro, Carnivoro, Erbivoro.

La classe `Animal` rappresenta un animale nello zoo e contiene le seguenti proprietà:
- `Id`: l'identificativo dell'animale
- `Name`: il nome dell'animale
- `Kind`: la specie dell'animale
- `Food`: il tipo di cibo mangiato dall'animale (enum `FoodType`)

La classe `Cage` rappresenta una gabbia nello zoo e contiene le seguenti proprietà:
- `Id`: l'identificativo della gabbia
- `Name`: il nome della gabbia
- `Animals`: una lista degli identificativi degli animali che vivono nella gabbia

La classe `FoodLog` rappresenta un registro dei pasti degli animali e contiene le seguenti proprietà:
- `AnimalId`: l'identificativo dell'animale
- `Food`: il tipo di cibo dato all'animale
- `Timestamp`: la data e l'ora in cui è stato dato il pasto

La classe `Database` rappresenta un database contenente le liste degli animali, delle gabbie e dei pasti.

La classe `ZooManager` rappresenta il gestore dell'applicazione e contiene i metodi per gestire le operazioni nello zoo. Alcuni dei metodi principali sono:
- `Load()`: carica lo stato del database da un file JSON
- `Start()`: avvia l'applicazione
- `Summary()`: mostra un riepilogo della situazione attuale del database
- `GetCommand()`: chiede all'utente di inserire un comando e restituisce il numero corrispondente
- `SetCommand(int command)`: invoca il comando corrispondente al numero passato come parametro
- `AddAnimal()`: aggiunge un nuovo animale al database
- `DeleteAnimal()`: rimuove un animale dal database
- `AddCage()`: aggiunge una nuova gabbia al database
- `DeleteCage()`: rimuove una gabbia dal database
- `AddAnimalToCage()`: aggiunge un animale a una gabbia esistente
- `RemoveAnimalFromCage()`: rimuove un animale da una gabbia
- `FeedAnimal()`: registra il pasto di un animale
- `Save()`: salva lo stato del database su un file JSON

L'applicazione sarà richiata tramite l'unico metodo pubblico `Start()` del gestore `ZooManager`.

## Esempio di flusso

### Status attuale del database e lista dei comandi

	Il numero di animali è: 0
	Il numero di gabbie è: 0
	Non ci sono animali in gabbia
	Il numero di pasti è: 0


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.

### Inserimento animale con comando 1

	1
	Il nome dell'animale è:
	Fabio
	Cosa mangia? 0 per onnivoro, 1 per carnivoro, e 2 per erbivoro.
	0
	La specie è:
	Orso


	Il numero di animali è: 1
	Il numero di gabbie è: 0
	Non ci sono animali in gabbia
	Il numero di pasti è: 0


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.

### Rimozione animale con comando 2

	2
	Inserisci il nome dell'animale da cancellare.
	Fabio


	Il numero di animali è: 0
	Il numero di gabbie è: 0
	Non ci sono animali in gabbia
	Il numero di pasti è: 0


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.


### Aggiunta gabbia con comando 3

	3
	Il nome della gabbia è:
	Folklore


	Il numero di animali è: 0
	Il numero di gabbie è: 1
	Non ci sono animali in gabbia
	Il numero di pasti è: 0


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.


### Rimozione gabbia con comando 4

	4
	Inserisci il nome della gabbia da cancellare.
	Folklore


	Il numero di animali è: 0
	Il numero di gabbie è: 0
	Non ci sono animali in gabbia
	Il numero di pasti è: 0


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.


### Aggiungere un animale ad una gabbia

	5
	Inserisci il nome dell'animale da aggiungere.
	Fabio
	Inserisci il nome della gabbia dove aggiungerlo.
	Folklore


	Il numero di animali è: 1
	Il numero di gabbie è: 1
	La gabbia con più animali è: Folklore
	Il numero di pasti è: 0


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.


### Rimuovere un animale dalla gabbia

	6
	Inserisci il nome dell'animale da cancellare.
	Fabio
	Inserisci il nome della gabbia da cancellare.
	Folklore


	Il numero di animali è: 1
	Il numero di gabbie è: 1
	Non ci sono animali in gabbia
	Il numero di pasti è: 0


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.


### Dare da mangiare

	7
	Inserisci il nome dell'animale da sfamare.
	Fabio
	Fabio sta mangiando cibo Omnivorous.


	Il numero di animali è: 1
	Il numero di gabbie è: 1
	La gabbia con più animali è: Folklore
	Il numero di pasti è: 1


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.


### Salvataggio

	90
	Salvataggio effettuato con successo.


	Il numero di animali è: 1
	Il numero di gabbie è: 1
	La gabbia con più animali è: Folklore
	Il numero di pasti è: 0


	Salve zoo di Wano. Cosa vuoi fare?
	Aggiungere un animale con 1.
	Cancellare un animale con 2.
	Aggiungere una gabbia con 3.
	Cancellare una gabbia con 4.
	Aggiungere un animale ad una gabbia con 5.
	Rimuovere un animale da una gabbia con 6.
	Dare da mangiare ad un animale con 7.
	Salvare la situazione con 90.
	Uscire con 100.


### Uscire

	100
	Chiusura dell'applicazione

## Punteggio

- Divisione della soluzione in due progetti, un progetto libreria ed un progetto applicazione, creazione ed allaccio +2
- Commenti, aggiunta commenti con triplo slash su ogni classe e su ogni metodo +2
- Ogni classe ha il suo file +2
- Creazione classe animale +1
- Creazione classe gabbia +1
- Creazione enumerato tipologia animale +1
- Creazione classe per salvare ciò che hanno mangiato e quando +1
- Creazione classe manager per la gestione dell'applicazione +0
- Aggiungere un animale con 1. +1
- Cancellare un animale con 2. +1
- Aggiungere una gabbia con 3. +1
- Cancellare una gabbia con 4. +1
- Aggiungere un animale ad una gabbia con 5. +1
- Rimuovere un animale da una gabbia con 6. +1
- Dare da mangiare ad un animale con 7. +1
- Salvare la situazione con 90. +2
- Uscire con 100. +1
