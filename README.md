# aspnet-blog

command
```bash
dnu build
set ASPNET_ENV=Development
dnx web
dnx web --ASPNET_ENV=Development

dnx web --server.urls http://0.0.0.0:81 --ASPNET_ENV Development
```

Migration
```bash
dnx ef

dnx ef migrations add init
dnx ef database update
```
