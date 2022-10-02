
### https://www.udemy.com/course/unit-testing-nicopaez
### comandos
##### mkdir UnitTest
##### cd UnitTest
##### dotnet new console -n PruebasString -f netcoreapp3.1
##### dotnet new sln 
##### dotnet sln add .\PruebasString\PruebasString.csproj
##### dotnet new nunit --name StringTest -f netcoreapp3.1
##### dotnet sln add .\StringTest\StringTest.csproj

##### dotnet test --filter StringTest.ResultadoTest
##### dotnet test --filter StringTest.CasosDePrueba.SortOrdenaElementos
##### dotnet test --filter StringTest.CasosDePrueba.SortOrdenaElementosCuandoYaEstanOrdenados1
##### dotnet test --filter TestCategory=Ejemplos
##### dotnet test --filter StringTest.ExampleTest.Test1
##### dotnet test --filter StringTest.OrdenTest

##### dotnet test --filter StringTest.ResultadoTest.TestIgnorado
##### dotnet test --filter StringTest.ResultadoTest.TestQuePasa
##### dotnet test --filter StringTest.ResultadoTest.TestInconcluso
