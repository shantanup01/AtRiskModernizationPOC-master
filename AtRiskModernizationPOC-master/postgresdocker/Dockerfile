FROM postgres:latest
EXPOSE 5432
COPY dbscripts/10-init.sql /docker-entrypoint-initdb.d/10-init.sql
COPY dbscripts/20-crud.sql /docker-entrypoint-initdb.d/20-database.sql




