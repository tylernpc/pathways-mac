const Joi = require("joi");
const express = require("express");
const app = express();
app.use(express.json());

const recipes = [
    { recipe: 1, course: "fishlet" },
    { recipe: 2, course: "hamburger" },
    { recipe: 3, course: "pizza" },
    { recipe: 4, course: "tacos"}
]

// Create operation
app.post("/api/recipes/:recipe", (req, res) => {
    const recipe = {
        recipe: recipes.length + 1,
        course: req.body.name
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
    if (!recipe)
        res.status(404).send("Apologies, there was no recipe matching that recipe number");
    else
        res.send(recipe);
})

// Update operation

const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Listening on port ${port}...`));