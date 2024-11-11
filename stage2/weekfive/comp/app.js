// async function apiLogic() {
//     let apiString = `/api/jobs`;

//     let response = await fetch(apiString);
//     let jsonData = await response.json();

//     console.log(jsonData);
// }

// app.js - Front-End (Home Page)
fetch("/api/jobs")
  .then((response) => response.json())
  .then((data) => {
    console.log(data);  // Process job data here and update the UI
  })
  .catch((error) => console.log("Error fetching jobs:", error));

  // Error fetching jobs: SyntaxError: Unexpected token '<', "<!DOCTYPE "... is not valid JSON