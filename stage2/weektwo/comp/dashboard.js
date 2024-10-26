(() => {
  "use strict";

  // api logic
  let response;
  let jsonData;
  let sentimentScores = []; // Array to store sentiment scores for the chart

  async function mainLogic() {
    const dateString = document.getElementById("userDateRange").value;
    const [startDateStr, endDateStr] = dateString.split(" - ");

    const startDate = new Date(startDateStr);
    const endDate = new Date(endDateStr);

    const startDateYear = startDate.getFullYear();
    const startDateMonth = startDate.getMonth() + 1;
    const startDateDay = startDate.getDate();
    const endDateDay = endDate.getDate();

    const weekCheck = endDateDay - startDateDay;
    if (weekCheck >= 5 || weekCheck < 4) {
      alert("Please only select a date range between 5 days");
    } else {
      async function retrieveJson(dateString) {
        response = await fetch(dateString);
        return await response.json();
      }

      const informationTableBody = document.getElementById("information");
      sentimentScores = []; // Clear previous scores before populating new data

      for (let i = startDateDay + 1; i < endDateDay; i++) {
        let apiMainString = `https://tradestie.com/api/v1/apps/reddit?date=${startDateYear}-${startDateMonth}-${i}`;
        jsonData = await retrieveJson(apiMainString);

        const ticker = jsonData.ticker;
        const sentimentScore = jsonData.sentiment_score;
        const sentiment = jsonData.sentiment;

        // Add sentiment score to the array
        sentimentScores.push(sentimentScore);

        // Create table row
        const row = [ticker, sentimentScore, sentiment];
        const tr = document.createElement("tr");
        row.forEach((cellText) => {
          const td = document.createElement("td");
          td.textContent = cellText;
          tr.appendChild(td);
        });
        informationTableBody.appendChild(tr);
      }
      updateChart(sentimentScores); // Update chart with new data
    }
  }

  // Chart configuration
  const ctx = document.getElementById("myChart");
  const myChart = new Chart(ctx, {
    type: "line",
    data: {
      labels: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday"],
      datasets: [
        {
          data: [],
          lineTension: 0,
          backgroundColor: "transparent",
          borderColor: "#007bff",
          borderWidth: 4,
          pointBackgroundColor: "#007bff",
        },
      ],
    },
    options: {
      plugins: {
        legend: {
          display: false,
        },
        tooltip: {
          boxPadding: 3,
        },
      },
    },
  });

  // Function to update the chart with new data
  function updateChart(sentimentScores) {
    myChart.data.datasets[0].data = sentimentScores;
    myChart.update();
  }

  // Expose mainLogic to the global scope
  window.mainLogic = mainLogic;
})();
