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
    // main programming logic
    for (let i = startDateDay + 1; i < endDateDay; i++) {
      async function retrieveJson() {
        let apiMainString = `https://tradestie.com/api/v1/apps/reddit?date=${startDateYear}-${String(startDateMonth).padStart(2, "0")}-${String(i).padStart(2, "0")}`;
        
        // make the call
        response = await fetch(apiMainString);
        jsonData = await response.json();

        for (let i = 0; i < jsonData.length; i++) {
          let ticker = jsonData[i].ticker;
          let sentimentScore = jsonData[i].sentiment_score;
          let sentiment = jsonData[i].sentiment;

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
}