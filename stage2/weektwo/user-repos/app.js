async function getUserRepo() {
  var apiString = `https://api.github.com/users/${getUserInput()}/repos`;
  var response = await fetch(apiString);
  var jsonData = await response.json();
  var jsonString = JSON.stringify(jsonData);

  if (jsonData.message == "Not Found") {
    document.getElementById("output-json").innerHTML =
      "This user was not found.";
  } else {
    for (var repos in jsonString) {
      document.getElementById('output-json').innerHTML = (`<p><a href="${jsonString[repos].html_url}">${jsonString[repos].name}</a></p>`);
    }
  }
}

function getUserInput() {
  return document.getElementById("userUserName").value;
}

/*
  // deserialize code
  var jsonString = JSON.stringify(jsonData);
  var userObject = JSON.parse(jsonString);
  console.log(userObject[0].name);
  */

  // document.getElementById("output-json").innerHTML = "" += 