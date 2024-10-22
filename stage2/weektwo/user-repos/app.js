async function getUserRepo() {
  var apiString = `https://api.github.com/users/${getUserInput()}/repos`;
  var response = await fetch(apiString);
  var jsonData = await response.json();

  if (jsonData.message == "Not Found") {
    document.getElementById("output-json").innerHTML =
      "This user was not found.";
  } else {
    var output = "";
    for (var repos in jsonData) {
      output += `<p><a href="${jsonData[repos].html_url}">${jsonData[repos].name}</a></p>`;
    }
    document.getElementById("output-json").innerHTML = output;
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
