const http = require("http");

const server = http.createServer((req, res) => {
  if (req.url === "/") {
    //...
  }

  if (req.url === "/api/courses") {
    //...
  }
});

server.liten(3000);
