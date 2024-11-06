document.getElementById("submit-btn").addEventListener("click", function (event) {
  
  let textBoxValue = document.getElementById("textBox").value;
  
  if (textBoxValue === "") {
      alert("Please leave a comment!");
  } else {
      alert("Worked");
  }
});
