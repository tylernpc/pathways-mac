// declared var
let response;
let jsonData;
let apiString;

function mainLogic() {
  const dateString = document.getElementById("userDateRange").value;
  const [startDateStr, endDateStr] = dateString.split(" - ");

  const startDate = new Date(startDateStr);

  const dateYear = startDate.getFullYear();
  const dateMonth = startDate.getMonth() + 1;
  const dateDay = startDate.getDate();

  // logical issue with this being a first of the month thing, for this example I am not taking that into account
  const weekCheck = userEndDay - userBeginDay;
  if (weekCheck >= 5 || weekCheck < 4) {
    alert("Please only select a date range between 5 days");
  } else {
    async function retrieveJson() {
      for (let i = userBeginDay + 1; i < userEndDay; i++) {
        let apiMiddleString = `${userEndYear}-${userEndMonth}-${i}`;
        response = await fetch(apiMiddleString);
        jsonData = await response.json();
        return jsonData;
      }
    }

    const informationTableBody = document.getElementById("information");
    // 1st step | choose data
    let 
  


    // 2nd step | create data
    const rows = [ [ticker, sentimentScore, sentiment] ]



    // 3rd step | loop through data
    rows.forEach((row) => {
      const tr = document.createElement("tr");
      row.forEach((cellText) => {
        const td = document.createElement("td");
        td.textContent = cellText;
        tr.appendChild(td);
      });
      informationTableBody.appendChild(tr);
    });
  }
}
