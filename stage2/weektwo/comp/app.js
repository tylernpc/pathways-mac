// let response;
// let jsonData;

// async function mainLogic() {
//   const dateString = document.getElementById("userDateRange").value;
//   const [startDateStr, endDateStr] = dateString.split(" - ");

//   const startDate = new Date(startDateStr);
//   const endDate = new Date(endDateStr);

//   const startDateYear = startDate.getFullYear();
//   const startDateMonth = startDate.getMonth() + 1;
//   const startDateDay = startDate.getDate();
//   const endDateDay = endDate.getDate();

//   const weekCheck = endDateDay - startDateDay;
//   if (weekCheck >= 5 || weekCheck < 4) {
//     alert("Please only select a date range between 5 days");
//   } else {
//     async function retrieveJson(dateString) {
//       response = await fetch(dateString);
//       return await response.json();
//     }

//     const informationTableBody = document.getElementById("information");

//     for (let i = startDateDay + 1; i < endDateDay; i++) {
//       let apiMainString = `${startDateYear}-${startDateMonth}-${i}`;
//       jsonData = await retrieveJson(apiMainString);

//       const ticker = jsonData.ticker;
//       const sentimentScore = jsonData.sentiment_score;
//       const sentiment = jsonData.sentiment;

//       const row = [ticker, sentimentScore, sentiment];

//       const tr = document.createElement("tr");
//       row.forEach((cellText) => {
//         const td = document.createElement("td");
//         td.textContent = cellText;
//         tr.appendChild(td);
//       });
//       informationTableBody.appendChild(tr);
//     }
//   }
// }

