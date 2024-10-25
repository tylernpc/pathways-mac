// declared var
let response;
let jsonData;
let apiString;

function getUserDate() {
  const dateString = document.getElementById("userDateRange").value;
  const [startDateStr, endDateStr] = dateString.split(" - ");

  const startDate = new Date(startDateStr);
  const endDate = new Date(endDateStr);

  const userBeginYear = startDate.getFullYear();
  const userBeginMonth = startDate.getMonth() + 1;
  const userBeginDay = startDate.getDate();

  const userEndYear = endDate.getFullYear();
  const userEndMonth = endDate.getMonth() + 1;
  const userEndDay = endDate.getDate();

  // logical issue with this being a first of the month thing, for this example I am not taking that into account
  const weekCheck = userEndDay - userBeginDay;
  if (weekCheck >= 5 || weekCheck < 4) {
    alert("Please only select a date range between 5 days");
  } else {
    let apiBeginString = `${userBeginYear}-${userBeginMonth}-${userBeginDay}`;
    
    for (let i = userBeginDay + 1; i < userEndDay; i++) {
      let apiMiddleDay = i;
      console.log(`${userEndYear}-${userEndMonth}-${apiMiddleDay}`); // this is the api key
    }
    let apiEndString = `${userEndYear}-${userEndMonth}-${userEndDay}`;
    
  }
}

// async function fetchMarketSentiment() {
//   apiString = `https://tradestie.com/api/v1/apps/reddit?date=${userBeginYear}-10-24`;
//   response = await fetch(apiString);
//   jsonData = await response.json();
// }
