async function getBaconIpsum() {
  let typeOfMeat = getTypeOfMeat();
  let numOfParas = getNumOfParas();
  let startWithLorem = getStartWithLorem();

  let apiString;
  if (startWithLorem === true) {
    apiString = `https://baconipsum.com/api/?type=${typeOfMeat}&paras=${numOfParas}&start-with-lorem=1`;
  } else {
    apiString = `https://baconipsum.com/api/?type=${typeOfMeat}&paras=${numOfParas}`;
  }

  let response = await fetch(apiString);
  let jsonData = await response.json();

  document.getElementById("output-json").innerHTML = JSON.stringify(jsonData);

  for (let para in jsonData) {
    document.getElementById("output-formatted").innerHTML +=
      "<p>" + jsonData[para] + "</p>";
  }
  
  return true;
}

function getTypeOfMeat() {
  let typeOfMeat = document.getElementById("typeOfMeat").value;
  if (typeOfMeat === "All") {
    return "meat";
  } else if (typeOfMeat === "Filler") {
    return "meat-and-filler";
  }
  return "meat";
}

function getNumOfParas() {
  return parseInt(document.getElementById("numOfParas").value);
}

function getStartWithLorem() {
  return document.getElementById("startLorem").value === "Yes";
}
