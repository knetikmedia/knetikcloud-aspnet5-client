# IO.Swagger - ASP.NET Core 1.0 Server

This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t IO.Swagger .
docker run -p 5000:5000 IO.Swagger
```
