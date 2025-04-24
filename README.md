1.
Aquesta llibreria permet interactuar amb processos, esdeveniments i traçabilitat. Els membres més útils inclouen:

Classe Process: per gestionar processos del sistema.

Start(): inicia un nou procés.

Kill(): finalitza un procés.

GetProcesses(): retorna tots els processos actuals.

ProcessName: nom del procés.

Id: PID del procés.

Threads: fils del procés.

Classe ProcessThread:

Id: identificador del fil.

StartTime: hora d'inici.

PriorityLevel: nivell de prioritat.

Classe Debug i Trace: per escriure missatges de depuració o registre.

WriteLine(): escriu missatges.

Assert(): comprova condicions en temps d’execució.

4. 

Característica       Thread                         Task
Creació              Manual (new Thread)            Automàtica (Task.Run())
Paral·lelisme        Natiu, un fil per instància    Utilitza thread pool
Rendiment            Més costós                     Més eficient per IO-bound
Cancel·lació         Difícil de gestionar           Amb CancellationToken
Retorn de resultat   No retorna valors              Pot retornar valors
