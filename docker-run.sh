#!/bin/bash 

#"c:\program files\oracle\virtualbox\VBoxManage.exe" controlvm "default" natpf1 delete "http"
#"c:\program files\oracle\virtualbox\VBoxManage.exe" controlvm "default" natpf1 "http,tcp,,5000,,5000"
#eval $("C:\Program Files\Docker Toolbox\docker-machine.exe" env default)
docker build -t primecoreapi .
docker run -ti --rm -p 5000:5000 primecoreapi
