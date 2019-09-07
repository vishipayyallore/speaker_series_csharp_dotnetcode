FROM node:latest

COPY . /app
WORKDIR /app

RUN npm install

EXPOSE 3010
ENTRYPOINT ["npm", "start"]
