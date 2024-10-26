// declared var
let response;
let jsonData;
let apiString;

function mainLogic() {
  const dateString = document.getElementById("userDateRange").value;
  const [startDateStr, endDateStr] = dateString.split(" - ");

  const startDate = new Date(startDateStr);
  const endDate = new Date(endDateStr);

  const startDateYear = startDate.getFullYear();
  const startDateMonth = startDate.getMonth() + 1;
  const startDateDay = startDate.getDate();
  const endDateDay = endDate.getDate();

  // logical issue with this being a first of the month thing, for this example I am not taking that into account
  const weekCheck = endDateDay - startDateDay;
  if (weekCheck >= 5 || weekCheck < 4) {
    alert("Please only select a date range between 5 days");
  } else {
    async function retrieveJson() {
      for (let i = startDateDay + 1; i < endDateDay; i++) {
        let apiMiddleString = `${startDateYear}-${startDateMonth}-${i}`;
        response = await fetch(apiMiddleString);
        jsonData = await response.json();
        return jsonData;
      }
    }

    const informationTableBody = document.getElementById("information");
    // 1st step | choose data
    let ticker = retrieveJson().item.ticker;
    let sentimentScore = retrieveJson().item.sentiment_score;
    let sentiment = retrieveJson().item.sentiment;
  
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
