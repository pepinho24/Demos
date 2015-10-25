#How to implement a Chain of Responsibility Design pattern with C#.

1. Create the abstract handler (e.g. DeveloperTeam)
	- Properties: 
		* Successor 
	- Methods:
		* SetSuccessor
		* HandleRequest (here we decide what happens when the request cannot be handlede)
		* abstract bool CanHandle
		* abstract Handle (e.g. DevelopSoftware)
		
2. Create handler factory (e.g. DeveloperTeamFactory)
	- Method CreateAndAttachHandlers
		* here we set the successor rules and create the handlers
		* return the first handler in the chain
3. Create the handlers (e.g. JuniorDeveloperTeam, RegularDeveloperTeam, SeniorDeveloperTeam)

4. Create the request class (e.g. SoftwareRequest)

## How to handle the request 
In the Main method
	1. create requests
	2. create new handler factory
	3. create a handler (by calling the method of the factory)
	4. give the request to the handler's HandleRequest method