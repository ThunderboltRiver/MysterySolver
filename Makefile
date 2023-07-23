build:
	dotnet build Concepts
	dotnet build Concepts.Tests


clean:
	rm -rf Concepts/bin Concepts/obj
	rm -rf Concepts.Tests/bin Concepts.Tests/obj


re-build:
	rm -rf Concepts/bin Concepts/obj
	rm -rf Concepts.Tests/bin Concepts.Tests/obj
	dotnet build Concepts
	dotnet build Concepts.Tests