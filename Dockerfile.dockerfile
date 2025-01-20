# Use the official .NET image from Docker Hub
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["I:\Jannat x360 D-docx\Meritech\Youtube-Viewers-Master\youtube-viewers-master\youtube-viewers-master\YouTubeViewers.WPF\YouTubeViewers.WPF.csproj", "I:\Jannat x360 D-docx\Meritech\Youtube-Viewers-Master\youtube-viewers-master\youtube-viewers-master\YouTubeViewers.sln"]
RUN dotnet restore "I:\Jannat x360 D-docx\Meritech\Youtube-Viewers-Master\youtube-viewers-master\youtube-viewers-master\YouTubeViewers.WPF\YouTubeViewers.WPF.csproj"
COPY . .
WORKDIR "I:\Jannat x360 D-docx\Meritech\Youtube-Viewers-Master\youtube-viewers-master\youtube-viewers-master\YouTubeViewers.sln"
RUN dotnet build "I:\Jannat x360 D-docx\Meritech\Youtube-Viewers-Master\youtube-viewers-master\youtube-viewers-master\YouTubeViewers.WPF\YouTubeViewers.WPF.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "I:\Jannat x360 D-docx\Meritech\Youtube-Viewers-Master\youtube-viewers-master\youtube-viewers-master\YouTubeViewers.WPF\YouTubeViewers.WPF.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YourProjectName.dll"]
