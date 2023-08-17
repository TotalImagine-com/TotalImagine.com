# (Engineering) Design Process

Origin: UofT EngSci Year 1 Praxis
Original Draft: ???

(PENDING REVIEW AND REORGANIZE MATERIALS FROM UNIVERSITY TIME)
(PROVIDE DIAGRAMS)

## Principles of Software Design

(General high-level rules, concerning management and good second-nature intuitions, nothing related to deep architectural or design patterns)

* If you are not sure whether to keep or remove a feature while trying to trimming down/refactor a solution/project, just remove the god-damn feature to make everything lean.
* A (C#) (non-windows specific) CLI project should NEVER directly link against a Windows-specific or GUI project. If you really need to "trigger/call/retrieve" stuff from that assembly, use IPC to achieve it: spawn it as subprocess, or use sockets for communication. Don't include it at link time as part of the CLI assembly.
* Only add a feature if there is real use cases/demands FROM real production use.