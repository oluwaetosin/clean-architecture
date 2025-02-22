dotnet new webapi -o GymManagement.Api
dotnet  new classlib -o GymManagement.Domain
dotnet  add GymManagement.Api reference GymManagement.Application 
dotnet sln add **/**.csproj 
dotnet run GymManagement.Api
dotnet add GymManagement.Application package Microsoft.Extensions.DependencyInjection.Abstractions