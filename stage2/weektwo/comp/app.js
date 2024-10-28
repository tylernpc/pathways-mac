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
    // Main programming logic
    async function retrieveJson(apiMainString) {
      response = await fetch(apiMainString);
      return await response.json();
    }

    for (let i = startDateDay + 1; i < endDateDay; i++) {
        let apiMainString = `https://cors-anywhere.herokuapp.com/https://tradestie.com/api/v1/apps/reddit?date=${startDateYear}-${String(startDateMonth).padStart(2, "0")}-${String(i).padStart(2, "0")}`;

      // Retrieve data and log each entry
      jsonData = await retrieveJson(apiMainString);

      for (let j = 0; j < jsonData.length; j++) {
        let ticker = jsonData[j].ticker;
        let sentimentScore = jsonData[j].sentiment_score;
        let sentiment = jsonData[j].sentiment;

        console.log(
          "Ticker:",
          ticker,
          "Sentiment Score:",
          sentimentScore,
          "Sentiment:",
          sentiment
        );
      }
    }
  }
}
