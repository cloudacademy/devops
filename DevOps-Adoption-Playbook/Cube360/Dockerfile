# docker pull xxxxxxxx/yyyyyyy:zzzzzzzzz
# docker run --name nginx-webserver -d -p 8080:80 xxxxxxxx/yyyyyyy:zzzzzzzzz

FROM ubuntu:14.04
RUN apt-get update
RUN apt-get install -y nginx
ADD nginx.conf /etc/nginx/nginx.conf

ADD ./www-data /www-data

EXPOSE 80
CMD ["nginx"]
