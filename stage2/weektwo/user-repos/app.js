async function getUserRepo() {
  var apiString = `https://api.github.com/users/${getUserInput()}/repos`;
  var response = await fetch(apiString);
  var jsonData = await response.json();

  if (jsonData.message == "Not Found") {
    document.getElementById("output-json").innerHTML =
      "This user was not found.";
  } else {
    document.getElementById("output-json").innerHTML = "" += `<p><a href="${jsonData[aRepos].html_url}">${jsonData[aRepos].name}</a></p>`;
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
