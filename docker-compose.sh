#!/bin/bash 

"c:\program files\oracle\virtualbox\VBoxManage.exe" controlvm "default" natpf1 delete "http"
"c:\program files\oracle\virtualbox\VBoxManage.exe" controlvm "default" natpf1 "http,tcp,,81,,80"
eval $("C:\Program Files\Docker Toolbox\docker-machine.exe" env default)
docker-compose up -d
docker-compose scale prime_server=5