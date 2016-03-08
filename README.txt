Setup Note:
Please set the BookFinder website in the Client solution folder as your *startup project before running. 


Over View:
 This exercise didn't call for a Data Access layer being implemented, so I'm spoofing it in the Business layer (FakeDomain). However the full architecture would go a bit like this, the arrows point to the assembly references:

Client --> Business Layer Interfaces <-- Business Layer Implementation (actual classes with logic in them) --> Data Access Layer Interfaces <-- Data Access Layer Implementation.

This architecture utilizes dependency injection and all coding done against members of an external assembly is done through interface abstractions. The composition root in this project is in the website, Global.asax specifically. To allow registration of assemblies outside of the Client boundaries, simple x-copy post-build commands are added to the website project. When it's built, or the solution is built, they copy the otherwise inaccessable assemblies to the bin of the project containing the composition root (mvc website) to allow the IOC container to scan them for the types required, with some help from reflection. 

This allows for the same benefits of N-Tier, where a layer or tier will have knowledge of its dependency, but the dependency has no knowledge of the projects referencing it. And makes for a much more modular code base with fewer dependencies, which allows for mocking in unit tests. Making the overall code base much more unit testable, and therefor making the code more stable.