const Joi = require("joi");
const express = require("express");
const app = express();
app.use(express.json());

const todo = [];
const doing = [];
const done = [];

app.get("/api/todo", (req, res) => {
  res.send("Todo end point");
});

app.get("/api/doing", (req, res) => {
  res.send("Doing end point");
});

app.get("/api/doing", (req, res) => {
  res.send("Done end point");
});

const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Listening on port ${port}...`));
