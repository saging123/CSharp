output to exe

dotnet publish -c Release  --no-self-contained --runtime win-x64 -p:PubslishTrimmed=true -p:PublishSingleFile=true