# Sync.WebApi
Web api to sync with ProductWebApi

## To run you need

- Docker
- Docker Compose


## How to run

In the project root

Start the database
```
docker-compose up -d
```

## Database

With your favorite client:

```mongo
use Sync
```

```mongo
Sync.createCollection("Product")
```

The connection string
```
mongodb://syncadmin:syncadmin@0.0.0.0:27017
```


And start the application
```
dotnet run
```

How to run the ProductsWebApi 
[Products.WebApi.Spa](https://github.com/anologicon/Products.WebApi.Spa)
