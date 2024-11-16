const Joi = require("joi");
const express = require("express");
const app = express();
app.use(express.json());

const recipes = [
  { recipe: 1, course: "fishlet" },
  { recipe: 2, course: "hamburger" },
  { recipe: 3, course: "pizza" },
  { recipe: 4, course: "tacos" },
];

// Create operation
app.post("/api/recipes", (req, res) => {
  const { error } = validateCourse(req.body);
  if (error) {
    res.status(400).send(result.error.details[0].message);
    return;
  }

  const recipe = {
    recipe: recipes.length + 1,
    course: req.body.course,
  };
  recipes.push(recipe);
  res.send(recipe);
});

// Read operations
app.get("/api/recipes", (req, res) => {
  res.send(recipes);
});

app.get("/api/recipes/:recipe", (req, res) => {
  const recipe = recipes.find((r) => r.recipe === parseInt(req.params.recipe));
  if (!recipe) {
    res
      .status(404)
      .send("Apologies, there was no recipe matching that recipe number");
  } else {
    res.send(recipe);
  }
});

// Update operation
app.put("/api/recipes/:recipe", (req, res) => {
  const recipe = recipes.find((r) => r.recipe === parseInt(req.params.recipe));
  if (!recipe) {
    return res
      .status(404)
      .send("Apologies, there was no recipe matching that recipe number");
  } else {
    const { error } = validateCourse(req.body);
    if (error) {
      return res.status(400).send(error.details[0].message);
    }

    console.log("Request body:", req.body);

    recipe.course = req.body.course;
    res.send(recipe);
  }
});

// Delete operation
app.delete("/api/recipes/:recipe", (req, res) => {
  const recipe = recipes.find((r) => r.recipe === parseInt(req.params.recipe));
  if (!recipe) {
    res.status(404).send("Apologies, there was no recipe matching that recipe number");
  } else {
    const index = recipes.indexOf(recipe);
    recipes.splice(index, 1);
    res.send(recipe);
  }
});

// Basic validation function
function validateCourse(recipe) {
  const schema = Joi.object({
    course: Joi.string()
      .pattern(/^[A-Za-z\s]+$/)
      .min(1)
      .required(),
  });

  return schema.validate(recipe);
}

const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Listening on port ${port}...`));