let response;
let jsonData;

async function mainLogic() {
  // get user data for date range
  const dateString = document.getElementById("userDateRange").value;
  const [startDateStr, endDateStr] = dateString.split(" - ");
  const startDate = new Date(startDateStr);
  const endDate = new Date(endDateStr);

  // initialize data
  const startDateYear = startDate.getFullYear();
  const startDateMonth = startDate.getMonth() + 1;
  const startDateDay = startDate.getDate();
  const endDateDay = endDate.getDate();

  // logic that checks if selected days are good
  const weekCheck = endDateDay - startDateDay;
  if (weekCheck >= 5 || weekCheck < 4) {
    alert("Please only select a date range between 5 days");
  } else {
    async function retrieveJson(tylerstring) {
      response = await fetch(tylerstring);
      return await response.json();
    }

    const informationTableBody = document.getElementById("information");

    for (let i = startDateDay + 1; i < endDateDay; i++) {
      let apiMainString = `https://tradestie.com/api/v1/apps/reddit?date=${startDateYear}-${String(
        startDateMonth
      ).padStart(2, "0")}-${String(i).padStart(2, "0")}`;
      jsonData = await retrieveJson(apiMainString);

      const ticker = jsonData.ticker;
      const sentimentScore = jsonData.sentiment_score;
      const sentiment = jsonData.sentiment;

      const row = [ticker, sentimentScore, sentiment];

      const tr = document.createElement("tr");
      row.forEach((cellText) => {
        const td = document.createElement("td");
        td.textContent = cellText;
        tr.appendChild(td);
      });
      informationTableBody.appendChild(tr);
    }
  }
}
