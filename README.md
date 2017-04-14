# HealthyProducts
A Hololens App that recommends healthy products.

How to use the database:

```bash
mongoimport -h ds161400.mlab.com:61400 -d healthyfoods -c products -u <user> -p <password> --file products.json --jsonArray
https://api.mlab.com/api/1/databases/healthyfoods/collections/products?q={"barcode": 8214343481}&apiKey=
```
