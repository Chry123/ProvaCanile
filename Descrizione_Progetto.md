# ProvaCanile
Esercitazione Canile

Descrizione progetto:
Il progetto prevede la realizzazione di una single page application che implementi un CRUD per la gestione dei canie e la conservazione degli stessi in un database.

Struttura progetto:

1)DATA

La cartella DATA, contiene le classi e DataBase(le strutture dati), riguardanti i Cani:

Cane.cs rappresenta un insieme di dati che riguardano i dati specifici di un Cane;
BancaDati.cs rappresenta il DbContext e quindi la connessione al database;

2)Pages 

Il contenuto di Pages descrive gli end point del progetto.
Il quale nel mio progetto viene sopranominato Cani.razor. 

3) DataBase

Canile.db rappresenta il database dei cani, in cui si andrà a a Salvare i dati oppure Creare nuovi campi in caso dovesse essere aggiunto un nuovo cane,
Modificare se ci dovessere essere delle mofifiche da svolgere e infine Eliminare il rispettivo campo.

      USER FLOW
      Qui apparirà la HOME della mia single page
![canile1](https://user-images.githubusercontent.com/73218507/116679195-883a7900-a9aa-11eb-8767-64ac2b5a0735.png)
      Qui apparirà il canile con gli implementi crud dell mio Canile
![canile2](https://user-images.githubusercontent.com/73218507/116679197-88d30f80-a9aa-11eb-906d-20c27f49f331.png)
